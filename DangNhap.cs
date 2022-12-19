using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class DangNhap : Form
    {


        /// <summary>
        /// 
        /// </summary>
        /// 


        private SqlConnection connection = new SqlConnection();
        private bool isSinhVien = false;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void layDSPM()
        {
            DataTable dt = new DataTable();
            if (connection.State ==  ConnectionState.Closed)
            {
                connection.Open();
               
            }
            String cmd = Queries.DANG_NHAP;
            SqlDataAdapter da = new SqlDataAdapter(cmd, connection);
            da.Fill(dt);
            connection.Close();

            Program.bds_dspm.DataSource = dt;
            cbbCoSo.DataSource = Program.bds_dspm;
            cbbCoSo.DisplayMember = "TENCOSO";
            cbbCoSo.ValueMember = "TENSERVER";
        }


        private int ketNoiCSDL()
        {
            if(connection !=  null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            try
            {
                connection.ConnectionString = Program.connstr_publicsher;
                connection.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối CSDL. " +
                    "\nVui lòng kiểm tra lại Kết nối!");
                return 0;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
            if (isSinhVien)
            {
                tbMatKhau.Enabled = false;
                lbMatKhau.Enabled = false;
                lbTaiKhoan.Text = "MSSV";
                
            }
            else
            {
                tbMatKhau.Enabled = true;
                lbMatKhau.Enabled = true;
                lbTaiKhoan.Text = "Tài khoản";
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (ketNoiCSDL() == 0) return;
            layDSPM();
            //cbbCoSo.SelectedIndex = 1;
            //cbbCoSo.SelectedIndex = 0;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            Program.severname = cbbCoSo.SelectedValue.ToString();
            if (isSinhVien == false)
            {
                // is teacher
                //validation
                Program.mSV = "";
                if (tbTaiKhoan.Text.Trim() =="" || tbMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!!");
                    return;
                }
                else
                {
                    Program.mlogin = tbTaiKhoan.Text;
                    Program.password = tbMatKhau.Text;
                    if (Program.KetNoi() == 0) return;
                }

                String cmd_GV = String.Format(Queries.LAY_THONG_TIN_GV_DANG_NHAP, Program.mlogin);
                Program.myReader = Program.ExecSqlDataReader(cmd_GV);
                if (Program.myReader == null)
                {
                    MessageBox.Show("Đăng nhập thất bại,\nTài khoản không hợp lệ");
                    return;
                }
                Program.myReader.Read();
                Program.mGroup = Program.myReader.GetString(2);
                Program.mHoten = Program.myReader.GetString(1);

                //Program.myReader.Close();
            }
            else
            {
                // isSinhVIen = true
                Program.mlogin = "SVKN";
                Program.password = "123";
                Program.mSV = tbTaiKhoan.Text;
                if (Program.KetNoi() == 0) return;

                String cmd_SV = String.Format(Queries.LAY_THONG_TIN_SV_DANG_NHAP, tbTaiKhoan.Text, tbMatKhau.Text);
                SqlDataReader reader = Program.ExecSqlDataReader(cmd_SV);

                if (reader.HasRows == false && isSinhVien == true)
                {
                    MessageBox.Show("Đăng nhập thất bại!|\n Mã sinh viên không tồn tại");
                    return;
                }
                reader.Read();
                Program.username = reader.GetString(0);
                Program.mHoten = reader.GetString(1);
                Program.mGroup = "SV";

                reader.Close();
            }

            Program.mCoSo = cbbCoSo.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }



            // Nếu ko ok thì uncomment đoạn này
            //reader.Read();
            Program.conn.Close();
            MessageBox.Show("Đăng nhập thành công");
            MainForm mf = new MainForm();
            mf.Show();
            //this.Visible = false;
            //this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.severname = cbbCoSo.SelectedValue.ToString();
        }
    }
}
