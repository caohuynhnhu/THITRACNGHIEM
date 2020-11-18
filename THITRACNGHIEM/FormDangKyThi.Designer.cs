namespace THITRACNGHIEM
{
    partial class FormDangKyThi
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label iDDKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKyThi));
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOCAULabel;
            System.Windows.Forms.Label nGAYTHILabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tRACNGHIEM = new THITRACNGHIEM.TRACNGHIEM();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.dangkyTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager();
            this.monhocTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.MONHOCTableAdapter();
            this.dangkyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.cmbMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtIDDK = new System.Windows.Forms.TextBox();
            this.cmbTD = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.LOPTableAdapter();
            this.cmbML = new System.Windows.Forms.ComboBox();
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.sPLAYTRINHDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYTRINHDOTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.SP_LAYTRINHDOTableAdapter();
            this.spinTG = new DevExpress.XtraEditors.SpinEdit();
            this.spinSC = new DevExpress.XtraEditors.SpinEdit();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.datetimeNT = new System.Windows.Forms.DateTimePicker();
            mAMHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            iDDKLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOCAULabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangkyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYTRINHDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(29, 28);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(31, 156);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(305, 28);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(57, 13);
            tRINHDOLabel.TabIndex = 8;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // iDDKLabel
            // 
            iDDKLabel.AutoSize = true;
            iDDKLabel.Location = new System.Drawing.Point(327, 156);
            iDDKLabel.Name = "iDDKLabel";
            iDDKLabel.Size = new System.Drawing.Size(35, 13);
            iDDKLabel.TabIndex = 14;
            iDDKLabel.Text = "IDDK:";
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
            this.btnThoat,
            this.btnThem,
            this.btnLoad});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Add";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Exit";
            this.btnThoat.Id = 0;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1022, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1022, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1022, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 460);
            // 
            // tRACNGHIEM
            // 
            this.tRACNGHIEM.DataSetName = "TRACNGHIEM";
            this.tRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "DANGKY";
            this.bdsDK.DataSource = this.tRACNGHIEM;
            // 
            // dangkyTableAdapter
            // 
            this.dangkyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = this.dangkyTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // dangkyGridControl
            // 
            this.dangkyGridControl.DataSource = this.bdsDK;
            this.dangkyGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dangkyGridControl.Location = new System.Drawing.Point(0, 40);
            this.dangkyGridControl.MainView = this.gridView1;
            this.dangkyGridControl.MenuManager = this.barManager1;
            this.dangkyGridControl.Name = "dangkyGridControl";
            this.dangkyGridControl.Size = new System.Drawing.Size(1022, 226);
            this.dangkyGridControl.TabIndex = 6;
            this.dangkyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colMALOP,
            this.colNGAYTHI,
            this.colMANV,
            this.colTRINHDO,
            this.colTHOIGIAN,
            this.colSOCAU,
            this.colIDDK});
            this.gridView1.GridControl = this.dangkyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 4;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            // 
            // colSOCAU
            // 
            this.colSOCAU.FieldName = "SOCAU";
            this.colSOCAU.Name = "colSOCAU";
            this.colSOCAU.OptionsColumn.AllowEdit = false;
            this.colSOCAU.Visible = true;
            this.colSOCAU.VisibleIndex = 6;
            // 
            // colIDDK
            // 
            this.colIDDK.FieldName = "IDDK";
            this.colIDDK.Name = "colIDDK";
            this.colIDDK.OptionsColumn.AllowEdit = false;
            this.colIDDK.Visible = true;
            this.colIDDK.VisibleIndex = 7;
            // 
            // gbDK
            // 
            this.gbDK.Controls.Add(nGAYTHILabel);
            this.gbDK.Controls.Add(this.datetimeNT);
            this.gbDK.Controls.Add(sOCAULabel);
            this.gbDK.Controls.Add(this.spinSC);
            this.gbDK.Controls.Add(tHOIGIANLabel);
            this.gbDK.Controls.Add(this.spinTG);
            this.gbDK.Controls.Add(mALOPLabel);
            this.gbDK.Controls.Add(this.cmbML);
            this.gbDK.Controls.Add(this.cmbMH);
            this.gbDK.Controls.Add(this.btnHuy);
            this.gbDK.Controls.Add(this.btnOk);
            this.gbDK.Controls.Add(iDDKLabel);
            this.gbDK.Controls.Add(this.txtIDDK);
            this.gbDK.Controls.Add(tRINHDOLabel);
            this.gbDK.Controls.Add(this.cmbTD);
            this.gbDK.Controls.Add(mANVLabel);
            this.gbDK.Controls.Add(this.txtMANV);
            this.gbDK.Controls.Add(mAMHLabel);
            this.gbDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDK.Enabled = false;
            this.gbDK.Location = new System.Drawing.Point(0, 266);
            this.gbDK.Name = "gbDK";
            this.gbDK.Size = new System.Drawing.Size(1022, 399);
            this.gbDK.TabIndex = 7;
            this.gbDK.TabStop = false;
            // 
            // cmbMH
            // 
            this.cmbMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "MAMH", true));
            this.cmbMH.DataSource = this.bdsMH;
            this.cmbMH.DisplayMember = "MAMH";
            this.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMH.FormattingEnabled = true;
            this.cmbMH.Location = new System.Drawing.Point(76, 25);
            this.cmbMH.Name = "cmbMH";
            this.cmbMH.Size = new System.Drawing.Size(189, 21);
            this.cmbMH.TabIndex = 18;
            this.cmbMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.tRACNGHIEM;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(577, 66);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(577, 23);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtIDDK
            // 
            this.txtIDDK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "IDDK", true));
            this.txtIDDK.Location = new System.Drawing.Point(368, 153);
            this.txtIDDK.Name = "txtIDDK";
            this.txtIDDK.Size = new System.Drawing.Size(149, 21);
            this.txtIDDK.TabIndex = 15;
            // 
            // cmbTD
            // 
            this.cmbTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "TRINHDO", true));
            this.cmbTD.DataSource = this.sPLAYTRINHDOBindingSource;
            this.cmbTD.DisplayMember = "MATRINHDO";
            this.cmbTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTD.FormattingEnabled = true;
            this.cmbTD.Location = new System.Drawing.Point(368, 25);
            this.cmbTD.Name = "cmbTD";
            this.cmbTD.Size = new System.Drawing.Size(149, 21);
            this.cmbTD.TabIndex = 9;
            this.cmbTD.ValueMember = "MATRINHDO";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(76, 153);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(189, 21);
            this.txtMANV.TabIndex = 7;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.tRACNGHIEM;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(25, 71);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 18;
            mALOPLabel.Text = "MALOP:";
            // 
            // cmbML
            // 
            this.cmbML.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "MALOP", true));
            this.cmbML.DataSource = this.bdsLop;
            this.cmbML.DisplayMember = "MALOP";
            this.cmbML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbML.FormattingEnabled = true;
            this.cmbML.Location = new System.Drawing.Point(76, 68);
            this.cmbML.Name = "cmbML";
            this.cmbML.Size = new System.Drawing.Size(189, 21);
            this.cmbML.TabIndex = 19;
            this.cmbML.ValueMember = "MALOP";
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPLAYTRINHDOBindingSource
            // 
            this.sPLAYTRINHDOBindingSource.DataMember = "SP_LAYTRINHDO";
            this.sPLAYTRINHDOBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // sP_LAYTRINHDOTableAdapter
            // 
            this.sP_LAYTRINHDOTableAdapter.ClearBeforeFill = true;
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(301, 71);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(61, 13);
            tHOIGIANLabel.TabIndex = 19;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // spinTG
            // 
            this.spinTG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDK, "THOIGIAN", true));
            this.spinTG.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinTG.Location = new System.Drawing.Point(368, 68);
            this.spinTG.MenuManager = this.barManager1;
            this.spinTG.Name = "spinTG";
            this.spinTG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTG.Size = new System.Drawing.Size(149, 20);
            this.spinTG.TabIndex = 20;
            // 
            // sOCAULabel
            // 
            sOCAULabel.AutoSize = true;
            sOCAULabel.Location = new System.Drawing.Point(316, 114);
            sOCAULabel.Name = "sOCAULabel";
            sOCAULabel.Size = new System.Drawing.Size(46, 13);
            sOCAULabel.TabIndex = 20;
            sOCAULabel.Text = "SOCAU:";
            // 
            // spinSC
            // 
            this.spinSC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDK, "SOCAU", true));
            this.spinSC.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinSC.Location = new System.Drawing.Point(368, 111);
            this.spinSC.MenuManager = this.barManager1;
            this.spinSC.Name = "spinSC";
            this.spinSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSC.Size = new System.Drawing.Size(149, 20);
            this.spinSC.TabIndex = 21;
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Refresh";
            this.btnLoad.Id = 2;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(15, 114);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(55, 13);
            nGAYTHILabel.TabIndex = 21;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // datetimeNT
            // 
            this.datetimeNT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDK, "NGAYTHI", true));
            this.datetimeNT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNT.Location = new System.Drawing.Point(76, 110);
            this.datetimeNT.Name = "datetimeNT";
            this.datetimeNT.Size = new System.Drawing.Size(189, 21);
            this.datetimeNT.TabIndex = 22;
            // 
            // FormDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 500);
            this.Controls.Add(this.gbDK);
            this.Controls.Add(this.dangkyGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDangKyThi";
            this.Text = "ĐĂNG KÝ THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangkyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbDK.ResumeLayout(false);
            this.gbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYTRINHDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDK;
        private TRACNGHIEM tRACNGHIEM;
        private TRACNGHIEMTableAdapters.DANGKYTableAdapter dangkyTableAdapter;
        private TRACNGHIEMTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dangkyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAU;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDK;
        private System.Windows.Forms.GroupBox gbDK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtIDDK;
        private System.Windows.Forms.ComboBox cmbTD;
        private System.Windows.Forms.TextBox txtMANV;
        private TRACNGHIEMTableAdapters.MONHOCTableAdapter monhocTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.ComboBox cmbMH;
        private System.Windows.Forms.BindingSource bdsLop;
        private TRACNGHIEMTableAdapters.LOPTableAdapter lopTableAdapter;
        private System.Windows.Forms.ComboBox cmbML;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource sPLAYTRINHDOBindingSource;
        private TRACNGHIEMDataSetTableAdapters.SP_LAYTRINHDOTableAdapter sP_LAYTRINHDOTableAdapter;
        private DevExpress.XtraEditors.SpinEdit spinSC;
        private DevExpress.XtraEditors.SpinEdit spinTG;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private System.Windows.Forms.DateTimePicker datetimeNT;
    }
}