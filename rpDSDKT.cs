using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class rpDSDKT : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDSDKT(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();


            if (FrmDSDK.status == true)
            {
                Program.servername1 = FrmDSDK._coso;
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {

                    this.sqlDataSource1.Connection.ConnectionString = Program.connstr1;
                    this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
                    this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;

                    this.sqlDataSource1.Fill();
                }
            }
            else
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;
                this.sqlDataSource1.Fill();
            }

        }

    }
}
