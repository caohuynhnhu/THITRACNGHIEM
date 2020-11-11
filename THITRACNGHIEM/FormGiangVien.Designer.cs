namespace THITRACNGHIEM
{
    partial class FormGiangVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiangVien));
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
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.giangvienTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager();
            this.giangvienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbGV = new System.Windows.Forms.GroupBox();
            this.txtMAKH = new System.Windows.Forms.ComboBox();
            this.bdsMK = new System.Windows.Forms.BindingSource(this.components);
            this.dSMK = new THITRACNGHIEM.DSMK();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.v_LAYMAKHOATableAdapter = new THITRACNGHIEM.DSMKTableAdapters.V_LAYMAKHOATableAdapter();
            this.tableAdapterManager2 = new THITRACNGHIEM.DSMKTableAdapters.TableAdapterManager();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.cAUHOITableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.CAUHOITableAdapter();
            this.bdsGVDAY = new System.Windows.Forms.BindingSource(this.components);
            this.gV_DAYTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.GV_DAYTableAdapter();
            this.vLAYMAKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_LAYMAKHOATableAdapter1 = new THITRACNGHIEM.TRACNGHIEMTableAdapters.V_LAYMAKHOATableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAKHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(33, 51);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(39, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(46, 100);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(42, 149);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(270, 48);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(278, 100);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(39, 13);
            mAKHLabel1.TabIndex = 11;
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
            this.btnLoad,
            this.btnThoat});
            this.barManager1.MaxItemId = 7;
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
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Delete";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Edit";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Save";
            this.btnLuu.Id = 4;
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
            this.btnThoat.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(795, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(795, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(795, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // tRACNGHIEM
            // 
            this.tRACNGHIEM.DataSetName = "TRACNGHIEM";
            this.tRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.tRACNGHIEM;
            // 
            // giangvienTableAdapter
            // 
            this.giangvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.giangvienTableAdapter;
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
            // giangvienGridControl
            // 
            this.giangvienGridControl.DataSource = this.bdsGV;
            this.giangvienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.giangvienGridControl.Location = new System.Drawing.Point(0, 40);
            this.giangvienGridControl.MainView = this.gridView1;
            this.giangvienGridControl.MenuManager = this.barManager1;
            this.giangvienGridControl.Name = "giangvienGridControl";
            this.giangvienGridControl.Size = new System.Drawing.Size(795, 214);
            this.giangvienGridControl.TabIndex = 5;
            this.giangvienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH});
            this.gridView1.GridControl = this.giangvienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            // 
            // gbGV
            // 
            this.gbGV.Controls.Add(mAKHLabel1);
            this.gbGV.Controls.Add(this.txtMAKH);
            this.gbGV.Controls.Add(this.btnHuy);
            this.gbGV.Controls.Add(this.btnOk);
            this.gbGV.Controls.Add(dIACHILabel);
            this.gbGV.Controls.Add(this.txtDC);
            this.gbGV.Controls.Add(tENLabel);
            this.gbGV.Controls.Add(this.txtTEN);
            this.gbGV.Controls.Add(hOLabel);
            this.gbGV.Controls.Add(this.txtHO);
            this.gbGV.Controls.Add(mAGVLabel);
            this.gbGV.Controls.Add(this.txtMAGV);
            this.gbGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGV.Enabled = false;
            this.gbGV.Location = new System.Drawing.Point(0, 254);
            this.gbGV.Name = "gbGV";
            this.gbGV.Size = new System.Drawing.Size(795, 196);
            this.gbGV.TabIndex = 15;
            this.gbGV.TabStop = false;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKH", true));
            this.txtMAKH.DataSource = this.vLAYMAKHOABindingSource;
            this.txtMAKH.DisplayMember = "MAKH";
            this.txtMAKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMAKH.FormattingEnabled = true;
            this.txtMAKH.Location = new System.Drawing.Point(323, 97);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(171, 21);
            this.txtMAKH.TabIndex = 12;
            this.txtMAKH.ValueMember = "MAKH";
            // 
            // bdsMK
            // 
            this.bdsMK.DataMember = "V_LAYMAKHOA";
            this.bdsMK.DataSource = this.dSMK;
            // 
            // dSMK
            // 
            this.dSMK.DataSetName = "DSMK";
            this.dSMK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(419, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(323, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // txtDC
            // 
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "DIACHI", true));
            this.txtDC.Location = new System.Drawing.Point(323, 45);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(171, 21);
            this.txtDC.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(78, 146);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 21);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(78, 97);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(100, 21);
            this.txtHO.TabIndex = 3;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(78, 48);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(100, 21);
            this.txtMAGV.TabIndex = 1;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.tRACNGHIEMDataSet;
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
            // v_LAYMAKHOATableAdapter
            // 
            this.v_LAYMAKHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = THITRACNGHIEM.DSMKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "FK_CAUHOI_GIANGVIEN";
            this.bdsCH.DataSource = this.bdsGV;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // bdsGVDAY
            // 
            this.bdsGVDAY.DataMember = "FK_GV_DAY_GIANGVIEN";
            this.bdsGVDAY.DataSource = this.bdsGV;
            // 
            // gV_DAYTableAdapter
            // 
            this.gV_DAYTableAdapter.ClearBeforeFill = true;
            // 
            // vLAYMAKHOABindingSource
            // 
            this.vLAYMAKHOABindingSource.DataMember = "V_LAYMAKHOA";
            this.vLAYMAKHOABindingSource.DataSource = this.tRACNGHIEM;
            // 
            // v_LAYMAKHOATableAdapter1
            // 
            this.v_LAYMAKHOATableAdapter1.ClearBeforeFill = true;
            // 
            // FormGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 488);
            this.Controls.Add(this.gbGV);
            this.Controls.Add(this.giangvienGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGiangVien";
            this.Text = "GIẢNG VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbGV.ResumeLayout(false);
            this.gbGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAKHOABindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private System.Windows.Forms.BindingSource bdsGV;
        private TRACNGHIEM tRACNGHIEM;
        private TRACNGHIEMTableAdapters.GIANGVIENTableAdapter giangvienTableAdapter;
        private TRACNGHIEMTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl giangvienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.GroupBox gbGV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtMAGV;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DSMK dSMK;
        private System.Windows.Forms.BindingSource bdsMK;
        private DSMKTableAdapters.V_LAYMAKHOATableAdapter v_LAYMAKHOATableAdapter;
        private DSMKTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ComboBox txtMAKH;
        private System.Windows.Forms.BindingSource bdsCH;
        private TRACNGHIEMTableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDAY;
        private TRACNGHIEMTableAdapters.GV_DAYTableAdapter gV_DAYTableAdapter;
        private System.Windows.Forms.BindingSource vLAYMAKHOABindingSource;
        private TRACNGHIEMTableAdapters.V_LAYMAKHOATableAdapter v_LAYMAKHOATableAdapter1;
    }
}