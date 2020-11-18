namespace THITRACNGHIEM
{
    partial class FormBoDe
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
            System.Windows.Forms.Label mACHLabel;
            System.Windows.Forms.Label lOAICAUHOILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label dAPANLabel;
            System.Windows.Forms.Label mATRINHDOLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoDe));
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
            this.pnMM = new System.Windows.Forms.Panel();
            this.MAMH = new System.Windows.Forms.Label();
            this.cmbMH = new System.Windows.Forms.ComboBox();
            this.bdsMK = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.tRACNGHIEM = new THITRACNGHIEM.TRACNGHIEM();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.cauhoiTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.CAUHOITableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager();
            this.cauhoiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAICAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAPAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_MON_GVDAYTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.SP_MON_GVDAYTableAdapter();
            this.tableAdapterManager1 = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.gbCH = new System.Windows.Forms.GroupBox();
            this.txtND = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.txtTD = new System.Windows.Forms.ComboBox();
            this.bdsTD = new System.Windows.Forms.BindingSource(this.components);
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.txtLCH = new System.Windows.Forms.TextBox();
            this.txtMACH = new System.Windows.Forms.TextBox();
            this.trinhdoTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.SP_LAYTRINHDOTableAdapter();
            mACHLabel = new System.Windows.Forms.Label();
            lOAICAUHOILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            dAPANLabel = new System.Windows.Forms.Label();
            mATRINHDOLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauhoiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).BeginInit();
            this.SuspendLayout();
            // 
            // mACHLabel
            // 
            mACHLabel.AutoSize = true;
            mACHLabel.Location = new System.Drawing.Point(47, 9);
            mACHLabel.Name = "mACHLabel";
            mACHLabel.Size = new System.Drawing.Size(40, 13);
            mACHLabel.TabIndex = 0;
            mACHLabel.Text = "MACH:";
            // 
            // lOAICAUHOILabel
            // 
            lOAICAUHOILabel.AutoSize = true;
            lOAICAUHOILabel.Location = new System.Drawing.Point(520, 9);
            lOAICAUHOILabel.Name = "lOAICAUHOILabel";
            lOAICAUHOILabel.Size = new System.Drawing.Size(75, 13);
            lOAICAUHOILabel.TabIndex = 4;
            lOAICAUHOILabel.Text = "LOAICAUHOI:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(46, 46);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "MAMH:";
            // 
            // dAPANLabel
            // 
            dAPANLabel.AutoSize = true;
            dAPANLabel.Location = new System.Drawing.Point(42, 118);
            dAPANLabel.Name = "dAPANLabel";
            dAPANLabel.Size = new System.Drawing.Size(45, 13);
            dAPANLabel.TabIndex = 8;
            dAPANLabel.Text = "DAPAN:";
            // 
            // mATRINHDOLabel
            // 
            mATRINHDOLabel.AutoSize = true;
            mATRINHDOLabel.Location = new System.Drawing.Point(523, 46);
            mATRINHDOLabel.Name = "mATRINHDOLabel";
            mATRINHDOLabel.Size = new System.Drawing.Size(72, 13);
            mATRINHDOLabel.TabIndex = 10;
            mATRINHDOLabel.Text = "MATRINHDO:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(556, 118);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 12;
            mAGVLabel.Text = "MAGV:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(29, 82);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(58, 13);
            nOIDUNGLabel.TabIndex = 15;
            nOIDUNGLabel.Text = "NOIDUNG:";
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
            this.btnLoad,
            this.btnThoat});
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
            this.btnLoad.Id = 4;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Exit";
            this.btnThoat.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(897, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(897, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // pnMM
            // 
            this.pnMM.Controls.Add(this.MAMH);
            this.pnMM.Controls.Add(this.cmbMH);
            this.pnMM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMM.Location = new System.Drawing.Point(0, 40);
            this.pnMM.Name = "pnMM";
            this.pnMM.Size = new System.Drawing.Size(897, 50);
            this.pnMM.TabIndex = 4;
            // 
            // MAMH
            // 
            this.MAMH.AutoSize = true;
            this.MAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAMH.Location = new System.Drawing.Point(111, 16);
            this.MAMH.Name = "MAMH";
            this.MAMH.Size = new System.Drawing.Size(68, 19);
            this.MAMH.TabIndex = 1;
            this.MAMH.Text = "Môn Học";
            // 
            // cmbMH
            // 
            this.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMH.FormattingEnabled = true;
            this.cmbMH.Location = new System.Drawing.Point(197, 14);
            this.cmbMH.Name = "cmbMH";
            this.cmbMH.Size = new System.Drawing.Size(244, 21);
            this.cmbMH.TabIndex = 0;
            this.cmbMH.SelectionChangeCommitted += new System.EventHandler(this.cmbMH_SelectionChangeCommitted);
            this.cmbMH.Click += new System.EventHandler(this.cmbMK_Click);
            // 
            // bdsMK
            // 
            this.bdsMK.DataMember = "SP_MON_GVDAY";
            this.bdsMK.DataSource = this.tRACNGHIEMDataSet;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRACNGHIEM
            // 
            this.tRACNGHIEM.DataSetName = "TRACNGHIEM";
            this.tRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "CAUHOI";
            this.bdsCH.DataSource = this.tRACNGHIEM;
            // 
            // cauhoiTableAdapter
            // 
            this.cauhoiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = this.cauhoiTableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cauhoiGridControl
            // 
            this.cauhoiGridControl.DataSource = this.bdsCH;
            this.cauhoiGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cauhoiGridControl.Location = new System.Drawing.Point(0, 90);
            this.cauhoiGridControl.MainView = this.gridView1;
            this.cauhoiGridControl.MenuManager = this.barManager1;
            this.cauhoiGridControl.Name = "cauhoiGridControl";
            this.cauhoiGridControl.Size = new System.Drawing.Size(897, 296);
            this.cauhoiGridControl.TabIndex = 6;
            this.cauhoiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACH,
            this.colNOIDUNG,
            this.colLOAICAUHOI,
            this.colDAPAN,
            this.colMAMH,
            this.colMATRINHDO,
            this.colMAGV});
            this.gridView1.GridControl = this.cauhoiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMACH
            // 
            this.colMACH.FieldName = "MACH";
            this.colMACH.Name = "colMACH";
            this.colMACH.OptionsColumn.AllowEdit = false;
            this.colMACH.Visible = true;
            this.colMACH.VisibleIndex = 0;
            this.colMACH.Width = 91;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.OptionsColumn.AllowEdit = false;
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 1;
            this.colNOIDUNG.Width = 316;
            // 
            // colLOAICAUHOI
            // 
            this.colLOAICAUHOI.FieldName = "LOAICAUHOI";
            this.colLOAICAUHOI.Name = "colLOAICAUHOI";
            this.colLOAICAUHOI.OptionsColumn.AllowEdit = false;
            this.colLOAICAUHOI.Visible = true;
            this.colLOAICAUHOI.VisibleIndex = 2;
            this.colLOAICAUHOI.Width = 84;
            // 
            // colDAPAN
            // 
            this.colDAPAN.FieldName = "DAPAN";
            this.colDAPAN.Name = "colDAPAN";
            this.colDAPAN.OptionsColumn.AllowEdit = false;
            this.colDAPAN.Visible = true;
            this.colDAPAN.VisibleIndex = 3;
            this.colDAPAN.Width = 73;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 4;
            this.colMAMH.Width = 98;
            // 
            // colMATRINHDO
            // 
            this.colMATRINHDO.FieldName = "MATRINHDO";
            this.colMATRINHDO.Name = "colMATRINHDO";
            this.colMATRINHDO.OptionsColumn.AllowEdit = false;
            this.colMATRINHDO.Visible = true;
            this.colMATRINHDO.VisibleIndex = 5;
            this.colMATRINHDO.Width = 98;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 6;
            this.colMAGV.Width = 112;
            // 
            // sP_MON_GVDAYTableAdapter
            // 
            this.sP_MON_GVDAYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gbCH
            // 
            this.gbCH.Controls.Add(nOIDUNGLabel);
            this.gbCH.Controls.Add(this.txtND);
            this.gbCH.Controls.Add(this.btnHuy);
            this.gbCH.Controls.Add(this.btnOk);
            this.gbCH.Controls.Add(mAGVLabel);
            this.gbCH.Controls.Add(this.txtMAGV);
            this.gbCH.Controls.Add(mATRINHDOLabel);
            this.gbCH.Controls.Add(this.txtTD);
            this.gbCH.Controls.Add(dAPANLabel);
            this.gbCH.Controls.Add(this.txtDA);
            this.gbCH.Controls.Add(mAMHLabel);
            this.gbCH.Controls.Add(this.txtMAMH);
            this.gbCH.Controls.Add(lOAICAUHOILabel);
            this.gbCH.Controls.Add(this.txtLCH);
            this.gbCH.Controls.Add(mACHLabel);
            this.gbCH.Controls.Add(this.txtMACH);
            this.gbCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCH.Enabled = false;
            this.gbCH.Location = new System.Drawing.Point(0, 386);
            this.gbCH.Name = "gbCH";
            this.gbCH.Size = new System.Drawing.Size(897, 195);
            this.gbCH.TabIndex = 11;
            this.gbCH.TabStop = false;
            // 
            // txtND
            // 
            this.txtND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "NOIDUNG", true));
            this.txtND.Location = new System.Drawing.Point(93, 79);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(629, 21);
            this.txtND.TabIndex = 16;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(753, 46);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(753, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(601, 115);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(122, 21);
            this.txtMAGV.TabIndex = 13;
            // 
            // txtTD
            // 
            this.txtTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MATRINHDO", true));
            this.txtTD.DataSource = this.bdsTD;
            this.txtTD.DisplayMember = "MATRINHDO";
            this.txtTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTD.FormattingEnabled = true;
            this.txtTD.Location = new System.Drawing.Point(601, 43);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(121, 21);
            this.txtTD.TabIndex = 11;
            this.txtTD.ValueMember = "MATRINHDO";
            // 
            // bdsTD
            // 
            this.bdsTD.DataMember = "SP_LAYTRINHDO";
            this.bdsTD.DataSource = this.tRACNGHIEMDataSet;
            // 
            // txtDA
            // 
            this.txtDA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "DAPAN", true));
            this.txtDA.Location = new System.Drawing.Point(93, 115);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(121, 21);
            this.txtDA.TabIndex = 9;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(93, 43);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(121, 21);
            this.txtMAMH.TabIndex = 7;
            // 
            // txtLCH
            // 
            this.txtLCH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "LOAICAUHOI", true));
            this.txtLCH.Location = new System.Drawing.Point(601, 6);
            this.txtLCH.Name = "txtLCH";
            this.txtLCH.Size = new System.Drawing.Size(121, 21);
            this.txtLCH.TabIndex = 5;
            // 
            // txtMACH
            // 
            this.txtMACH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MACH", true));
            this.txtMACH.Location = new System.Drawing.Point(93, 6);
            this.txtMACH.Name = "txtMACH";
            this.txtMACH.Size = new System.Drawing.Size(121, 21);
            this.txtMACH.TabIndex = 1;
            // 
            // trinhdoTableAdapter
            // 
            this.trinhdoTableAdapter.ClearBeforeFill = true;
            // 
            // FormBoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 602);
            this.Controls.Add(this.gbCH);
            this.Controls.Add(this.cauhoiGridControl);
            this.Controls.Add(this.pnMM);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBoDe";
            this.Text = "BỘ ĐỀ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBoDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnMM.ResumeLayout(false);
            this.pnMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauhoiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbCH.ResumeLayout(false);
            this.gbCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel pnMM;
        private System.Windows.Forms.BindingSource bdsCH;
        private TRACNGHIEM tRACNGHIEM;
        private TRACNGHIEMTableAdapters.CAUHOITableAdapter cauhoiTableAdapter;
        private TRACNGHIEMTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl cauhoiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAICAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colDAPAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource bdsMK;
        private TRACNGHIEMDataSetTableAdapters.SP_MON_GVDAYTableAdapter sP_MON_GVDAYTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label MAMH;
        private System.Windows.Forms.ComboBox cmbMH;
        private System.Windows.Forms.GroupBox gbCH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.ComboBox txtTD;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.TextBox txtLCH;
        private System.Windows.Forms.TextBox txtMACH;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.BindingSource bdsTD;
        private TRACNGHIEMDataSetTableAdapters.SP_LAYTRINHDOTableAdapter trinhdoTableAdapter;
    }
}