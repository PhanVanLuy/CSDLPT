using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class rpBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangDiem(String maLop, String MaMH, short lanThi)
        {
            InitializeComponent();
            if (FrmBangDiem.isCoSoKhac == true)
            {
                Program.servername1 = FrmBangDiem._coso;
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.sqlDataSource1.Connection.ConnectionString = Program.connstr1;
                    this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
                    this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
                    this.sqlDataSource1.Queries[0].Parameters[2].Value = lanThi;
                    this.sqlDataSource1.Fill();
                     
                }
            }
            else
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
                this.sqlDataSource1.Queries[0].Parameters[2].Value = lanThi;
                this.sqlDataSource1.Fill();
            }
        }

    }
}
