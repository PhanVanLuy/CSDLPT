using System;
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
    public partial class FrmKhoa : Form
    {
        private string selected = "KHOA";
        private string flagOption = "";
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {


            this.kHOATableAdapter.Connection.ConnectionString
                = this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;


            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, teMaKH.Text);

            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            //cbbCoSo.DataBindings.RemoveAt(); // need to remove site 3 from datasource

            cbbCoSo.DisplayMember = "TENCOSO";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoSo;

            checkAthorize();

            lbKhoa.Visible = cbKhoa.Visible = false;


        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCoSo.DisplayMember = "TENCOSO";
            cbbCoSo.ValueMember = "TENSERVER";
            try
            {
                if (cbbCoSo.SelectedValue.ToString() != null)
                {
                    Program.servername1 = cbbCoSo.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr1;
                        kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);

                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr1;
                        lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, teMaKH.Text);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }



        private void teMaKH_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void teMaKH_EditValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.KHOA' table. You can move, or remove it, as needed.
            //this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.LOP' table. You can move, or remove it, as needed.
            if (!String.IsNullOrEmpty(teMaKH.Text))
            {
                this.lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, teMaKH.Text);
            }
            else
            {
                //this.lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, "MAKH");
            }
        }


        private void btThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbKhoa.Visible = cbKhoa.Visible = true;

            if (this.selected == "KHOA")
            {
                this.pnKhoaControl.Enabled = true;
                try
                {
                    flagOption = "ADD";

                    teMaKH.Focus();
                    kHOABindingSource.AddNew();
                    teMaKH.Text = "";
                    teTen.Text = "";
                    activeAllButton(false);
                    btnLuu.Enabled = btHuy.Enabled = true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi thêm khoa: " + ex);
                }
            }
            else
            {
                this.pnLopControl.Enabled = true;
                try
                {
                    flagOption = "ADD";

                    teMaLop.Focus();
                    lOPBindingSource.AddNew();
                    teMaLop.Text = "";
                    teTenLop.Text = "";
                    activeAllButton(false);
                    btnLuu.Enabled = btHuy.Enabled = true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi thêm lớp: " + ex);
                }
            }
        }
        public void activeAllButton(Boolean isActive)
        {
            btXoa.Enabled = btThoat.Enabled = btThem.Enabled = btSua.Enabled = btPhucHoi.Enabled = btnLuu.Enabled = btHuy.Enabled = isActive;
        }

        private void btXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.selected == "KHOA")
            {

                teMaKH.Text = "";
                teTen.Text = "";
                string maKH = "";

                if (kHOABindingSource.Count == 0)
                {
                    MessageBox.Show("Không có khoa để xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                maKH = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["MAKH"].ToString();
                string tenKH = ((DataRowView)kHOABindingSource[kHOABindingSource.Position])["TENKH"].ToString();
                Debug.WriteLine("MAKH: " + maKH);
                if (MessageBox.Show("Bạn có thật sự muốn xóa khoa " + tenKH + " ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        kHOABindingSource.RemoveCurrent();
                        kHOABindingSource.EndEdit();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.tN_CSDLPTDataSet1.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa: " + ex.Message, "", MessageBoxButtons.OK);
                        kHOABindingSource.Position = kHOABindingSource.Find("MAKH", maKH);
                        this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);

                    }
                }
                activeAllButton(true);
                if (kHOABindingSource.Count == 0) btXoa.Enabled = false;
            }
            else
            {
                // selected = LOP
                string maLop = "";
                teMaLop.Text = "";
                teMaLop.Text = "";

                if (lOPBindingSource.Count == 0)
                {
                    MessageBox.Show("Không có lớp để xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                maLop = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MALOP"].ToString();
                string tenLop = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["TENLOP"].ToString();
                Debug.WriteLine("MALOP: " + maLop);
                if (MessageBox.Show("Bạn có thật sự muốn xóa lớp " + tenLop + " ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        lOPBindingSource.RemoveCurrent();
                        lOPBindingSource.EndEdit();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.tN_CSDLPTDataSet1.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa: " + ex.Message, "", MessageBoxButtons.OK);
                        lOPBindingSource.Position = kHOABindingSource.Find("MAKH", maLop);
                        this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet1.LOP);

                    }
                }
                activeAllButton(true);

                if (lOPBindingSource.Count == 0) btXoa.Enabled = false;
            }
        }

        private void btThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void btSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.selected == "KHOA")
            {
                this.pnKhoaControl.Enabled = true;
                teMaKH.Enabled = false; //ko cho sua ma khoa
                flagOption = "UPDATE";

                activeAllButton(false);
                btnLuu.Enabled = btHuy.Enabled = true;
            }
            else
            {
                this.pnLopControl.Enabled = true;
                teMaLop.Enabled = false; //ko cho sua ma lop
                flagOption = "UPDATE";

                activeAllButton(false);
                btnLuu.Enabled = btHuy.Enabled = true;
            }
        }

        private void btHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagOption == "UPDATE")
            {
                teMaLop.Enabled = true;
                teMaKH.Enabled = true;
            }
            kHOABindingSource.CancelEdit();
            lOPBindingSource.CancelEdit();
            //this.pnKhoaControl.Enabled = false;
            this.pnLopControl.Enabled = false;
            gcKhoa.Enabled = true;
            gcLop.Enabled = true;
            activeAllButton(true);
            btHuy.Enabled = false;
            flagOption = "";
        }


        private void gcKhoa_Enter(object sender, EventArgs e)
        {

            this.selected = "KHOA";
            checkAthorize();
            Debug.WriteLine("KHOA is selected!!");
        }

        private void gcLop_Enter(object sender, EventArgs e)
        {
            
            btThem.Enabled = true;
            this.selected = "LOP";
            Debug.WriteLine("LOP is selected!!");
            checkAthorize();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagOption == "ADD")
            {
                string tempConnStr = Program.connstr_publicsher;
                Program.bds_dspm.MoveLast();
                Program.connstr_publicsher = "Data Source=" + ((DataRowView)Program.bds_dspm[Program.bds_dspm.Position])[1].ToString() + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.remotelogin + ";password=" + Program.remotepassword;

                string cmd = Queries.CHECK_TRUNG_KHOA_LOP;
                int res;
                

                if (this.selected == "LOP")
                {
                    res = Program.CheckDataHelper(string.Format(cmd, 2, teMaLop.Text.Trim()));
                    if (res == 1)
                    {
                        MessageBox.Show("Mã lớp bị trùng, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Program.connstr_publicsher = tempConnStr;
                        teMaLop.Focus();
                        return;
                    }
                    //else if (res == 2)
                    //{
                    //    MessageBox.Show("Mã giáo viên bị trùng tại cơ sở khác, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                    //    teMaLop.Focus();
                    //    return;
                    //}
                    if(teMaLop.Text.Trim() == "" || teTenLop.Text.Trim() == "" || cbKhoa.SelectedIndex < 0)
                    {
                        MessageBox.Show("Thông tin chưa đầy đủ!! \nVui lòng kiểm tra lại thông tin", "THÔNG BÁO", MessageBoxButtons.OK);
                        Program.connstr_publicsher = tempConnStr;
                        return;
                    }
                }
                else
                {
                    res = Program.CheckDataHelper(string.Format(cmd, 1, teMaKH.Text.Trim()));
                    if (res == 1)
                    {
                        MessageBox.Show("Mã khoa bị trùng, vui lòng nhập lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Program.connstr_publicsher = tempConnStr;
                        teMaKH.Focus();
                        return;
                    }
                }
                Program.connstr_publicsher = tempConnStr;

            }


            if (this.selected == "LOP")
            {
                lbKhoa.Visible = cbKhoa.Visible = false;

                if (flagOption == "UPDATE")
                {
                    teMaLop.Enabled = false;
                }
                if (teTenLop.Text.Trim() != null)
                {

                    Debug.WriteLine("Pass all validates!!");
                    try
                    {
                        lOPBindingSource.EndEdit();
                        lOPBindingSource.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        Debug.WriteLine(Program.connstr);
                        this.lOPTableAdapter.Update(this.tN_CSDLPTDataSet1.LOP);
                        Debug.WriteLine("Save LOP successfully!!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi lớp! \n" + ex, "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    activeAllButton(true);
                    //gcLop.Enabled = true;
                    //pnLopControl.Enabled = false;
                    flagOption = "";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên lớp", "Thông báo", MessageBoxButtons.OK);
                    teTenLop.Focus();
                }
                
            }
            if (this.selected == "KHOA")
            {

                if (flagOption == "UPDATE")
                {
                    teMaKH.Enabled = false;
                }
                if (teTen.Text.Trim() != null)
                {

                    try
                    {
                        kHOABindingSource.EndEdit();
                        kHOABindingSource.ResetCurrentItem();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.tN_CSDLPTDataSet1.KHOA);
                        Debug.WriteLine("Save KHOA successfully!!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi  khoa! \n" + ex, "Lỗi", MessageBoxButtons.OK);
                        return;
                    }


                    activeAllButton(true);
                    gcLop.Enabled = true;
                    //pnLopControl.Enabled = false;
                    flagOption = "";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên khoa", "Thông báo", MessageBoxButtons.OK);
                    teTen.Focus();
                }
            }
        }
        private void checkAthorize()
        {

            if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                cbbCoSo.Enabled = true;
                btThem.Enabled = btXoa.Enabled = btSua.Enabled = btnLuu.Enabled = btHuy.Enabled = false;
            }
            if (Program.mGroup == "COSO" || Program.mGroup == "GIANGVIEN")
            {
                cbbCoSo.Enabled = false;
            }

        }

        private void btPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr1;
            kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr1;
            lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, teMaKH.Text);
        }
    }
}
