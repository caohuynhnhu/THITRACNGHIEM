namespace THITRACNGHIEM
{
    partial class FormSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKQ = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.SinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbThi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbXemKQ = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnThi,
            this.btnXemKQ,
            this.btnDX});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.SinhVien});
            this.ribbon.Size = new System.Drawing.Size(679, 158);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "THI";
            this.btnThi.Id = 1;
            this.btnThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThi.ImageOptions.Image")));
            this.btnThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThi.ImageOptions.LargeImage")));
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Caption = "XEM KẾT QUẢ THI";
            this.btnXemKQ.Id = 2;
            this.btnXemKQ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.ImageOptions.Image")));
            this.btnXemKQ.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.ImageOptions.LargeImage")));
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKQ_ItemClick);
            // 
            // btnDX
            // 
            this.btnDX.Caption = "ĐĂNG XUẤT";
            this.btnDX.Id = 3;
            this.btnDX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDX.ImageOptions.Image")));
            this.btnDX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDX.ImageOptions.LargeImage")));
            this.btnDX.Name = "btnDX";
            this.btnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDX_ItemClick);
            // 
            // SinhVien
            // 
            this.SinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbThi,
            this.rbXemKQ,
            this.rbDX});
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.Text = "SINH VIÊN";
            // 
            // rbThi
            // 
            this.rbThi.ItemLinks.Add(this.btnThi);
            this.rbThi.Name = "rbThi";
            // 
            // rbXemKQ
            // 
            this.rbXemKQ.ItemLinks.Add(this.btnXemKQ);
            this.rbXemKQ.Name = "rbXemKQ";
            // 
            // rbDX
            // 
            this.rbDX.ItemLinks.Add(this.btnDX);
            this.rbDX.Name = "rbDX";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaSV,
            this.HoTen,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaSV
            // 
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(46, 17);
            this.MaSV.Text = "Mã SV: ";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(50, 17);
            this.HoTen.Text = "Họ Tên: ";
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(41, 17);
            this.Nhom.Text = "Nhóm";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormSV";
            this.Ribbon = this.ribbon;
            this.Text = "Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSV_FormClosing);
            this.Load += new System.EventHandler(this.FormSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage SinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbThi;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem btnXemKQ;
        private DevExpress.XtraBars.BarButtonItem btnDX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbXemKQ;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDX;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MaSV;
        private System.Windows.Forms.ToolStripStatusLabel HoTen;
        private System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}