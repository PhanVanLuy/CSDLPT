namespace CSDLPT
{
    partial class FrmBoDe
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
            this.SuspendLayout();
            // 
            // FrmBoDe
            // 
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Name = "FrmBoDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemBD;
        private DevExpress.XtraBars.BarButtonItem btnXoaBD;
        private DevExpress.XtraBars.BarButtonItem btnSuaBD;
        private DevExpress.XtraBars.BarButtonItem btnGhiBD;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiBD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcBoDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbTenMH;
        private System.Windows.Forms.ComboBox cbbTenMonHocC;
        private DevExpress.XtraEditors.PanelControl gcDetail;
        private DevExpress.XtraEditors.TextEdit edtMaGV;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.ComboBox cbbDapAn;
        private System.Windows.Forms.ComboBox cbbTenMh;
        private System.Windows.Forms.ComboBox cbbTenGV;
        private DevExpress.XtraEditors.SpinEdit edtMaCauHoi;
        private DevExpress.XtraEditors.TextEdit edtMaMon;
        private System.Windows.Forms.RichTextBox edtD;
        private System.Windows.Forms.RichTextBox edtC;
        private System.Windows.Forms.RichTextBox edtB;
        private System.Windows.Forms.RichTextBox edtA;
        private System.Windows.Forms.RichTextBox edtNoiDung;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BODETableAdapter bODETableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.BindingSource vTenGVBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_TenGVTableAdapter v_TenGVTableAdapter;
        private System.Windows.Forms.BindingSource bdsBaiThi;
        private TN_CSDLPTDataSetTableAdapters.BAITHITableAdapter bAITHITableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}