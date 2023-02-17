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

    public partial class FrmSinhVien : DevExpress.XtraEditors.XtraForm
    {

        
        private Boolean checkThemSV = false;
        private Boolean checkXoaSV = false;
        
        private Boolean checkSuaSV = false;
        public static Boolean checkSave = true;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.tN_CSDLPTDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);

            tN_CSDLPTDataSet.EnforceConstraints = false;
            gcSinhVien.UseDisabledStatePainter = false;
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaLopSV.Text = cbbTenLop.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;

                gcSinhVien.Enabled = false;
                pcSV.Enabled = true;
                edtMaSV.Enabled = false;
                edtHo.Enabled = edtTen.Enabled = edtNgaySInh.Enabled = edtDiaChi.Enabled = true;
                cbbTenLop.Enabled = false;
                checkSuaSV = true;
                checkSave = false;
              
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsSV.AddNew();
                pcSV.Enabled = true;
                gcSinhVien.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnGhi.Enabled = true;
                edtMaSV.Enabled = edtHo.Enabled = edtTen.Enabled = edtNgaySInh.Enabled = edtDiaChi.Enabled = true;
                cbbTenLop.Enabled = false;
                checkThemSV = true;
                cbbTenLop.SelectedValue = edtMaLopSV.Text;
                edtMaLopSV.Text = ((DataRowView)this.bdsLop.Current).Row["MALOP"].ToString();
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                if (bdsBangDiem.Count > 0)
                {
                    MessageBox.Show("Sinh viên này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên : " + ((DataRowView)this.bdsSV.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bdsSV.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.sINHVIENTableAdapter.Update(this.tN_CSDLPTDataSet.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            checkThemSV = checkSuaSV = checkXoaSV = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;
        }

        private void ghiSinhVien()
        {
            try
            {
                bdsSV.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsSV.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.sINHVIENTableAdapter.Update(this.tN_CSDLPTDataSet.SINHVIEN);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
               
                // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
                // gán chuỗi kết nối được lấy từ form đăng nhập trước khi fiew dữ liêu về
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.tN_CSDLPTDataSet.SINHVIEN);
                
               pcSV.Enabled = false;

                gcSinhVien.Enabled = true;
                checkThemSV = checkSuaSV = checkXoaSV = false;

                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = true;
                checkSave = true;
                
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThemSV == true)
            {
                if (edtMaSV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtHo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtTen.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtNgaySInh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtDiaChi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Địa chỉ của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                String sql = "EXEC SP_KTSV_TONTAI '" + edtMaSV.Text.Trim().ToString() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaSV.Focus();
                    return;
                }
                else
                {
                    ghiSinhVien();
                }

            }
            else if (checkSuaSV == true)
            {
                if (edtHo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtTen.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtNgaySInh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtDiaChi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Địa chỉ của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                checkSuaSV = false;
                ghiSinhVien();
            }
        }
    }
}