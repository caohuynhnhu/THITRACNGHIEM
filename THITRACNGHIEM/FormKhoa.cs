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
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHOA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'tRACNGHIEM.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.tRACNGHIEM.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEM.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.tRACNGHIEM.KHOA);
            if (Program.mCoso == 0)
            {
                cmbCS.SelectedItem = cmbCS.Items[0];
            }
            else
            {
                cmbCS.SelectedItem = cmbCS.Items[1];
            }
            if (Program.mGroup == "KHOA     ")
            {
                cmbCS.Enabled = false;
            }

        }

        private void kHOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHOA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

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
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Fill(this.tRACNGHIEM.KHOA);
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.tRACNGHIEM.LOP);
                    }
                }
            }
        }


    }
}