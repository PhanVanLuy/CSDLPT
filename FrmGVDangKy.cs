using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CSDLPT
{
    public partial class FrmGVDangKy : DevExpress.XtraEditors.XtraForm
    {

        private int dem = 0;
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private Boolean checkSua = false;

        public FrmGVDangKy()
        {
            InitializeComponent();
             this.tbGiangVienDK.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGVDangKy.AddNew();
                btnGhiGVDK.Enabled= cbbTenLop.Enabled = cbbTenMon.Enabled   = true;
                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled;
                gcDetail.Enabled = true;

                cbbTenGV.Enabled = true;
                cbbTenGV.SelectedIndex = 0;
                cbbTenMon.SelectedIndex = 0;
                cbbTenLop.SelectedIndex = 0;
                cbbTrinhDo.SelectedIndex = 0;
             
               
                edtTrinhdo.Text = "";
                edtMaMon.Text = "";
                edtMaGV.Text = "";
                edtMaLop.Text = "";
                edtSoCau.Text = "";
                
                edtLan.Text = "1";
                edtTG.Text = "0";

                 
                gcGVDK.Enabled = false;



               
                checkThem = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên đăng ký " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiGVDK()
        {
            try
            {
                bdsGVDangKy.EndEdit();
                bdsGVDangKy.ResetCurrentItem();
                this.tbGiangVienDK.Update(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);

                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled;
                gcDetail.Enabled = false;
                checkThem = checkSua = false;
                checkSave = true;
                gcGVDK.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                Console.WriteLine("loi : " + ex);
            }

        }

       
        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaGV.Text = cbbTenGV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtTrinhdo.Text = cbbTrinhDo.SelectedValue.ToString();
                Console.WriteLine("hungbt: " + edtTrinhdo.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString();
                
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                edtMaLop.Text = cbbTenLop.SelectedValue.ToString();
              
            }
            catch (Exception ex)
            {

            }

        }

        private void btnXoaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (this.bdsGVDangKy.Count == 0)
            {
                MessageBox.Show("Không có giảng viên đăng ký để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                String sql = "EXEC SP_KT_XOA_GVDK N'" + edtMaMon.Text.Trim()
                   + "', N'" + edtMaLop.Text.Trim()
                   + "',  " + edtLan.Text;

                if (Program.conn.State == ConnectionState.Open) Program.conn.Close();
                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên "
                    + ((DataRowView)this.bdsGVDangKy.Current).Row["MAGV"].ToString() + " của môn "
                    + ((DataRowView)this.bdsGVDangKy.Current).Row["MAMH"].ToString() + " lớp "
                     + ((DataRowView)this.bdsGVDangKy.Current).Row["MALOP"].ToString() + " lần "
                     + ((DataRowView)this.bdsGVDangKy.Current).Row["LAN"].ToString()
                    + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            //phải chạy lệnh del from where mới chính xác
                            bdsGVDangKy.RemoveCurrent();
                            //đẩy dữ liệu về adapter
                            this.tbGiangVienDK.Update(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                        }
                    }
                }

            }
        }

        private void btnSuaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDangKy.Count == 0)
            {
                MessageBox.Show("Không có giảng viên đăng ký để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                cbbTenLop.Enabled = cbbTenMon.Enabled ;
                checkSua = true;
                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = false;
                gcDetail.Enabled = true;
                gcGVDK.Enabled = false;
                checkSave = false;
                cbbTrinhDo.SelectedValue = ((DataRowView)this.bdsGVDangKy.Current).Row["TRINHDO"].ToString();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGVDangKy.CancelEdit();

            this.tbGiangVienDK.Connection.ConnectionString = Program.connstr;
            this.tbGiangVienDK.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
            this.tbDSLopADT.Connection.ConnectionString = Program.connstr;
            this.tbDSLopADT.Fill(this.tN_CSDLPTDataSet1.LOP);

            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbDSMH.Connection.ConnectionString = Program.connstr;
            this.tbDSMH.Fill(this.tN_CSDLPTDataSet1.MONHOC);
            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = false;

            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled  = true;
            gcDetail.Enabled = false;
            checkSave = true;
            checkThem = checkSua = false;
            gcGVDK.Enabled = true;
        }

        private void btnGhiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {

                if (edtNgayThi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập ngày thi", "", MessageBoxButtons.OK);
                    edtNgayThi.Focus();
                    return;
                }
                //câu thi
                if (edtSoCau.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập số câu thi", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }

                // ngày không hợp lệ
                var FromDate = edtNgayThi.DateTime;
                var ToDate = DateTime.Today;
                Console.WriteLine("ngay thi: " + FromDate);
                Console.WriteLine("ngay hien tai: " + ToDate);
                int compare = DateTime.Compare(ToDate, FromDate);
                if (compare > 0)
                {
                    MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                    return;
                }

                //số câu thi không hợp lệ
                int socau = Decimal.ToInt16(edtSoCau.Value);
                if (socau < 10 || socau > 100)
                {
                    MessageBox.Show("Số câu thi phải >=10 và <=100 câu, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }

                String mamh = cbbTenMon.SelectedValue.ToString();
                String ktsocau = "select count (cauhoi) from BODE where MAMH = '" + mamh + "'";
                if (Program.myReader.IsClosed == false)
                {
                    Program.myReader.Close();
                }
                Program.myReader = Program.ExecSqlDataReader(ktsocau);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                if (Program.myReader.GetInt32(0) < edtSoCau.Value)
                {
                    MessageBox.Show("Không đủ câu hỏi trong bộ đề");
                    edtSoCau.Focus();
                    return;
                }
                else
                {
                    Program.myReader.Close();
                    String sql = "EXEC SP_KT_GVDK N'" + edtMaMon.Text.Trim()
                        + "', N'" + edtMaLop.Text.Trim()
                        + "',  " + edtLan.Text;

                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        edtLan.Focus();
                        return;
                    }
                    else
                    {
                        ghiGVDK();
                        checkThem = false;
                    }
                }
            }
            else if (checkSua == true)
            {

                if (edtNgayThi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập ngày thi", "", MessageBoxButtons.OK);
                    edtNgayThi.Focus();
                    return;
                }
                //câu thi
                if (edtSoCau.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập số câu thi", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }

                // ngày không hợp lệ
                var FromDate = edtNgayThi.DateTime;
                var ToDate = DateTime.Today;
                Console.WriteLine("ngay thi: " + FromDate);
                Console.WriteLine("ngay hien tai: " + ToDate);
                int compare = DateTime.Compare(ToDate, FromDate);
                if (compare > 0)
                {
                    MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                    return;
                }

                //số câu thi không hợp lệ
                int socau = Decimal.ToInt16(edtSoCau.Value);
                if (socau < 10 || socau > 100)
                {
                    MessageBox.Show("Số câu thi phải >=10 và <=100 câu, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }
                String mamh = cbbTenMon.SelectedValue.ToString();
                String ktsocau = "select count (cauhoi) from BODE where MAMH = '" + mamh + "'";
                if (Program.myReader.IsClosed == false)
                {
                    Program.myReader.Close();
                }
                Program.myReader = Program.ExecSqlDataReader(ktsocau);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                if (Program.myReader.GetInt32(0) < edtSoCau.Value)
                {
                    MessageBox.Show("Không đủ câu hỏi trong bộ đề, chỉ còn "
                        + Program.myReader.GetInt32(0) + " câu của môn học này");
                    edtSoCau.Focus();
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    ghiGVDK();
                    checkSua = false;
                }
            }

            else
            {
                ghiGVDK();
            }
        }

        private void btnPhuchoiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGVDangKy.CancelEdit();

            this.tbGiangVienDK.Connection.ConnectionString = Program.connstr1;
            this.tbGiangVienDK.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
            this.tbDSLopADT.Connection.ConnectionString = Program.connstr1;
            this.tbDSLopADT.Fill(this.tN_CSDLPTDataSet1.LOP);

            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbDSMH.Connection.ConnectionString = Program.connstr1;
            this.tbDSMH.Fill(this.tN_CSDLPTDataSet1.MONHOC);
            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled =   false;

            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled =   true;
            gcDetail.Enabled = false;
            checkSave = true;
            checkThem = checkSua = false;
            gcGVDK.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới giảng viên đăng ký, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else if (checkSua == true)
            {
                if (MessageBox.Show("Bạn đang sửa giảng viên đăng ký, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else
            {
                checkSave = true;
                this.Close();
            }
        }

        private void gcGVDK_Click(object sender, EventArgs e)
        {

        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null && dem != 0)
                {

                    Program.servername1 = cbbCoSo.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.tbGiangVienDK.Connection.ConnectionString = Program.connstr1;
                        this.tbGiangVienDK.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);

                        // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
                        this.tbDSLopADT.Connection.ConnectionString = Program.connstr1;
                        this.tbDSLopADT.Fill(this.tN_CSDLPTDataSet1.LOP);

                        // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
                        this.tbDSMH.Connection.ConnectionString = Program.connstr1;
                        this.tbDSMH.Fill(this.tN_CSDLPTDataSet1.MONHOC);

                    }
                }
            }
            catch (Exception) { };
        }

        private void FrmGVDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_TenGV' table. You can move, or remove it, as needed.
            this.v_TenGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TenGVTableAdapter.Fill(this.tN_CSDLPTDataSet.V_TenGV);

            this.tbDSLopADT.Connection.ConnectionString = Program.connstr;
            this.tbDSLopADT.Fill(this.tN_CSDLPTDataSet1.LOP);
            this.tbDSMH.Connection.ConnectionString = Program.connstr;
            this.tbDSMH.Fill(this.tN_CSDLPTDataSet1.MONHOC);
            this.tbDSGiangVien.Connection.ConnectionString = Program.connstr;
            this.tbDSGiangVien.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN);
            this.tbGiangVienDK.Connection.ConnectionString = Program.connstr;
            this.tbGiangVienDK.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);
 

            gcDetail.Enabled = false;
            btnGhiGVDK.Enabled = false;
         


            try
            {
                // Lấy kết danh sách phân mảnh đổ vào combobox
                cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                cbbCoSo.DisplayMember = "TENCOSO";
                cbbCoSo.ValueMember = "TENSERVER";
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu cơ sở" + ex.Message, "", MessageBoxButtons.OK);
            }
             if (this.bdsGVDangKy.Count >= 0)
                {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("Đại học, chuyên ngành", "A");
            items.Add("Đại học, không chuyên ngành", "B");
            items.Add("Cao đẳng", "C");
            cbbTrinhDo.DataSource = new BindingSource(items, null);
            cbbTrinhDo.DisplayMember = "KEY";
            cbbTrinhDo.ValueMember = "VALUE";
            cbbTrinhDo.SelectedValue = ((DataRowView)this.bdsGVDangKy.Current).Row["TRINHDO"].ToString();
            
                 }

            if (Program.mGroup == "COSO")
            {
                cbbCoSo.Enabled = false;
                   btnThemGVDK.Visibility = btnGhiGVDK.Visibility = btnSuaGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = true;
                btnThemGVDK.Visibility = btnSuaGVDK.Visibility = btnGhiGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            dem++;
        }

      

      
    }
}
