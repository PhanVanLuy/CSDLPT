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
    public partial class FrmBoDe : DevExpress.XtraEditors.XtraForm
    {
        public FrmBoDe()
        {
            InitializeComponent();
        }

        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;
        private int dem = 0;

        private void edtMaGV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BAITHI' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.tN_CSDLPTDataSet.BAITHI);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_TenGV' table. You can move, or remove it, as needed.
            this.v_TenGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TenGVTableAdapter.Fill(this.tN_CSDLPTDataSet.V_TenGV);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.tN_CSDLPTDataSet.BODE);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
          
          
/*
            if (Program.mGroup.Equals("GIANGVIEN"))
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);
                if (mONHOCBindingSource.Count <= 0)
                {
                    MessageBox.Show("Giảng viên chưa có môn học đăng ký ", "Thông báo", MessageBoxButtons.OK);
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    bODEBindingSource = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                        = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.tN_CSDLPTDataSet.BODE);
                }

            }
            else
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);
                if (mONHOCBindingSource.Count <= 0)
                {
                    MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);
                    bODEBindingSource = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                          = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.tN_CSDLPTDataSet.BODE);
                }
            }
            */
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);

            gcDetail.Enabled = false;

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");
            if (bODEBindingSource != null)
                if (bODEBindingSource.Count > 0)
                    cbbTrinhDo.SelectedValue = ((DataRowView)this.bODEBindingSource.Current).Row["TRINHDO"].ToString();

            cbbDapAn.Items.Add("A");
            cbbDapAn.Items.Add("B");
            cbbDapAn.Items.Add("C");
            cbbDapAn.Items.Add("D");
            if (bODEBindingSource != null)
                if (bODEBindingSource.Count > 0)
                    cbbDapAn.SelectedValue = ((DataRowView)this.bODEBindingSource.Current).Row["DAP_AN"].ToString();

            if (Program.mGroup == "COSO")
            {
                btnThemBD.Visibility = btnSuaBD.Visibility = btnGhiBD.Visibility = btnXoaBD.Visibility = btnPhucHoiBD.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                btnThemBD.Visibility = btnSuaBD.Visibility = btnGhiBD.Visibility = btnXoaBD.Visibility = btnPhucHoiBD.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            dem++;

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới câu hỏi thi, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiBD_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa câu hỏi thi, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiBD_ItemClick(sender, e);
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

        private void btnThemBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                edtMaGV.Text = "";
                edtMaMon.Text = "";
                edtMaCauHoi.Text = "";

                bODEBindingSource.AddNew();
               // cbbTenMh.SelectedValue = cbbTenMonHocC.SelectedValue.ToString();
                //edtMaMon.Text = cbbTenMonHocC.SelectedValue.ToString();

                checkThem = true;
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = false;
                gcBoDe.Enabled = false;
                checkSave = false;
                cbbTenMh.Enabled = false;

                gcDetail.Enabled = true;

                cbbTrinhDo.SelectedIndex = 0;
                cbbTenMonHocC.Enabled = false;
                cbbTenMh.Enabled = true;

                edtMaCauHoi.Enabled = true;
                cbbDapAn.SelectedIndex = 0;
                if (Program.mGroup.Equals("GIANGVIEN"))
                {
                    cbbTenGV.Enabled = false;
                    cbbTenGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbTenGV.Enabled = true;
                    cbbTenGV.SelectedIndex = 0;
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đề thi " + ex.Message, "", MessageBoxButtons.OK);
                Console.WriteLine("aaaaaa" + ex.Message, "");
            }
        }

        private void ghiBD()
        {
            try
            {
                bODEBindingSource.EndEdit();
                bODEBindingSource.ResetCurrentItem();
                Console.WriteLine("cocls "+this.bODETableAdapter.Connection.ConnectionString);
                this.bODETableAdapter.Update(this.tN_CSDLPTDataSet.BODE);
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = true;
                gcBoDe.Enabled = true;
                checkSave = true;
                gcDetail.Enabled = false;
                cbbTenMonHocC.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề thi " + ex.Message, "", MessageBoxButtons.OK);
                Console.WriteLine( ex);
            }

        }

        private void btnGhiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (edtMaCauHoi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                    edtMaCauHoi.Focus();
                    return;
                }
                if (edtNoiDung.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nội dung câu hỏi thi không được rỗng", "", MessageBoxButtons.OK);
                    edtNoiDung.Focus();
                    return;
                }
                //a
                if (edtA.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtA.Focus();
                    return;
                }
                //B
                if (edtB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtB.Focus();
                    return;
                }
                //c
                if (edtC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtC.Focus();
                    return;
                }
                //D
                if (edtD.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtD.Focus();
                    return;
                }
                edtMaGV.Text.Trim();
                String sql = "EXEC SP_KT_MA_BO_DE '" + edtMaCauHoi.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaCauHoi.Focus();
                    return;
                }
                else
                {
                    ghiBD();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {
                ghiBD();
                checkSua = false;
            }
            else
            {
                ghiBD();
            }
        }

        private void btnXoaBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (bdsBaiThi.Count > 0)
            {
                MessageBox.Show("Câu này đã tồn tại trong bài thi của sinh viên, không được xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi thi "
                + ((DataRowView)this.bODEBindingSource.Current).Row["CAUHOI"].ToString()
                + "\n" + ((DataRowView)this.bODEBindingSource.Current).Row["NOIDUNG"].ToString()
                + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bODEBindingSource.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.bODETableAdapter.Update(this.tN_CSDLPTDataSet.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi thi " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void cbbTenMonHocC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenMonHocC.SelectedValue != null && dem > 0)
            {
                try
                {
                   
                    lbTenMH.Text = cbbTenMonHocC.SelectedValue.ToString().Trim();

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnSuaBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count == 0)
            {
                MessageBox.Show("Không có Đề để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                if (Program.mGroup.Equals("Giangvien"))
                {
                    cbbTenGV.Enabled = false;
                    cbbTenGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbTenGV.Enabled = true;
                    cbbTenGV.SelectedValue = ((DataRowView)this.bODEBindingSource.Current).Row["MAGV"].ToString();

                }
                checkSua = true;
                edtMaCauHoi.Enabled = false;
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = false;
                gcBoDe.Enabled = false;

                gcDetail.Enabled = true;
                cbbTrinhDo.SelectedValue = ((DataRowView)this.bODEBindingSource.Current).Row["TRINHDO"].ToString();
                cbbTenMh.Enabled = true;
                cbbTenMonHocC.Enabled = false;
                checkSave = false;
            }


        }

         private void cbbTenMh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMh.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaGV.Text = cbbTenGV.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnPhucHoiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bODEBindingSource.CancelEdit();
            this.bAITHITableAdapter.Fill(this.tN_CSDLPTDataSet.BAITHI);
            this.v_TenGVTableAdapter.Fill(this.tN_CSDLPTDataSet.V_TenGV);

            checkThem = checkSua = false;
            btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = true;
            gcBoDe.Enabled = true;
            checkSave = true;
            gcDetail.Enabled = false;
            cbbTenMonHocC.Enabled = true;
            edtMaGV.Text = "";
            edtMaMon.Text = "";
            edtMaCauHoi.Text = "";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBoDe_Load(  sender,   e);
        }
    }
}