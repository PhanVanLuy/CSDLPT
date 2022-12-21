namespace CSDLPT
{
    partial class FrmBangDiem
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbbLThi = new System.Windows.Forms.ComboBox();
            this.sPDSLanThiDK = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new CSDLPT.TN_CSDLPTDataSet();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.sPDSMHDK = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.vDSLOP = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sPXemKetQuaSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_DSLOPTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.V_DSLOPTableAdapter();
            this.sP_DSMHDKTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_DSMHDKTableAdapter();
            this.sP_DSLanThiDKTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_DSLanThiDKTableAdapter();
            this.sP_XemKetQuaSVTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.SP_XemKetQuaSVTableAdapter();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSLanThiDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSMHDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPXemKetQuaSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnInBangDiem});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInBangDiem)});
            this.bar2.Text = "Tools";
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Caption = "In bảng điểm";
            this.btnInBangDiem.Id = 1;
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnInBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBangDiem_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(972, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(972, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(972, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In Bảng Điểm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(707, 281);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnPreview);
            this.panelControl2.Controls.Add(this.cbbLThi);
            this.panelControl2.Controls.Add(this.cbbMH);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.cbbCoSo);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.cbbLop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 20);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(328, 425);
            this.panelControl2.TabIndex = 4;
            // 
            // cbbLThi
            // 
            this.cbbLThi.DataSource = this.sPDSLanThiDK;
            this.cbbLThi.DisplayMember = "LAN";
            this.cbbLThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLThi.FormattingEnabled = true;
            this.cbbLThi.Location = new System.Drawing.Point(93, 230);
            this.cbbLThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLThi.Name = "cbbLThi";
            this.cbbLThi.Size = new System.Drawing.Size(133, 21);
            this.cbbLThi.TabIndex = 22;
            this.cbbLThi.ValueMember = "LAN";
            // 
            // sPDSLanThiDK
            // 
            this.sPDSLanThiDK.DataMember = "SP_DSLanThiDK";
            this.sPDSLanThiDK.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMH
            // 
            this.cbbMH.DataSource = this.sPDSMHDK;
            this.cbbMH.DisplayMember = "TENMH";
            this.cbbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(16, 189);
            this.cbbMH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(240, 21);
            this.cbbMH.TabIndex = 21;
            this.cbbMH.ValueMember = "MAMH";
            this.cbbMH.SelectedIndexChanged += new System.EventHandler(this.cbbMH_SelectedIndexChanged);
            // 
            // sPDSMHDK
            // 
            this.sPDSMHDK.DataMember = "SP_DSMHDK";
            this.sPDSMHDK.DataSource = this.tN_CSDLPTDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Môn học";
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(16, 39);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(221, 21);
            this.cbbCoSo.TabIndex = 18;
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.DataSource = this.vDSLOP;
            this.cbbLop.DisplayMember = "TENLOP";
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(16, 109);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(221, 21);
            this.cbbLop.TabIndex = 16;
            this.cbbLop.ValueMember = "MALOP";
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // vDSLOP
            // 
            this.vDSLOP.DataMember = "V_DSLOP";
            this.vDSLOP.DataSource = this.tN_CSDLPTDataSet;
            this.vDSLOP.CurrentChanged += new System.EventHandler(this.vDSLOP_CurrentChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sPXemKetQuaSVBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(328, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(644, 425);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPXemKetQuaSVBindingSource
            // 
            this.sPXemKetQuaSVBindingSource.DataMember = "SP_XemKetQuaSV";
            this.sPXemKetQuaSVBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colDIEM,
            this.colDIEMCHU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // colDIEMCHU
            // 
            this.colDIEMCHU.FieldName = "DIEMCHU";
            this.colDIEMCHU.Name = "colDIEMCHU";
            this.colDIEMCHU.Visible = true;
            this.colDIEMCHU.VisibleIndex = 4;
            // 
            // v_DSLOPTableAdapter
            // 
            this.v_DSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSMHDKTableAdapter
            // 
            this.sP_DSMHDKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSLanThiDKTableAdapter
            // 
            this.sP_DSLanThiDKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_XemKetQuaSVTableAdapter
            // 
            this.sP_XemKetQuaSVTableAdapter.ClearBeforeFill = true;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(19, 279);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 30);
            this.btnPreview.TabIndex = 28;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // FrmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 465);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBangDiem";
            this.Text = "FrmBangDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSLanThiDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSMHDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPXemKetQuaSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cbbLThi;
        private System.Windows.Forms.ComboBox cbbMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLop;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource vDSLOP;
        private TN_CSDLPTDataSetTableAdapters.V_DSLOPTableAdapter v_DSLOPTableAdapter;
        private System.Windows.Forms.BindingSource sPDSLanThiDK;
        private System.Windows.Forms.BindingSource sPDSMHDK;
        private TN_CSDLPTDataSetTableAdapters.SP_DSMHDKTableAdapter sP_DSMHDKTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.SP_DSLanThiDKTableAdapter sP_DSLanThiDKTableAdapter;
        private System.Windows.Forms.BindingSource sPXemKetQuaSVBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCHU;
        private TN_CSDLPTDataSetTableAdapters.SP_XemKetQuaSVTableAdapter sP_XemKetQuaSVTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnInBangDiem;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.Button btnPreview;
    }
}