namespace THITRACNGHIEM
{
    partial class FormKhoa
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tRACNGHIEM = new THITRACNGHIEM.TRACNGHIEM();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager();
            this.khoaTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.KHOATableAdapter();
            this.lopTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.LOPTableAdapter();
            this.gbCS = new System.Windows.Forms.GroupBox();
            this.cmbCS = new System.Windows.Forms.ComboBox();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lopGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbKHOA = new System.Windows.Forms.GroupBox();
            this.btnHuyKHOA = new System.Windows.Forms.Button();
            this.btnOkKHOA = new System.Windows.Forms.Button();
            this.txtMACS = new System.Windows.Forms.TextBox();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.gbLOP = new System.Windows.Forms.GroupBox();
            this.btnHuyLOP = new System.Windows.Forms.Button();
            this.btnOkLOP = new System.Windows.Forms.Button();
            this.txtMAKH1 = new System.Windows.Forms.TextBox();
            this.txtTENLOP = new System.Windows.Forms.TextBox();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.v_DSPMTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.GIANGVIENTableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).BeginInit();
            this.gbCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbKHOA.SuspendLayout();
            this.gbLOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(20, 32);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(16, 71);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(43, 13);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(20, 116);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(39, 13);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MACS:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(17, 32);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(13, 71);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(23, 116);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(39, 13);
            mAKHLabel1.TabIndex = 4;
            mAKHLabel1.Text = "MAKH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnThoat,
            this.btnLoad});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Add";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Delete";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Edit";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Save";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Refresh";
            this.btnLoad.Id = 5;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Exit";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(780, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 546);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(780, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(780, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
            // 
            // tRACNGHIEM
            // 
            this.tRACNGHIEM.DataSetName = "TRACNGHIEM";
            this.tRACNGHIEM.EnforceConstraints = false;
            this.tRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lopTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // gbCS
            // 
            this.gbCS.Controls.Add(this.cmbCS);
            this.gbCS.Controls.Add(this.label1);
            this.gbCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCS.Location = new System.Drawing.Point(0, 40);
            this.gbCS.Name = "gbCS";
            this.gbCS.Size = new System.Drawing.Size(780, 67);
            this.gbCS.TabIndex = 6;
            this.gbCS.TabStop = false;
            // 
            // cmbCS
            // 
            this.cmbCS.DataSource = this.v_DSPMBindingSource;
            this.cmbCS.DisplayMember = "description";
            this.cmbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCS.FormattingEnabled = true;
            this.cmbCS.Location = new System.Drawing.Point(155, 16);
            this.cmbCS.Name = "cmbCS";
            this.cmbCS.Size = new System.Drawing.Size(300, 27);
            this.cmbCS.TabIndex = 1;
            this.cmbCS.ValueMember = "subscriber_server";
            this.cmbCS.SelectedIndexChanged += new System.EventHandler(this.cmbCS_SelectedIndexChanged_1);
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ Sở";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lopGridControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.khoaGridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbKHOA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbLOP, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 439);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lopGridControl
            // 
            this.lopGridControl.DataSource = this.bdsLOP;
            this.lopGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lopGridControl.Location = new System.Drawing.Point(393, 3);
            this.lopGridControl.MainView = this.gridView2;
            this.lopGridControl.MenuManager = this.barManager1;
            this.lopGridControl.Name = "lopGridControl";
            this.lopGridControl.Size = new System.Drawing.Size(384, 213);
            this.lopGridControl.TabIndex = 1;
            this.lopGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.lopGridControl.Click += new System.EventHandler(this.lOPGridControl_Click);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "FK_LOP_KHOA";
            this.bdsLOP.DataSource = this.bdsKHOA;
            // 
            // bdsKHOA
            // 
            this.bdsKHOA.DataMember = "KHOA";
            this.bdsKHOA.DataSource = this.tRACNGHIEM;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH1});
            this.gridView2.GridControl = this.lopGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.OptionsColumn.AllowEdit = false;
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            // 
            // khoaGridControl
            // 
            this.khoaGridControl.DataSource = this.bdsKHOA;
            this.khoaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoaGridControl.Location = new System.Drawing.Point(3, 3);
            this.khoaGridControl.MainView = this.gridView1;
            this.khoaGridControl.MenuManager = this.barManager1;
            this.khoaGridControl.Name = "khoaGridControl";
            this.khoaGridControl.Size = new System.Drawing.Size(384, 213);
            this.khoaGridControl.TabIndex = 0;
            this.khoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.khoaGridControl.Click += new System.EventHandler(this.kHOAGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.khoaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // gbKHOA
            // 
            this.gbKHOA.Controls.Add(this.btnHuyKHOA);
            this.gbKHOA.Controls.Add(this.btnOkKHOA);
            this.gbKHOA.Controls.Add(mACSLabel);
            this.gbKHOA.Controls.Add(this.txtMACS);
            this.gbKHOA.Controls.Add(tENKHLabel);
            this.gbKHOA.Controls.Add(this.txtTENKH);
            this.gbKHOA.Controls.Add(mAKHLabel);
            this.gbKHOA.Controls.Add(this.txtMAKH);
            this.gbKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbKHOA.Enabled = false;
            this.gbKHOA.Location = new System.Drawing.Point(3, 222);
            this.gbKHOA.Name = "gbKHOA";
            this.gbKHOA.Size = new System.Drawing.Size(384, 214);
            this.gbKHOA.TabIndex = 2;
            this.gbKHOA.TabStop = false;
            // 
            // btnHuyKHOA
            // 
            this.btnHuyKHOA.Location = new System.Drawing.Point(168, 157);
            this.btnHuyKHOA.Name = "btnHuyKHOA";
            this.btnHuyKHOA.Size = new System.Drawing.Size(71, 23);
            this.btnHuyKHOA.TabIndex = 7;
            this.btnHuyKHOA.Text = "Cancel";
            this.btnHuyKHOA.UseVisualStyleBackColor = true;
            this.btnHuyKHOA.Visible = false;
            this.btnHuyKHOA.Click += new System.EventHandler(this.btnHuyKHOA_Click);
            // 
            // btnOkKHOA
            // 
            this.btnOkKHOA.Location = new System.Drawing.Point(65, 157);
            this.btnOkKHOA.Name = "btnOkKHOA";
            this.btnOkKHOA.Size = new System.Drawing.Size(70, 23);
            this.btnOkKHOA.TabIndex = 6;
            this.btnOkKHOA.Text = "Ok";
            this.btnOkKHOA.UseVisualStyleBackColor = true;
            this.btnOkKHOA.Visible = false;
            this.btnOkKHOA.Click += new System.EventHandler(this.btnOkKHOA_Click);
            // 
            // txtMACS
            // 
            this.txtMACS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MACS", true));
            this.txtMACS.Location = new System.Drawing.Point(65, 113);
            this.txtMACS.Name = "txtMACS";
            this.txtMACS.Size = new System.Drawing.Size(174, 21);
            this.txtMACS.TabIndex = 5;
            // 
            // txtTENKH
            // 
            this.txtTENKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "TENKH", true));
            this.txtTENKH.Location = new System.Drawing.Point(65, 68);
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(174, 21);
            this.txtTENKH.TabIndex = 3;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKHOA, "MAKH", true));
            this.txtMAKH.Location = new System.Drawing.Point(65, 29);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(174, 21);
            this.txtMAKH.TabIndex = 1;
            // 
            // gbLOP
            // 
            this.gbLOP.Controls.Add(this.btnHuyLOP);
            this.gbLOP.Controls.Add(this.btnOkLOP);
            this.gbLOP.Controls.Add(mAKHLabel1);
            this.gbLOP.Controls.Add(this.txtMAKH1);
            this.gbLOP.Controls.Add(tENLOPLabel);
            this.gbLOP.Controls.Add(this.txtTENLOP);
            this.gbLOP.Controls.Add(mALOPLabel);
            this.gbLOP.Controls.Add(this.txtMALOP);
            this.gbLOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLOP.Enabled = false;
            this.gbLOP.Location = new System.Drawing.Point(393, 222);
            this.gbLOP.Name = "gbLOP";
            this.gbLOP.Size = new System.Drawing.Size(384, 214);
            this.gbLOP.TabIndex = 3;
            this.gbLOP.TabStop = false;
            // 
            // btnHuyLOP
            // 
            this.btnHuyLOP.Location = new System.Drawing.Point(168, 157);
            this.btnHuyLOP.Name = "btnHuyLOP";
            this.btnHuyLOP.Size = new System.Drawing.Size(75, 23);
            this.btnHuyLOP.TabIndex = 7;
            this.btnHuyLOP.Text = "Cancel";
            this.btnHuyLOP.UseVisualStyleBackColor = true;
            this.btnHuyLOP.Visible = false;
            this.btnHuyLOP.Click += new System.EventHandler(this.btnHuyLOP_Click);
            // 
            // btnOkLOP
            // 
            this.btnOkLOP.Location = new System.Drawing.Point(65, 157);
            this.btnOkLOP.Name = "btnOkLOP";
            this.btnOkLOP.Size = new System.Drawing.Size(71, 23);
            this.btnOkLOP.TabIndex = 6;
            this.btnOkLOP.Text = "Ok";
            this.btnOkLOP.UseVisualStyleBackColor = true;
            this.btnOkLOP.Visible = false;
            this.btnOkLOP.Click += new System.EventHandler(this.btnOkLOP_Click);
            // 
            // txtMAKH1
            // 
            this.txtMAKH1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MAKH", true));
            this.txtMAKH1.Location = new System.Drawing.Point(68, 113);
            this.txtMAKH1.Name = "txtMAKH1";
            this.txtMAKH1.Size = new System.Drawing.Size(175, 21);
            this.txtMAKH1.TabIndex = 5;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(68, 68);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(175, 21);
            this.txtTENLOP.TabIndex = 3;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(68, 29);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(175, 21);
            this.txtMALOP.TabIndex = 1;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "FK_GIANGVIEN_KHOA";
            this.bdsGV.DataSource = this.bdsKHOA;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbCS);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKhoa";
            this.Text = "FormKhoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).EndInit();
            this.gbCS.ResumeLayout(false);
            this.gbCS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lopGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbKHOA.ResumeLayout(false);
            this.gbKHOA.PerformLayout();
            this.gbLOP.ResumeLayout(false);
            this.gbLOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private TRACNGHIEM tRACNGHIEM;
        private TRACNGHIEMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsKHOA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCS;
        private TRACNGHIEMTableAdapters.KHOATableAdapter khoaTableAdapter;
        private DevExpress.XtraGrid.GridControl khoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private TRACNGHIEMTableAdapters.LOPTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DevExpress.XtraGrid.GridControl lopGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private System.Windows.Forms.GroupBox gbKHOA;
        private System.Windows.Forms.GroupBox gbLOP;
        private System.Windows.Forms.Button btnHuyKHOA;
        private System.Windows.Forms.Button btnOkKHOA;
        private System.Windows.Forms.TextBox txtMACS;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.Button btnHuyLOP;
        private System.Windows.Forms.Button btnOkLOP;
        private System.Windows.Forms.TextBox txtMAKH1;
        private System.Windows.Forms.TextBox txtTENLOP;
        private System.Windows.Forms.TextBox txtMALOP;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsGV;
        private TRACNGHIEMTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.ComboBox cmbCS;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
    }
}