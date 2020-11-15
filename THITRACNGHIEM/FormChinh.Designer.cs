namespace THITRACNGHIEM
{
    partial class FormChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnDKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKHOA = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDX = new DevExpress.XtraBars.BarButtonItem();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnTaoTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Ten = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.barBtnTaoTK,
            this.barBtnGV,
            this.barBtnSV,
            this.barBtnMH,
            this.btnBD,
            this.btnDKT,
            this.btnThi,
            this.barButtonItem8,
            this.barBtnDangXuat,
            this.barBtnKHOA,
            this.barBtnDX});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.ribbonPage2,
            this.pageBaoCao});
            this.ribbon.Size = new System.Drawing.Size(759, 158);
            // 
            // barBtnTaoTK
            // 
            this.barBtnTaoTK.Caption = "TẠO TÀI KHOẢN";
            this.barBtnTaoTK.Id = 1;
            this.barBtnTaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTK.ImageOptions.Image")));
            this.barBtnTaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTK.ImageOptions.LargeImage")));
            this.barBtnTaoTK.Name = "barBtnTaoTK";
            this.barBtnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaoTK_ItemClick);
            // 
            // barBtnGV
            // 
            this.barBtnGV.Caption = "GIẢNG VIÊN";
            this.barBtnGV.Id = 2;
            this.barBtnGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGV.ImageOptions.Image")));
            this.barBtnGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGV.ImageOptions.LargeImage")));
            this.barBtnGV.Name = "barBtnGV";
            this.barBtnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGV_ItemClick);
            // 
            // barBtnSV
            // 
            this.barBtnSV.Caption = "SINH VIÊN";
            this.barBtnSV.Id = 3;
            this.barBtnSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSV.ImageOptions.Image")));
            this.barBtnSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSV.ImageOptions.LargeImage")));
            this.barBtnSV.Name = "barBtnSV";
            this.barBtnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSV_ItemClick);
            // 
            // barBtnMH
            // 
            this.barBtnMH.Caption = "MÔN HỌC";
            this.barBtnMH.Id = 4;
            this.barBtnMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnMH.ImageOptions.Image")));
            this.barBtnMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnMH.ImageOptions.LargeImage")));
            this.barBtnMH.Name = "barBtnMH";
            this.barBtnMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMH_ItemClick);
            // 
            // btnBD
            // 
            this.btnBD.Caption = "BỘ ĐỀ";
            this.btnBD.Id = 5;
            this.btnBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.btnBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.btnBD.Name = "btnBD";
            this.btnBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBD_ItemClick);
            // 
            // btnDKT
            // 
            this.btnDKT.Caption = "ĐĂNG KÝ THI";
            this.btnDKT.Id = 6;
            this.btnDKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.btnDKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.btnDKT.Name = "btnDKT";
            // 
            // btnThi
            // 
            this.btnThi.Caption = "THI";
            this.btnThi.Id = 7;
            this.btnThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.btnThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.btnThi.Name = "btnThi";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "BẢNG ĐIỂM";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "ĐĂNG XUẤT";
            this.barBtnDangXuat.Id = 9;
            this.barBtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.Image")));
            this.barBtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.LargeImage")));
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            this.barBtnDangXuat.VisibleInSearchMenu = false;
            this.barBtnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barBtnKHOA
            // 
            this.barBtnKHOA.Caption = "KHOA";
            this.barBtnKHOA.Id = 10;
            this.barBtnKHOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnKHOA.ImageOptions.Image")));
            this.barBtnKHOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKHOA.ImageOptions.LargeImage")));
            this.barBtnKHOA.Name = "barBtnKHOA";
            this.barBtnKHOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKHOA_ItemClick);
            // 
            // barBtnDX
            // 
            this.barBtnDX.Caption = "ĐĂNG XUẤT";
            this.barBtnDX.Id = 11;
            this.barBtnDX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDX.ImageOptions.Image")));
            this.barBtnDX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDX.ImageOptions.LargeImage")));
            this.barBtnDX.Name = "barBtnDX";
            this.barBtnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDX_ItemClick);
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.btnTaoTK,
            this.btnGV,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "HỆ THỐNG";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.ItemLinks.Add(this.barBtnTaoTK);
            this.btnTaoTK.Name = "btnTaoTK";
            // 
            // btnGV
            // 
            this.btnGV.ItemLinks.Add(this.barBtnGV);
            this.btnGV.Name = "btnGV";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnSV);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnMH);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnKHOA);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.rbDX});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BỘ ĐỀ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBD);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDKT);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // rbDX
            // 
            this.rbDX.ItemLinks.Add(this.barBtnDX);
            this.rbDX.Name = "rbDX";
            this.rbDX.Visible = false;
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaSo,
            this.Ten,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaSo
            // 
            this.MaSo.Name = "MaSo";
            this.MaSo.Size = new System.Drawing.Size(30, 17);
            this.MaSo.Text = "Mã: ";
            // 
            // Ten
            // 
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(31, 17);
            this.Ten.Text = "Tên: ";
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(47, 17);
            this.Nhom.Text = "Nhóm: ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormChinh";
            this.Ribbon = this.ribbon;
            this.Text = "QUẢN LÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChinh_FormClosing);
            this.Load += new System.EventHandler(this.FormChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barBtnGV;
        private DevExpress.XtraBars.BarButtonItem barBtnSV;
        private DevExpress.XtraBars.BarButtonItem barBtnMH;
        private DevExpress.XtraBars.BarButtonItem btnBD;
        private DevExpress.XtraBars.BarButtonItem btnDKT;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MaSo;
        private System.Windows.Forms.ToolStripStatusLabel Ten;
        private System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnKHOA;
        private DevExpress.XtraBars.BarButtonItem barBtnDX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDX;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}