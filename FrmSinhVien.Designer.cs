namespace CSDLPT
{
    partial class FrmSinhVien
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
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pcSV = new DevExpress.XtraEditors.PanelControl();
            this.edtMaLopSV = new DevExpress.XtraEditors.TextEdit();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.tN_CSDLPTDataSet = new CSDLPT.TN_CSDLPTDataSet();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.edtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.edtNgaySInh = new DevExpress.XtraEditors.DateEdit();
            this.edtTen = new DevExpress.XtraEditors.TextEdit();
            this.edtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.edtHo = new DevExpress.XtraEditors.TextEdit();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter();
            mALOPLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).BeginInit();
            this.pcSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLopSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(40, 312);
            mALOPLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(38, 13);
            mALOPLabel1.TabIndex = 31;
            mALOPLabel1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 261);
            label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 13);
            label2.TabIndex = 29;
            label2.Text = "Tên lớp";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(37, 211);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(39, 13);
            dIACHILabel.TabIndex = 27;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(37, 160);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(54, 13);
            nGAYSINHLabel.TabIndex = 25;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(38, 112);
            tENLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(25, 13);
            tENLabel.TabIndex = 23;
            tENLabel.Text = "Tên";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(40, 28);
            mASVLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(36, 13);
            mASVLabel.TabIndex = 19;
            mASVLabel.Text = "Mã SV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(40, 70);
            hOLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(20, 13);
            hOLabel.TabIndex = 21;
            hOLabel.Text = "Họ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnHuy,
            this.barButtonItem5,
            this.btnGhi});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Huỷ";
            this.btnHuy.Id = 3;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 5;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
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
            this.barDockControlTop.Size = new System.Drawing.Size(855, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 398);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(855, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 357);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(855, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 357);
            // 
            // pcSV
            // 
            this.pcSV.Controls.Add(mALOPLabel1);
            this.pcSV.Controls.Add(this.edtMaLopSV);
            this.pcSV.Controls.Add(this.cbbTenLop);
            this.pcSV.Controls.Add(label2);
            this.pcSV.Controls.Add(dIACHILabel);
            this.pcSV.Controls.Add(this.edtDiaChi);
            this.pcSV.Controls.Add(nGAYSINHLabel);
            this.pcSV.Controls.Add(this.edtNgaySInh);
            this.pcSV.Controls.Add(tENLabel);
            this.pcSV.Controls.Add(this.edtTen);
            this.pcSV.Controls.Add(mASVLabel);
            this.pcSV.Controls.Add(this.edtMaSV);
            this.pcSV.Controls.Add(hOLabel);
            this.pcSV.Controls.Add(this.edtHo);
            this.pcSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcSV.Location = new System.Drawing.Point(0, 41);
            this.pcSV.Name = "pcSV";
            this.pcSV.Size = new System.Drawing.Size(336, 357);
            this.pcSV.TabIndex = 4;
            // 
            // edtMaLopSV
            // 
            this.edtMaLopSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.edtMaLopSV.Enabled = false;
            this.edtMaLopSV.Location = new System.Drawing.Point(94, 309);
            this.edtMaLopSV.Margin = new System.Windows.Forms.Padding(1);
            this.edtMaLopSV.Name = "edtMaLopSV";
            this.edtMaLopSV.Size = new System.Drawing.Size(94, 20);
            this.edtMaLopSV.TabIndex = 32;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.tN_CSDLPTDataSet;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLop, "MALOP", true));
            this.cbbTenLop.DataSource = this.bdsLop;
            this.cbbTenLop.DisplayMember = "TENLOP";
            this.cbbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(38, 275);
            this.cbbTenLop.Margin = new System.Windows.Forms.Padding(1);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(214, 21);
            this.cbbTenLop.TabIndex = 30;
            this.cbbTenLop.ValueMember = "MALOP";
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.tN_CSDLPTDataSet;
            // 
            // edtDiaChi
            // 
            this.edtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.edtDiaChi.Location = new System.Drawing.Point(37, 225);
            this.edtDiaChi.Margin = new System.Windows.Forms.Padding(1);
            this.edtDiaChi.Name = "edtDiaChi";
            this.edtDiaChi.Size = new System.Drawing.Size(262, 20);
            this.edtDiaChi.TabIndex = 28;
            // 
            // edtNgaySInh
            // 
            this.edtNgaySInh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.edtNgaySInh.EditValue = null;
            this.edtNgaySInh.Location = new System.Drawing.Point(38, 174);
            this.edtNgaySInh.Margin = new System.Windows.Forms.Padding(1);
            this.edtNgaySInh.Name = "edtNgaySInh";
            this.edtNgaySInh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgaySInh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtNgaySInh.Size = new System.Drawing.Size(211, 20);
            this.edtNgaySInh.TabIndex = 26;
            // 
            // edtTen
            // 
            this.edtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.edtTen.Location = new System.Drawing.Point(37, 126);
            this.edtTen.Margin = new System.Windows.Forms.Padding(1);
            this.edtTen.Name = "edtTen";
            this.edtTen.Size = new System.Drawing.Size(94, 20);
            this.edtTen.TabIndex = 24;
            // 
            // edtMaSV
            // 
            this.edtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.edtMaSV.Location = new System.Drawing.Point(37, 42);
            this.edtMaSV.Margin = new System.Windows.Forms.Padding(1);
            this.edtMaSV.Name = "edtMaSV";
            this.edtMaSV.Size = new System.Drawing.Size(94, 20);
            this.edtMaSV.TabIndex = 20;
            // 
            // edtHo
            // 
            this.edtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.edtHo.Location = new System.Drawing.Point(37, 84);
            this.edtHo.Margin = new System.Windows.Forms.Padding(1);
            this.edtHo.Name = "edtHo";
            this.edtHo.Size = new System.Drawing.Size(211, 20);
            this.edtHo.TabIndex = 22;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSV;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVien.Location = new System.Drawing.Point(336, 41);
            this.gcSinhVien.MainView = this.gridView1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(519, 357);
            this.gcSinhVien.TabIndex = 5;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gridView1.GridControl = this.gcSinhVien;
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
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "BANGDIEM";
            this.bdsBangDiem.DataSource = this.tN_CSDLPTDataSet;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 418);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.pcSV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).EndInit();
            this.pcSV.ResumeLayout(false);
            this.pcSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaLopSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNgaySInh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pcSV;
        private DevExpress.XtraEditors.TextEdit edtMaLopSV;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private DevExpress.XtraEditors.TextEdit edtDiaChi;
        private DevExpress.XtraEditors.DateEdit edtNgaySInh;
        private DevExpress.XtraEditors.TextEdit edtTen;
        private DevExpress.XtraEditors.TextEdit edtMaSV;
        private DevExpress.XtraEditors.TextEdit edtHo;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource bdsLop;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
    }
}