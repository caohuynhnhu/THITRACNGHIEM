namespace THITRACNGHIEM
{
    partial class FormMonHoc
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
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
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMTableAdapters.TableAdapterManager();
            this.monhocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbMH = new System.Windows.Forms.GroupBox();
            this.txtMAKH = new System.Windows.Forms.ComboBox();
            this.vLAYMAKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMK = new THITRACNGHIEM.DSMK();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.v_LAYMAKHOATableAdapter = new THITRACNGHIEM.DSMKTableAdapters.V_LAYMAKHOATableAdapter();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.cAUHOITableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.CAUHOITableAdapter();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.DANGKYTableAdapter();
            this.bdsGVD = new System.Windows.Forms.BindingSource(this.components);
            this.gV_DAYTableAdapter = new THITRACNGHIEM.TRACNGHIEMTableAdapters.GV_DAYTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVD)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(52, 34);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(48, 78);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(45, 13);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(54, 122);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(39, 13);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
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
            this.btnLoad.Id = 4;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Exit ";
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
            this.barDockControlTop.Size = new System.Drawing.Size(726, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 696);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(726, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 656);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(726, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 656);
            // 
            // tRACNGHIEM
            // 
            this.tRACNGHIEM.DataSetName = "TRACNGHIEM";
            this.tRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.tRACNGHIEM;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
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
            // monhocGridControl
            // 
            this.monhocGridControl.DataSource = this.bdsMH;
            this.monhocGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.monhocGridControl.Location = new System.Drawing.Point(0, 40);
            this.monhocGridControl.MainView = this.gridView1;
            this.monhocGridControl.MenuManager = this.barManager1;
            this.monhocGridControl.Name = "monhocGridControl";
            this.monhocGridControl.Size = new System.Drawing.Size(726, 220);
            this.monhocGridControl.TabIndex = 5;
            this.monhocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colMAKH});
            this.gridView1.GridControl = this.monhocGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // gbMH
            // 
            this.gbMH.Controls.Add(this.txtMAKH);
            this.gbMH.Controls.Add(this.btnHuy);
            this.gbMH.Controls.Add(this.btnOk);
            this.gbMH.Controls.Add(mAKHLabel);
            this.gbMH.Controls.Add(tENMHLabel);
            this.gbMH.Controls.Add(this.txtTENMH);
            this.gbMH.Controls.Add(mAMHLabel);
            this.gbMH.Controls.Add(this.txtMAMH);
            this.gbMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMH.Enabled = false;
            this.gbMH.Location = new System.Drawing.Point(0, 260);
            this.gbMH.Name = "gbMH";
            this.gbMH.Size = new System.Drawing.Size(726, 149);
            this.gbMH.TabIndex = 6;
            this.gbMH.TabStop = false;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "MAKH", true));
            this.txtMAKH.DataSource = this.vLAYMAKHOABindingSource;
            this.txtMAKH.DisplayMember = "MAKH";
            this.txtMAKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMAKH.FormattingEnabled = true;
            this.txtMAKH.Location = new System.Drawing.Point(99, 119);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(128, 21);
            this.txtMAKH.TabIndex = 8;
            this.txtMAKH.ValueMember = "MAKH";
            // 
            // vLAYMAKHOABindingSource
            // 
            this.vLAYMAKHOABindingSource.DataMember = "V_LAYMAKHOA";
            this.vLAYMAKHOABindingSource.DataSource = this.dSMK;
            // 
            // dSMK
            // 
            this.dSMK.DataSetName = "DSMK";
            this.dSMK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(306, 72);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(306, 28);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "TENMH", true));
            this.txtTENMH.Location = new System.Drawing.Point(99, 75);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(128, 21);
            this.txtTENMH.TabIndex = 3;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(99, 31);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(128, 21);
            this.txtMAMH.TabIndex = 1;
            // 
            // v_LAYMAKHOATableAdapter
            // 
            this.v_LAYMAKHOATableAdapter.ClearBeforeFill = true;
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "FK_CAUHOI_MONHOC";
            this.bdsCH.DataSource = this.bdsMH;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_DANGKY_MONHOC";
            this.bdsDK.DataSource = this.bdsMH;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGVD
            // 
            this.bdsGVD.DataMember = "FK_GV_DAY_MONHOC";
            this.bdsGVD.DataSource = this.bdsMH;
            // 
            // gV_DAYTableAdapter
            // 
            this.gV_DAYTableAdapter.ClearBeforeFill = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 696);
            this.Controls.Add(this.gbMH);
            this.Controls.Add(this.monhocGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMonHoc";
            this.Text = "MÔN HỌC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbMH.ResumeLayout(false);
            this.gbMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vLAYMAKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsMH;
        private TRACNGHIEM tRACNGHIEM;
        private TRACNGHIEMTableAdapters.MONHOCTableAdapter monhocTableAdapter;
        private TRACNGHIEMTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl monhocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.GroupBox gbMH;
        private System.Windows.Forms.TextBox txtTENMH;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox txtMAKH;
        private DSMK dSMK;
        private System.Windows.Forms.BindingSource vLAYMAKHOABindingSource;
        private DSMKTableAdapters.V_LAYMAKHOATableAdapter v_LAYMAKHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsCH;
        private TRACNGHIEMTableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private System.Windows.Forms.BindingSource bdsDK;
        private TRACNGHIEMTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVD;
        private TRACNGHIEMTableAdapters.GV_DAYTableAdapter gV_DAYTableAdapter;
    }
}