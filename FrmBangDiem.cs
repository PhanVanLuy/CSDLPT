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
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class FrmBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangDiem()
        {
            InitializeComponent();
        }

        public static Boolean isCoSoKhac = false;
        public static String _coso = "";
        private String maLop = "", maMH = "";
        private int dem = 0;
        private int lan = 1;

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {

                    Console.WriteLine(cbbLop.SelectedValue.ToString());
                    this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DSMHDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                    cbbMH.SelectedIndex = 0;


                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    cbbLThi.SelectedIndex = 0;

                    this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                }
            }
            catch (Exception) { };
        }

        private void FrmBangDiem_Load(object sender, EventArgs e)
        {

            this.v_DSLOPTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DSLOP);

            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
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
            dem++;


            if (vDSLOP.Count > 0)
            {
                cbbLop.SelectedIndex = 0;
                this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSMHDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                if (sPDSMHDK.Count > 0)
                {
                    cbbMH.SelectedIndex = 0;

                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    if (sPDSLanThiDK.Count > 0)
                    {
                        cbbLThi.SelectedIndex = 0;
                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));

                    }
                }
            }
            else
            {
                this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSMHDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, null);
                this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, null, null, null);

            }


        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {

                    Console.WriteLine(cbbLop.SelectedValue.ToString());

                    if (cbbMH.SelectedValue != null)
                    {

                        Console.WriteLine(cbbMH.SelectedValue.ToString());
                        this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_DSLanThiDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                        cbbLThi.SelectedIndex = 0;

                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                    }
                }
            }
            catch (Exception) { };
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vDSLOP.Count <= 0 || sPDSMHDK.Count <= 0 || sPDSLanThiDK.Count <= 0)
            {
                MessageBox.Show("Không có thông tin bảng điểm ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            rpBangDiem rpBD = new rpBangDiem(cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpBD.lbLop.Text = cbbLop.Text;
            rpBD.lbMH.Text = cbbMH.Text;
            rpBD.lbLanThi.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();
        }

        private void btnInBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vDSLOP.Count <= 0 || sPDSMHDK.Count <= 0 || sPDSLanThiDK.Count <= 0)
            {
                MessageBox.Show("Không có thông tin bảng điểm ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            rpBangDiem rpBD = new rpBangDiem(cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpBD.lbLop.Text = cbbLop.Text;
            rpBD.lbMH.Text = cbbMH.Text;
            rpBD.lbLanThi.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue != null && dem != 0)
            {
                Program.severname = cbbCoSo.SelectedValue.ToString();
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.v_DSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.v_DSLOPTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DSLOP);
                    if (vDSLOP.Count > 0)
                    {
                        cbbLop.SelectedIndex = 0;
                        this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_DSMHDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                        if (sPDSMHDK.Count > 0)
                        {
                            cbbMH.SelectedIndex = 0;

                            this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.sP_DSLanThiDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                            if (sPDSLanThiDK.Count > 0)
                            {
                                cbbLThi.SelectedIndex = 0;
                                this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                                this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
                            }
                        }
                    }
                    else
                    {
                        this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_DSMHDKTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_DSMHDK, null);
                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_XemKetQuaSV, null, null, null);

                    }
                }
            }
            if (Program.mCoSo != cbbCoSo.SelectedIndex) isCoSoKhac = true;
        }
    }

}