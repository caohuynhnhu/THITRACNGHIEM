using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace THITRACNGHIEM
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void FormChinh_Load(object sender, EventArgs e)
        {
            MaSo.Text = "Mã số: " + Program.username;
            Ten.Text = "Họ tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
            if (Program.mGroup == "GIANGVIEN")
            {
                btnTaoTK.Visible = false;
                pageHeThong.Visible = pageBaoCao.Visible = false;
                rbDX.Visible = true;
            }
            if (Program.mGroup == "KHOA     ")
            {
                pageBaoCao.Visible = false;
                
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormLogin));
            if (form == null)
            {
                FormLogin f = new FormLogin();
                f.Show();
            }
            else form.Activate();
            this.Close();
        }

        private void barBtnGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormGiangVien));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                IsMdiContainer = true;
                Program.formgv = new FormGiangVien();
                Program.formgv.MdiParent = Program.formmain;
                Program.formgv.Activate();
                Program.formgv.Show();
            }
            
        }

        private void barBtnMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormMonHoc));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                IsMdiContainer = true;
                Program.formmh = new FormMonHoc();
                Program.formmh.MdiParent = Program.formmain;
                Program.formmh.Activate();
                Program.formmh.Show();
            }
        }

        private void barBtnKHOA_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormKhoa));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                IsMdiContainer = true;
                Program.formkh = new FormKhoa();
                Program.formkh.MdiParent = Program.formmain;
                Program.formkh.Activate();
                Program.formkh.Show();
            }
        }
    }
}