namespace CSDLPT
{
    partial class FrmGiangVien
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btThem = new DevExpress.XtraBars.BarButtonItem();
            this.btXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btSua = new DevExpress.XtraBars.BarButtonItem();
            this.btHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lbRecord = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tN_CSDLPTDataSet1 = new CSDLPT.TN_CSDLPTDataSet();
            this.giaovienTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.COSOTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnGiangVienControl = new System.Windows.Forms.Panel();
            this.teDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.teMaGV = new DevExpress.XtraEditors.TextEdit();
            this.teTen = new DevExpress.XtraEditors.TextEdit();
            this.teHo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_SubscribesTableAdapter = new CSDLPT.TN_CSDLPTDataSetTableAdapters.Get_SubscribesTableAdapter();
            this.gcGiangVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnGiangVienControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btThem,
            this.btXoa,
            this.btSua,
            this.btPhucHoi,
            this.lbRecord,
            this.btThoat,
            this.btnLuu,
            this.btHuy});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btThem
            // 
            this.btThem.Caption = "Thêm";
            this.btThem.Hint = "Thêm giảng viên";
            this.btThem.Id = 0;
            this.btThem.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_plus_16;
            this.btThem.Name = "btThem";
            this.btThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btXoa
            // 
            this.btXoa.Caption = "Xóa";
            this.btXoa.Hint = "Xóa giảng viên";
            this.btXoa.Id = 1;
            this.btXoa.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_delete_16;
            this.btXoa.Name = "btXoa";
            this.btXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btSua
            // 
            this.btSua.Caption = "Sửa";
            this.btSua.Hint = "Sửa thông tin giảng viên";
            this.btSua.Id = 2;
            this.btSua.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_edit_16;
            this.btSua.Name = "btSua";
            this.btSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btHuy
            // 
            this.btHuy.Caption = "Hủy";
            this.btHuy.Id = 8;
            this.btHuy.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_cancel_16;
            this.btHuy.Name = "btHuy";
            this.btHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.btHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_3);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 6;
            this.btnLuu.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_save_16;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btPhucHoi
            // 
            this.btPhucHoi.Caption = "Phục hồi";
            this.btPhucHoi.Hint = "Làm mới";
            this.btPhucHoi.Id = 3;
            this.btPhucHoi.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_synchronize_16;
            this.btPhucHoi.Name = "btPhucHoi";
            this.btPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btThoat
            // 
            this.btThoat.Caption = "Thoát";
            this.btThoat.Id = 5;
            this.btThoat.ImageOptions.Image = global::CSDLPT.Properties.Resources.icons8_close_window_16;
            this.btThoat.Name = "btThoat";
            this.btThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lbRecord)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // lbRecord
            // 
            this.lbRecord.Caption = "Record:";
            this.lbRecord.Id = 4;
            this.lbRecord.Name = "lbRecord";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1001, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 743);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1001, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 719);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1001, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 719);
            // 
            // tN_CSDLPTDataSet1
            // 
            this.tN_CSDLPTDataSet1.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaovienTableAdapter
            // 
            this.giaovienTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.tN_CSDLPTDataSet1;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSDLPT.Properties.Resources.b63eccf757d218f5e69b249722b2b73d;
            this.pictureBox1.Location = new System.Drawing.Point(530, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pnGiangVienControl
            // 
            this.pnGiangVienControl.AutoScroll = true;
            this.pnGiangVienControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnGiangVienControl.Controls.Add(this.teDiaChi);
            this.pnGiangVienControl.Controls.Add(this.teMaGV);
            this.pnGiangVienControl.Controls.Add(this.teTen);
            this.pnGiangVienControl.Controls.Add(this.teHo);
            this.pnGiangVienControl.Controls.Add(this.label6);
            this.pnGiangVienControl.Controls.Add(this.cbCoSo);
            this.pnGiangVienControl.Controls.Add(this.label5);
            this.pnGiangVienControl.Controls.Add(this.cbKhoa);
            this.pnGiangVienControl.Controls.Add(this.label2);
            this.pnGiangVienControl.Controls.Add(this.label4);
            this.pnGiangVienControl.Controls.Add(this.lbCoSo);
            this.pnGiangVienControl.Controls.Add(this.label3);
            this.pnGiangVienControl.Controls.Add(this.label1);
            this.pnGiangVienControl.Location = new System.Drawing.Point(71, 378);
            this.pnGiangVienControl.Name = "pnGiangVienControl";
            this.pnGiangVienControl.Size = new System.Drawing.Size(420, 303);
            this.pnGiangVienControl.TabIndex = 32;
            // 
            // teDiaChi
            // 
            this.teDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVien, "DIACHI", true));
            this.teDiaChi.Location = new System.Drawing.Point(88, 150);
            this.teDiaChi.MenuManager = this.barManager1;
            this.teDiaChi.Name = "teDiaChi";
            this.teDiaChi.Size = new System.Drawing.Size(278, 20);
            this.teDiaChi.TabIndex = 4;
            this.teDiaChi.TextChanged += new System.EventHandler(this.teDiaChi_TextChanged);
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "GIAOVIEN";
            this.bdsGiangVien.DataSource = this.tN_CSDLPTDataSet1;
            // 
            // teMaGV
            // 
            this.teMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVien, "MAGV", true));
            this.teMaGV.Location = new System.Drawing.Point(88, 73);
            this.teMaGV.MenuManager = this.barManager1;
            this.teMaGV.Name = "teMaGV";
            this.teMaGV.Size = new System.Drawing.Size(136, 20);
            this.teMaGV.TabIndex = 1;
            this.teMaGV.EditValueChanged += new System.EventHandler(this.teTen_EditValueChanged);
            this.teMaGV.TextChanged += new System.EventHandler(this.teTen_TextChanged);
            this.teMaGV.Validated += new System.EventHandler(this.teTen_Validated);
            // 
            // teTen
            // 
            this.teTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVien, "TEN", true));
            this.teTen.Location = new System.Drawing.Point(265, 111);
            this.teTen.MenuManager = this.barManager1;
            this.teTen.Name = "teTen";
            this.teTen.Size = new System.Drawing.Size(101, 20);
            this.teTen.TabIndex = 3;
            this.teTen.EditValueChanged += new System.EventHandler(this.teTen_EditValueChanged);
            this.teTen.TextChanged += new System.EventHandler(this.teTen_TextChanged);
            this.teTen.Validated += new System.EventHandler(this.teTen_Validated);
            // 
            // teHo
            // 
            this.teHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGiangVien, "HO", true));
            this.teHo.Location = new System.Drawing.Point(85, 111);
            this.teHo.MenuManager = this.barManager1;
            this.teHo.Name = "teHo";
            this.teHo.Size = new System.Drawing.Size(139, 20);
            this.teHo.TabIndex = 2;
            this.teHo.TextChanged += new System.EventHandler(this.teHo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 34);
            this.label6.TabIndex = 29;
            this.label6.Text = "THÔNG TIN GIẢNG VIÊN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCoSo
            // 
            this.cbCoSo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cOSOBindingSource, "TENCS", true));
            this.cbCoSo.DisplayMember = "MACS";
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(85, 234);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(281, 21);
            this.cbCoSo.TabIndex = 7;
            this.cbCoSo.ValueMember = "MACS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã GV:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.bdsGiangVien;
            this.cbKhoa.DisplayMember = "MAKH";
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(85, 195);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(281, 21);
            this.cbKhoa.TabIndex = 6;
            this.cbKhoa.ValueMember = "MAKH";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Khoa:";
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Location = new System.Drawing.Point(42, 237);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(37, 13);
            this.lbCoSo.TabIndex = 23;
            this.lbCoSo.Text = "Cơ sở:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Họ:";
            // 
            // kHOABindingSource1
            // 
            this.kHOABindingSource1.DataMember = "KHOA";
            this.kHOABindingSource1.DataSource = this.tN_CSDLPTDataSet1;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.tN_CSDLPTDataSet1;
            // 
            // get_SubscribesTableAdapter
            // 
            this.get_SubscribesTableAdapter.ClearBeforeFill = true;
            // 
            // gcGiangVien
            // 
            this.gcGiangVien.DataSource = this.bdsGiangVien;
            this.gcGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGiangVien.Location = new System.Drawing.Point(0, 24);
            this.gcGiangVien.MainView = this.gridView1;
            this.gcGiangVien.MenuManager = this.barManager1;
            this.gcGiangVien.Name = "gcGiangVien";
            this.gcGiangVien.Size = new System.Drawing.Size(1001, 258);
            this.gcGiangVien.TabIndex = 42;
            this.gcGiangVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGiangVien.Click += new System.EventHandler(this.gcGiangVien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH});
            this.gridView1.GridControl = this.gcGiangVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.EditFormColumnCount = 5;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "Địa chỉ";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            // 
            // FrmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.gcGiangVien);
            this.Controls.Add(this.pnGiangVienControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiangVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teTen_EditValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnGiangVienControl.ResumeLayout(false);
            this.pnGiangVienControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet1;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter giaovienTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btThem;
        private DevExpress.XtraBars.BarButtonItem btXoa;
        private DevExpress.XtraBars.BarButtonItem btSua;
        private DevExpress.XtraBars.BarButtonItem btPhucHoi;
        private DevExpress.XtraBars.BarStaticItem lbRecord;
        private DevExpress.XtraBars.BarButtonItem btThoat;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private TN_CSDLPTDataSetTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarButtonItem btHuy;
        private System.Windows.Forms.Panel pnGiangVienControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCoSo;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit teDiaChi;
        private DevExpress.XtraEditors.TextEdit teTen;
        private DevExpress.XtraEditors.TextEdit teHo;
        private System.Windows.Forms.BindingSource kHOABindingSource1;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private TN_CSDLPTDataSetTableAdapters.Get_SubscribesTableAdapter get_SubscribesTableAdapter;
        private DevExpress.XtraGrid.GridControl gcGiangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.TextEdit teMaGV;
        private System.Windows.Forms.Label label5;
    }
}