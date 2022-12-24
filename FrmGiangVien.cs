﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class FrmGiangVien : Form
    {
        private string coSo;

        int viTri = 0;
        string flagOption = "";
        string maCS = "";

        string tTen, tHo, tDiaChi, tMAKH; // temp

        public FrmGiangVien()
        {
            InitializeComponent();

            initFormControl();
            // This line of code is generated by Data Source Configuration Wizard
            giaovienTableAdapter.Fill(tN_CSDLPTDataSet1.GIAOVIEN);
        }
        private void initFormControl()
        {
            //   lbRecord.Caption = "Record " + this.tN_CSDLPTDataSet1.getGiaoVien.Count;
            // This line of code is generated by Data Source Configuration Wizard
            giaovienTableAdapter.Connection.ConnectionString = Program.connstr;
            Debug.WriteLine("Connection string: " + Program.connstr);
            giaovienTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN);

            if (!"TRUONG".Equals(Program.mGroup))
            {
                //cbCoSo.SelectedIndex = Program.mCoSo;
                cbCoSo.Enabled = false;
            }
            maCS = Program.mCoSo.ToString(); // get ma co so
            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TENCOSO";
            cbCoSo.ValueMember = "TENSERVER";
            //this.bdsGiangVien.DataSource = this.getGiaoVienBindingSource2;
            cbCoSo.Enabled = false;
            btnLuu.Enabled = false;
            btPhucHoi.Enabled = btHuy.Enabled = false;
            lbCoSo.Visible = false;
            cbCoSo.Visible = false;
          //  cbKhoa.SelectedValue = 0;
            

            this.pnGiangVienControl.Enabled = false;
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string magv = "";
            if (bdsGiangVien.Count == 0)
            {
                MessageBox.Show("Không có giáo viên để xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            magv = ((DataRowView)bdsGiangVien[bdsGiangVien.Position])["MAGV"].ToString();
            Debug.WriteLine("MAGV: " + magv);
            if (MessageBox.Show("Bạn có thật sự muốn xóa giáo viên có mã " + magv + " ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsGiangVien.RemoveCurrent();
                    this.giaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.giaovienTableAdapter.Update(this.tN_CSDLPTDataSet1.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi xóa giảng viên: " + ex);
                    this.giaovienTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN);
                    MessageBox.Show("Lỗi xóa giáo viên: " + ex.Message, "", MessageBoxButtons.OK);
                    bdsGiangVien.Position = bdsGiangVien.Find("MAGV", magv);

                }
            }
            if (bdsGiangVien.Count == 0) btXoa.Enabled = false;
            activeAllButton(true);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pnGiangVienControl.Enabled = true;
            teMaGV.Enabled = false; //ko cho sua ma GV
            flagOption = "UPDATE";
            tTen = teTen.Text.Trim();
            tHo = teHo.Text.Trim();
            tDiaChi = teDiaChi.Text.Trim();
            activeAllButton(false);

            btnLuu.Enabled = btHuy.Enabled = true;

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pnGiangVienControl.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // viTri = bdsGiangVien.Position;

                
                bdsGiangVien.AddNew();
                teDiaChi.Text = "";
                teHo.Text = "";
                teMaGV.Text = "";
                teTen.Text = "";
                gcGiangVien.Enabled = false;
                this.pnGiangVienControl.Enabled = true;

                flagOption = "ADD";

                activeAllButton(false);
                btnLuu.Enabled = btHuy.Enabled = true;
                lbCoSo.Visible = true;
                cbCoSo.Visible = true;


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi thêm giảng viên: " + ex);
            }

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.activeAllButton(true);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.Get_Subscribes' table. You can move, or remove it, as needed.
            this.get_SubscribesTableAdapter.Fill(this.tN_CSDLPTDataSet1.Get_Subscribes);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.getGiaoVien' table. You can move, or remove it, as needed.
            this.giaovienTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.tN_CSDLPTDataSet1.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet11.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);

        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.coSo = cbCoSo.SelectedText;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagOption == "ADD")
            {
                string cmd = Queries.CHECK_TRUNG_GV;
                int res = Program.CheckDataHelper(string.Format(cmd, teMaGV.Text.Trim()));
                if (res == 1)
                {
                    MessageBox.Show("Mã giáo viên bị trùng, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                    teMaGV.Focus();
                    return;
                }
                else if (res == 2)
                {
                    MessageBox.Show("Mã giáo viên bị trùng tại cơ sở khác, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                    teMaGV.Focus();
                    return;
                }
               

            }
            if (flagOption == "UPDATE")
            {
                teMaGV.Enabled = true;
            }
            if (validateAdd())
            {
                Debug.WriteLine("Pass all validates!!");
                try
                {
                    bdsGiangVien.EndEdit();
                    bdsGiangVien.ResetCurrentItem();
                    this.giaovienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.giaovienTableAdapter.Update(this.tN_CSDLPTDataSet1.GIAOVIEN);
                    Debug.WriteLine("Save GIANG VIEN successfully!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giảng viên! \n" + ex, "Lỗi", MessageBoxButtons.OK);
                    return;
                }


                activeAllButton(true);
                gcGiangVien.Enabled = true;
                pnGiangVienControl.Enabled = false;
                flagOption = "";
            }
        }

        private Boolean validateAdd()
        {
            if (String.IsNullOrEmpty(teMaGV.Text.Trim()))
            {
                MessageBox.Show("Mã giảng viên không thể bỏ trống!");
                teMaGV.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(teHo.Text.Trim()))
            {
                MessageBox.Show("Họ không thể bỏ trống!");
                teHo.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(teTen.Text.Trim()))
            {
                MessageBox.Show("Tên không thể bỏ trống!");
                teTen.Focus();
                return false;
            }

            if (teMaGV.Text.Length > 8)
            {
                MessageBox.Show("Mã giáo viên không được lớn hơn 8 ký tự!");
                teMaGV.Focus();
                return false;
            }

            Debug.WriteLine("MAGV: " + teMaGV.Text.Trim() + " Ho: " + teHo.Text.Trim() + " Ten: " + teTen.Text.Trim());
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void activeAllButton(Boolean isActive)
        {
            btXoa.Enabled = btThoat.Enabled = btThem.Enabled = btSua.Enabled = btPhucHoi.Enabled = btnLuu.Enabled = btHuy.Enabled = isActive;
        }


        private void teTen_EditValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);

        }

        private void teHo_TextChanged(object sender, EventArgs e)
        {
        }

        private void teTen_Validated(object sender, EventArgs e)
        {

        }

        private void teTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void teDiaChi_TextChanged(object sender, EventArgs e)
        {
        }

        private void gcGiangVien_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(flagOption))
            {
                btXoa.Enabled = true;
            }
        }

        private void gcGiangVien_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagOption == "UPDATE")
            {
                teMaGV.Enabled = true;
            }
            bdsGiangVien.CancelEdit();
            giaovienTableAdapter.Fill(this.tN_CSDLPTDataSet1.GIAOVIEN);
            this.pnGiangVienControl.Enabled = false;
            gcGiangVien.Enabled = true;
            activeAllButton(true);
            btHuy.Enabled = false;
            flagOption = "";

        }
    }
}
