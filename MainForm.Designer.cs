namespace CSDLPT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMonhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRpDSDKThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lbGroup = new System.Windows.Forms.Label();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new CSDLPT.TN_CSDLPTDataSet();
            this.monhocTableAdapter1 = new CSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMonhoc,
            this.btnGiangVien,
            this.barButtonItem3,
            this.btnThi,
            this.btnDangKi,
            this.btnRpDSDKThi,
            this.btnBangDiem,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1805, 158);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Caption = "Môn Học";
            this.btnMonhoc.Id = 4;
            this.btnMonhoc.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_logbook_48;
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMonhoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng viên";
            this.btnGiangVien.Id = 5;
            this.btnGiangVien.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_classroom_48;
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tạo tài khoản";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_add_user_male_32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Id = 7;
            this.btnThi.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_test_48;
            this.btnThi.Name = "btnThi";
            this.btnThi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Caption = "Đăng ký";
            this.btnDangKi.Id = 8;
            this.btnDangKi.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_add_tab_48;
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangKi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKi_ItemClick);
            // 
            // btnRpDSDKThi
            // 
            this.btnRpDSDKThi.Caption = "Danh sách đăng ký thi";
            this.btnRpDSDKThi.Id = 9;
            this.btnRpDSDKThi.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_481;
            this.btnRpDSDKThi.Name = "btnRpDSDKThi";
            this.btnRpDSDKThi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRpDSDKThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRpDSDKThi_ItemClick);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Caption = "Bảng điểm";
            this.btnBangDiem.Id = 10;
            this.btnBangDiem.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_48;
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Bộ đề";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_48;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_logbook_48;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMonhoc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiangVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_test_48;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDangKi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo cáo";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_48;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRpDSDKThi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnBangDiem);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cá nhân";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_add_key_48;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbGroup.Location = new System.Drawing.Point(0, 897);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(40, 13);
            this.lbGroup.TabIndex = 1;
            this.lbGroup.Text = "Group:";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.tN_CSDLPTDataSet;
            this.bdsMonHoc.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocTableAdapter1
            // 
            this.monhocTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "TN_CSDLPTConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select MAMH, TENMH from dbo.MonHoc";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iTUFNSCIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJURU5NSCIgVHlwZT0iU3RyaW5nIiAvP" +
    "jwvVmlldz48L0RhdGFTZXQ+";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_48;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRpDSDKThi);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Danh sách đăng ký thi";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_graph_report_script_48;
            this.ribbonPageGroup8.ItemLinks.Add(this.btnRpDSDKThi);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Danh sách đăng ký thi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 910);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Label lbGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnMonhoc;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraBars.BarButtonItem btnGiangVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem btnDangKi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnRpDSDKThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnBangDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}

