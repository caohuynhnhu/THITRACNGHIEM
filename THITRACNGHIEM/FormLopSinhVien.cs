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
    public partial class FormLopSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public FormLopSinhVien()
        {
            InitializeComponent();
        }

        private void FormLopSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEM.GV_DAY' table. You can move, or remove it, as needed.
            this.gvdayTableAdapter.Fill(this.tRACNGHIEM.GV_DAY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.DANGKY' table. You can move, or remove it, as needed.
            this.dangkyTableAdapter.Fill(this.tRACNGHIEM.DANGKY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.THI' table. You can move, or remove it, as needed.
            this.thiTableAdapter.Fill(this.tRACNGHIEM.THI);
            // TODO: This line of code loads data into the 'tRACNGHIEM.SINHVIEN' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter.Fill(this.tRACNGHIEM.SINHVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEM.LOP' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);

        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCS.SelectedValue != null)
            {
                if (cmbCS.ValueMember != "")
                {
                    if (Program.servername != cmbCS.SelectedValue.ToString())
                    {
                        Program.servername = cmbCS.SelectedValue.ToString();
                    }
                    if (cmbCS.SelectedIndex != Program.mCoso)
                    {
                        Program.login = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    else
                    {
                        Program.login = Program.loginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.ketNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
                        this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sinhvienTableAdapter.Fill(this.tRACNGHIEM.SINHVIEN);
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}