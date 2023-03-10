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
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CSDLPT
{
    public partial class FrmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        string flagOption = "";


        public FrmMonHoc()
        {
            initFormControl();


        }
        private void initFormControl()
        {
            InitializeComponent();
            //   lbRecord.Caption = "Record " + this.tN_CSDLPTDataSet1.getGiaoVien.Count;
            // This line of code is generated by Data Source Configuration Wizard
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet1.MONHOC);

            pnMonHocControl.Enabled = false;

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet1.MONHOC);

        }

        private void btThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            viTri = mONHOCBindingSource.Position;
            gcMonhoc.Enabled = false;
            this.pnMonHocControl.Enabled = true;
            try
            {
                mONHOCBindingSource.AddNew();
                teMaMH.Text = "";
                teTen.Text = "";
                flagOption = "ADD";

                teMaMH.Focus();
                activeAllButton(false);
                btnLuu.Enabled = btHuy.Enabled = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi thêm giảng viên: " + ex);
            }

        }

        private void btXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string mamh = "";
            Boolean monhocDK = gcMonhoc.Views.Any();

            if (mONHOCBindingSource.Count == 0)
            {
                MessageBox.Show("Không có môn học để xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            mamh = ((DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position])["MAMH"].ToString();
            Debug.WriteLine("MAMH: " + mamh);
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học có mã " + mamh + " ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mONHOCBindingSource.RemoveCurrent();
                    mONHOCBindingSource.EndEdit();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.tN_CSDLPTDataSet1.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học: " + ex.Message, "", MessageBoxButtons.OK);
                    mONHOCBindingSource.Position = mONHOCBindingSource.Find("MAMH", mamh);
                    this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet1.MONHOC);

                }
            }
            activeAllButton(true);

            if (mONHOCBindingSource.Count == 0) btXoa.Enabled = false;
        }

        private void btSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pnMonHocControl.Enabled = true;
            teMaMH.Enabled = false; //ko cho sua ma MH
            flagOption = "UPDATE";

            activeAllButton(false);
            btnLuu.Enabled = btHuy.Enabled = true;
        }

        private void btHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flagOption == "UPDATE")
            {
                teMaMH.Enabled = true;
            }
            mONHOCBindingSource.CancelEdit();
            this.pnMonHocControl.Enabled = false;
            gcMonhoc.Enabled = true;
            activeAllButton(true);
            btHuy.Enabled = false;
            flagOption = "";
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flagOption == "ADD")
            {
                string cmd = Queries.CHECK_TRUNG_MH;
                int res = Program.CheckDataHelper(string.Format(cmd, teMaMH.Text.Trim()));
                if (res == 1)
                {
                    MessageBox.Show("Mã môn học bị trùng, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                    teMaMH.Focus();
                    return;
                }

            }
            if (flagOption == "UPDATE")
            {
                teMaMH.Enabled = true;
            }
            if (validateAdd())
            {
                Debug.WriteLine("Pass all validates!!");
                try
                {
                    mONHOCBindingSource.EndEdit();
                    mONHOCBindingSource.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.tN_CSDLPTDataSet1.MONHOC);
                    Debug.WriteLine("Save GIANG VIEN successfully!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giảng viên! \n" + ex, "Lỗi", MessageBoxButtons.OK);
                }


                activeAllButton(true);
                gcMonhoc.Enabled = true;
                pnMonHocControl.Enabled = false;
                flagOption = "";
            }
        }

        private void btPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pnMonHocControl.Enabled = false;
        }

        private void btThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private Boolean validateAdd()
        {
            if (String.IsNullOrEmpty(teMaMH.Text.Trim()))
            {
                MessageBox.Show("Mã môn học không thể bỏ trống!");
                teMaMH.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(teTen.Text.Trim()))
            {
                MessageBox.Show("Tên môn học không thể bỏ trống!");
                teTen.Focus();
                return false;
            }

            if(teMaMH.Text.Length > 5)
            {
                MessageBox.Show("Mã môn học không được lớn hơn 5 ký tự!");
                teMaMH.Focus();
                return false;
            }

            Debug.WriteLine("Thêm môn học MAMH: " + teMaMH.Text.Trim() + ", tên: " + teTen.Text.Trim());
            return true;
        }

        public void activeAllButton(Boolean isActive)
        {
            btXoa.Enabled = btThoat.Enabled = btThem.Enabled = btSua.Enabled = btPhucHoi.Enabled = btnLuu.Enabled = btHuy.Enabled = isActive;
        }
    }
}