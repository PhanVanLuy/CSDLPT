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
    public partial class FrmTraCuu : Form
    {
        private string selected = "";
        private string flagOption = "";
        private string conStr = "";
        public FrmTraCuu()
        {
            InitializeComponent();
        }

        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.MoveLast();
            conStr = "Data Source=" + ((DataRowView)Program.bds_dspm[Program.bds_dspm.Position])[1].ToString() + ";Initial Catalog=" +
                   Program.database + ";User ID=" +
                   Program.remotelogin + ";password=" + Program.remotepassword;


            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = conStr;
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet1.LOP);
            
            
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = conStr;
            this.sINHVIENTableAdapter.FillByMaLop(this.tN_CSDLPTDataSet1.SINHVIEN,teMaLop.Text);

        }
        

        private void teMaKH_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void teMaLop_EditValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.KHOA' table. You can move, or remove it, as needed.
            //this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet1.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet1.LOP' table. You can move, or remove it, as needed.
            if (!String.IsNullOrEmpty(teMaLop.Text))
            {
                lbLop.Text = "Lớp: " + teMaLop.Text;
                this.sINHVIENTableAdapter.Connection.ConnectionString = conStr;
                try
                {
                    this.sINHVIENTableAdapter.FillByMaLop(this.tN_CSDLPTDataSet1.SINHVIEN, teMaLop.Text);
                }
                catch(Exception ex)
                {

                }

                try
                {
                    lOPBindingSource.Position = lOPBindingSource.Find("MALOP", teMaLop.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã lớp không tìm thấy, \nVui lòng kiểm tra lại!!","THÔNG BÁO", MessageBoxButtons.OK);
                    btPhucHoi.PerformClick();
                }
            }
            else
            { 
                //this.lOPTableAdapter.FillByMaKH(this.tN_CSDLPTDataSet1.LOP, "MAKH");
            }
        }
        

       
        private void btThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            this.Close();
        }
        

        private void btPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = conStr;
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet1.LOP);

            
            this.sINHVIENTableAdapter.Connection.ConnectionString = conStr;
            this.sINHVIENTableAdapter.FillByMaLop(this.tN_CSDLPTDataSet1.SINHVIEN, teMaLop.Text);

        }
        
    }
}
