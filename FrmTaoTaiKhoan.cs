using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FrmTaoTaiKhoan : Form
    {
        public FrmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LayDSGV";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbGiangVien.DataSource = bdsgv;
            cbGiangVien.DisplayMember = "HOTEN";
            cbGiangVien.ValueMember = "MAGV";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbTenLogin.Text = "";
            txbMatKhau.Text = "";
            txbXacNhanMK.Text = "";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txbTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
                txbTenLogin.Focus();
                return;
            }
            if (txbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbMatKhau.Focus();
                return;
            }
            if (txbXacNhanMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (txbXacNhanMK.Text != txbMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (rdoTRUONG.Checked == false && rdoCOSO.Checked == false && rdoGIANGVIEN.Checked == false)
            {
                MessageBox.Show("Nhóm quyền không được thiếu!", "", MessageBoxButtons.OK);
                rdoCOSO.Focus();
                return;
            }
            string login = txbTenLogin.Text;
            string matkhau = txbMatKhau.Text;
            string user = cbGiangVien.SelectedValue.ToString();
            string role = "";
            if (rdoTRUONG.Checked) role = "TRUONG";
            if (rdoCOSO.Checked) role = "COSO";
            if (rdoGIANGVIEN.Checked) role = "GIANGVIEN";

            String subLenh = String.Format(Queries.DANG_NHAP, login, matkhau, user, role);

            string strLenh = " DECLARE @return_value int " + subLenh +
                    " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Program.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Login bị trùng . Mời bạn nhập login khác !", "", MessageBoxButtons.OK);

            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("Giảng viên đã có tài khoản rồi !", "", MessageBoxButtons.OK);


            }
            else if (resultCheckLogin == 3)
            {
                MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }

        private void FrmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            loadGVcombobox();


            if (Program.mGroup.Equals("COSO"))
            {
                rdoCOSO.Checked = true;
                rdoCOSO.Enabled = rdoGIANGVIEN.Enabled = true;
                rdoTRUONG.Enabled  = false;
            }
            if (Program.mGroup.Equals("TRUONG"))
            {
                rdoTRUONG.Checked = true;
                rdoCOSO.Enabled = rdoGIANGVIEN.Enabled = false;
            }
            if (Program.mGroup.Equals("GIANGVIEN"))
            {
                rdoGIANGVIEN.Checked = rdoCOSO.Enabled = rdoTRUONG.Enabled = false;
            }
        }
    }
}
