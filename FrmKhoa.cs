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
        private string selected = "";
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

            if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = true;
            }
            else if (Program.mGroup == "COSO")
            {
                cbbCoSo.Enabled = false;
            }


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
            this.pnKhoaControl.Enabled = true;
            if (this.selected == "KHOA")
            {
                
                try
                {
                    kHOABindingSource.AddNew();
                    teMaKH.Text = "";
                    teTen.Text = "";
                    flagOption = "ADD";

                    teMaKH.Focus();
                    activeAllButton(false);
                    btnLuu.Enabled = btHuy.Enabled = true;
                }
                catch (Exception ex) {
                    Debug.WriteLine("Lỗi thêm khoa: " + ex);
                }
            }
            else
            {
                try
                {
                    lOPBindingSource.AddNew();
                    teMaLop.Text = "";
                    teTenLop.Text = "";
                    flagOption = "ADD";

                    teMaLop.Focus();
                    activeAllButton(false);
                    btnLuu.Enabled = btHuy.Enabled = true;
                }
                catch (Exception ex) {
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
            if(this.selected == "KHOA")
            {
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
            if(this.selected == "KHOA")
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
            this.pnKhoaControl.Enabled = false;
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
            Debug.WriteLine("KHOA is selected!!");
        }

        private void gcLop_Enter(object sender, EventArgs e)
        {
            this.selected = "LOP";
            Debug.WriteLine("LOP is selected!!");
        }
    }
}
