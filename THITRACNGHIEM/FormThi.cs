using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace THITRACNGHIEM
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public FormThi()
        {
            InitializeComponent();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            lbHT.Text = Program.mHoten;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}