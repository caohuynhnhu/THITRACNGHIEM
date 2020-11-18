using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace THITRACNGHIEM
{
    public partial class FormSV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormSV()
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

        private void FormSV_Load(object sender, EventArgs e)
        {
            MaSV.Text = "Mã SV: " + Program.username;
            HoTen.Text = "Họ tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
        }

        private void btnDX_ItemClick(object sender, ItemClickEventArgs e)
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

        private void FormSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }

        private void btnThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormThi));
            if (form == null)
            {
                FormThi f = new FormThi();
                f.Show(); 
            }
            else form.Activate();
            
        }
    }
}