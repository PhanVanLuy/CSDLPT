using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FrmThi : Form
    {

        //private int dem = 0;
        public static Boolean checkThi = false;
        public static Boolean isSinhVien;
        private int thoigianThi = 0;
        private int s = 1;
        private int soCauThi = 0;
        public static CauHoi[] listCauHoi;
        public static ListViewItem baiThi;
        private float diem = 0;
        private DateTime ngayThi;
        private string maLop = "";


        public FrmThi()
        {
            InitializeComponent();

            loadControl();


        }

        private void loadControl()
        {
            cbbTenMon.SelectedItem = 0;
        }

        public void loadCauHoi()
        {
            string cmd = "";
            if (isSinhVien == true)
            {
                cmd = String.Format(Queries.SV_THI, edtMaLop.Text, Program.mSV, cbbTenMon.SelectedValue.ToString(), cbbLanThi.SelectedValue.ToString().Trim());
            }
            else
            {
                cmd = String.Format(Queries.GV_THI_THU, cbbMaLop.SelectedValue.ToString() , cbbTenMon.SelectedValue.ToString(), cbbLanThi.SelectedValue.ToString().Trim());
            }

            Debug.WriteLine("Query load cau hoi:" + cmd);

            DataTable dt = Program.ExecSqlDataTable(cmd);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Số lượng câu hỏi không đủ, \nKhông thể lấy đề thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            lbTG.Visible = lbTime.Visible = true;
            btnBatDau.Visible = false;
            btnNopBai.Visible = true;

            timer1.Start();
            bdsCauHoi.DataSource = dt;

            cbbMaLop.Enabled = cbbTenMon.Enabled = cbbLanThi.Enabled = false;

            listCauHoi = new CauHoi[soCauThi];

            checkThi = true;

            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (isSinhVien)
                {
                    listCauHoi[i] = new CauHoi();
                    listCauHoi[i].Width = scrollCauHoi.Width;
                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsCauHoi[i])["CauHoi"];
                    listCauHoi[i].IDDe = (int)((DataRowView)bdsCauHoi[i])["CauSo"];
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsCauHoi[i])["NoiDung"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsCauHoi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsCauHoi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsCauHoi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsCauHoi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsCauHoi[i])["DapAn"].ToString();
                    listCauHoi[i].MaBangDiem = (int)((DataRowView)bdsCauHoi[i])["MaBD"];
                    listCauHoi[i].CauDaChon = "";
                }
                else
                {
                    listCauHoi[i] = new CauHoi();
                    listCauHoi[i].Width = scrollCauHoi.Width;
                    listCauHoi[i].CauSo = i + 1;
                    listCauHoi[i].IDBaiThi = (int)((DataRowView)bdsCauHoi[i])["CauHoi"];
                    listCauHoi[i].NDCauHoi = ((DataRowView)bdsCauHoi[i])["NoiDung"].ToString();
                    listCauHoi[i].CauA = ((DataRowView)bdsCauHoi[i])["A"].ToString();
                    listCauHoi[i].CauB = ((DataRowView)bdsCauHoi[i])["B"].ToString();
                    listCauHoi[i].CauC = ((DataRowView)bdsCauHoi[i])["C"].ToString();
                    listCauHoi[i].CauD = ((DataRowView)bdsCauHoi[i])["D"].ToString();
                    listCauHoi[i].CauDapAn = ((DataRowView)bdsCauHoi[i])["Dap_An"].ToString();
                    listCauHoi[i].CauDaChon = "";
                }

                Debug.WriteLine("Cau so: " + listCauHoi[i].IDBaiThi);

                String[] arr = new string[2];
                arr[0] = (i + 1).ToString();
                arr[1] = listCauHoi[i].CauDaChon;

                baiThi = new ListViewItem(arr);
                Debug.WriteLine("cau: " + (i + 1) + ":" + listCauHoi[i].CauDapAn);
                this.resultlistview.Items.Add(baiThi);

                if (scrollCauHoi.Controls.Count < 0)
                {
                    scrollCauHoi.Controls.Clear();
                }
                else
                    scrollCauHoi.Controls.Add(listCauHoi[i]);

            }


        }

        private async Task loadThongTinSV()
        {
            edtHoTenSV.Text = Program.mHoten; // tenSV lay tu dang nhap
            if (!String.IsNullOrEmpty(Program.mSV))
            {
                Debug.WriteLine("Ma Sinh Vien: " + Program.mSV);
                string cmd = String.Format(Queries.LAY_THONG_TIN_SV_THI, Program.mSV);

                Program.myReader = Program.ExecSqlDataReader(cmd);
                //get malop, tenlop va hien thi
                if (Program.myReader == null)
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
                else
                {
                    Program.myReader.Read();
                    maLop = edtMaLop.Text = Program.myReader.GetString(0).Trim();
                    edtTenLop.Text = Program.myReader.GetString(1).Trim();
                    //cbbTenLop.Enabled = true;
                    Program.myReader.Close();
                    Program.conn.Close();
                }

                Program.myReader = Program.ExecSqlDataReader(cmd);
                Program.myReader.Close();
                Debug.WriteLine("cmd: " + cmd);
                //cbbTenLop.Enabled = false;
                //sP_DSMonHocDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMonHocDaDK, maLop);


            }
            else
            {
                lbHoTen.Text = "Họ tên GV";
                cbbMaLop.Enabled = false;
            }


        }

        private void scrollCauHoi_Paint(object sender, PaintEventArgs e)
        {

        }
        public Boolean loadChiTietLanThi()
        {
            string cmd = "";
            string maLop = "";

            if (isSinhVien)
            {
                if (cbbTenMon.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                //if (cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                //{
                //    MessageBox.Show("Lần thi sinh viên rỗng ", "Thông báo", MessageBoxButtons.OK);
                //    return false;
                //}

                maLop = edtMaLop.Text;

            }
            else
            {
                if (cbbMaLop.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (cbbTenMon.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Môn học thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (bdsLanThi.Count > 0 && cbbLanThi.SelectedValue.ToString().Trim().Equals(""))
                {
                    MessageBox.Show("Lần thi thử rỗng ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                maLop = cbbMaLop.SelectedValue.ToString().Trim();

            }

            cmd = String.Format(Queries.LAY_THONG_TIN_CHI_TIET_LAN_THI, maLop, cbbTenMon.SelectedValue.ToString(), cbbLanThi.SelectedValue.ToString());
            Debug.WriteLine("Lay thong tin chi tiet lan thi: " + cmd);

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null)
                {
                    edtTrinhDo.Text = "";
                    edtSoCau.Value = 0;
                    txtThoiGian.Text = "";
                    pnBatdau.Visible = false;
                    Program.conn.Close();
                    return false;
                }
                else
                {
                    Program.myReader.Read();

                    edtTrinhDo.Text = Program.myReader.GetString(0);
                    soCauThi = Program.myReader.GetInt16(1);
                    edtSoCau.Value = soCauThi;
                    thoigianThi = Program.myReader.GetInt16(2);
                    lbTime.Text = thoigianThi + ": 00";
                    txtThoiGian.Text = thoigianThi.ToString();
                    edtNgayThi.DateTime = ngayThi = Program.myReader.GetDateTime(3);
                    Program.myReader.Close();
                    Program.conn.Close();
                    pnBatdau.Visible = true;
                    btnBatDau.Visible = true;
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối lấy thông tin thi " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }
        }

        private async void FrmThi_LoadAsync(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.SP_DSLopDaDK' table. You can move, or remove it, as needed.
            this.sP_DSLopDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLopDaDK);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            pnBatdau.Visible = false;
            tN_CSDLPTDataSet.EnforceConstraints = false;
            sP_DSLopDaDKTableAdapter.Connection.ConnectionString = Program.connstr;
            sP_DSLopDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLopDaDK);
            cbbMaLop.SelectedIndex = 0;

            btnBatDau.Visible = true;
            btnNopBai.Visible = false;

            if (String.IsNullOrEmpty(Program.mSV))
            {
                isSinhVien = false;
                cbbMaLop.Visible = true;
            }
            else
            {
                isSinhVien = true;
                cbbMaLop.Visible = false;
            }
            if (bdsDSLopDK.Count <= 0)
            {
                MessageBox.Show("Danh sách lớp đăng kí rỗng ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {

                this.sP_DSMonHocDaDKTableAdapter.Connection.ConnectionString = Program.connstr;
                if (isSinhVien)
                {
                    await loadThongTinSV();
                }
                
                this.sP_DSMonHocDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMonHocDaDK, edtMaLop.Text);
                this.sP_DSMonHocDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMonHocDaDK, cbbMaLop.SelectedValue.ToString().Trim());

                cbbTenMon.SelectedIndex = 0;
                Debug.WriteLine("cbbTenLop.SelectedValue.ToString().Trim() " + cbbMaLop.SelectedValue.ToString().Trim());

                if (bdsDSMHDaDK.Count > 0)
                {
                    Debug.WriteLine("bdsDSMHDaDK.Count > 0 in formThiLoad()");
                    edtMaMon.Text = cbbTenMon.SelectedValue.ToString();

                    this.sP_DSLanThiTableAdapter.Connection.ConnectionString = Program.connstr;
                    Debug.WriteLine("cbbTenLop.SelectedValue.ToString() " + cbbMaLop.SelectedValue.ToString());
                    Debug.WriteLine("cbbTenMon.SelectedValue.ToString() " + cbbTenMon.SelectedValue.ToString());
                    this.sP_DSLanThiTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThi,
                        cbbTenMon.SelectedValue.ToString(),
                        cbbMaLop.SelectedValue.ToString());

                    if (bdsLanThi.Count <= 0)
                    {
                        MessageBox.Show("Môn học " + cbbTenMon.SelectedItem.ToString() + "Không còn lần thi nào", "Thông báo", MessageBoxButtons.OK);
                        resetChiTiet();
                        return;
                    }
                    else
                    {
                        try
                        {
                            cbbLanThi.SelectedIndex = 0;

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("Không có data trên combobox");
                        }
                        loadChiTietLanThi();
                    }
                }
                else
                {
                    MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                    resetChiTiet();
                    return;
                }

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!loadChiTietLanThi()) return;

            if (!String.IsNullOrEmpty(Program.mSV))
            {
                String ktlan = String.Format(Queries.KT_LAN_THI, Program.mSV , cbbTenMon.SelectedValue.ToString() , cbbLanThi.SelectedValue.ToString().Trim());

                int kq = Program.ExecSqlNonQuery(ktlan);
                Program.conn.Close();
                if (kq == 1)
                {
                    return;
                }

                DateTime today = DateTime.Today;
                if (today.CompareTo(ngayThi.Date) < 0)
                {
                    Debug.WriteLine("Ngay thi : " + ngayThi + " ngay hien tai: " + today);
                    MessageBox.Show("Chưa đến thời gian thi!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else if (today.CompareTo(ngayThi.Date) > 0)
                {
                    Debug.WriteLine("Ngay thi : " + ngayThi + " ngay hien tai: " + today);
                    MessageBox.Show("Đã qua thời gian thi!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            loadCauHoi();
        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadChiTietLanThi();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception from  cbbLanThi_SelectedIndexChanged()" + ex);
            }
        }

        private void edtNgayThi_ValueChanged(object sender, EventArgs e)
        {
        }

        private void edtTenLop_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_DSLanThiTableAdapter.Connection.ConnectionString
                    = this.sP_DSMonHocDaDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DSMonHocDaDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMonHocDaDK, cbbMaLop.SelectedValue.ToString().Trim());
                cbbTenMon.SelectedIndex = 0;

                this.sP_DSLanThiTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThi, cbbTenMon.SelectedValue.ToString().Trim(), cbbMaLop.SelectedValue.ToString().Trim());
                cbbLanThi.SelectedIndex = 0;
                if (bdsDSMHDaDK.Count > 0)
                {
                    gbThongTinBaiThi.Enabled = true;
                }
                else
                {
                    gbThongTinBaiThi.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception from cbbTenLop_SelectedIndexChanged() " + ex);
            }
        }

        private void summarylistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void capNhapDaChon(int cauSo, String daChon)
        {
            if (checkThi)
            {
                String[] arr = new string[2];
                arr[0] = (cauSo).ToString();
                arr[1] = daChon;
                ListViewItem themDaChon = new ListViewItem(arr);
                resultlistview.Items[cauSo - 1] = themDaChon;
            }
        }

        private async void cbbTenMon_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (bdsDSLopDK.Count <= 0)
            {
                return;
            }
            if (bdsDSMHDaDK.Count > 0)
            {
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString().Trim();

                await loadLanThi(cbbTenMon.SelectedValue.ToString().Trim(), cbbMaLop.SelectedValue.ToString().Trim());
                if (bdsLanThi.Count <= 0)
                {
                    MessageBox.Show("Môn học " + cbbTenMon.SelectedValue.ToString() + " không có lần thi", "Thông báo", MessageBoxButtons.OK);
                    resetChiTiet();
                    return;
                }
                else
                {
                    //loadChiTietLanThi();  tu dong thuc thi khi cbbTenMon thay doi -> cbblanThi thay doi theo
                    cbbLanThi.SelectedIndex = 0;
                }
            }
            else
            {
                Debug.WriteLine("cbbTenMon change item");
                MessageBox.Show("Không có môn học đăng ký", "Thông báo", MessageBoxButtons.OK);
                resetChiTiet();
                return;
            }
        }
        private void resetChiTiet()
        {
            try
            {
                if (cbbTenMon.SelectedItem.ToString().Equals(""))
                {
                    edtMaMon.Text = "";
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Exception from resetChiTiet() " + ex);
            }

            txtThoiGian.Text = "00";
            cbbLanThi.SelectedText = "";
            edtTrinhDo.Text = "";
        }
        private async Task loadLanThi(string tenMon, string tenLop)
        {
            this.sP_DSLanThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSLanThiTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThi, tenMon, tenLop);
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn nộp bài", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                timer1.Stop();
                checkThi = false;
                ghiDiem();

            }
        }
        private void ghiDiem()
        {
            int kq = 0; // số câu chọn đúng
            double diem1Cau = 0;
            diem1Cau = Math.Round((double)10 / soCauThi, 2);


            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].CauDaChon.Trim().CompareTo(listCauHoi[i].CauDapAn.Trim()) == 0)
                    kq++;

            }

            diem = (float)(kq * diem1Cau);

            if (isSinhVien)
            {
                string cmd = String.Format(Queries.GHI_DIEM_SV, diem, Program.mSV, cbbTenMon.SelectedValue.ToString().Trim(), cbbLanThi.SelectedValue.ToString().Trim());

                try
                {
                    int result = Program.ExecSqlNonQuery(cmd);
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi điểm thi " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                }

                ghiDapAn();
            }

            MessageBox.Show("Số câu đúng: " + kq + "/" + soCauThi + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);


            // Khong cho thao tác sau khi nộp bài
            resultlistview.Enabled = true;
            //scrollCauHoi.Enabled = false;  vẫn cho xem lại đáp án trước
            btnNopBai.Enabled = false;
            btnBatDau.Enabled = false;
        }
        private void ghiDapAn()
        {


            // ghi dap an vao table baithi
            SqlConnection conn = new SqlConnection(Program.connstr);
            SqlTransaction tran;
            conn.Open();

            // bat dau giao tac
            tran = conn.BeginTransaction();
            try
            {
                for (int i = 0; i < listCauHoi.Length; i++)
                {
                    SqlCommand cmd2 = new SqlCommand(String.Format(Queries.GHI_BAI_THI_SV, listCauHoi[i].CauDaChon, listCauHoi[i].IDBaiThi), conn);
                    Debug.WriteLine("GHI_BAI_THI_SV:" + cmd2);
                    cmd2.Connection = conn;
                    cmd2.Transaction = tran;
                    cmd2.ExecuteNonQuery();
                }
                tran.Commit();

            }
            catch (Exception ex)
            {
                tran.Rollback();
                XtraMessageBox.Show("Lỗi ghi bài thi vào database. Bạn hãy xem lại! " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            s--;
            if (s == 0)
            {
                if (thoigianThi != 0)
                {
                    thoigianThi--;
                    s = 59;
                }
            }
            lbTime.Text = thoigianThi.ToString() + " : " + s.ToString();
            if (thoigianThi == 0 && s == 0)
            {
                timer1.Stop();
                cbbMaLop.Enabled = cbbTenMon.Enabled = cbbLanThi.Enabled = true;
                checkThi = false;
                MessageBox.Show("Đã hết thời gian thi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ghiDiem();
                btnNopBai.Enabled = false;
            }

        }
    }
}
