using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnGV_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMK.Visible = lbMK.Visible = true;
            lbTenDN.Text = "Tên đăng nhập";
        }

        private void radioBtnSV_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMK.Visible = lbMK.Visible = false;
            lbTenDN.Text = "Mã sinh viên";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;
            Program.mCoso = cmbCoSo.SelectedIndex;
            radioBtnGV.Checked = true;
        }

        private void v_DSPMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue != null)
                Program.servername = cmbCoSo.SelectedValue.ToString();
                Program.mCoso = cmbCoSo.SelectedIndex;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (textBoxTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                textBoxTenDN.Focus();
                return;
            }
            String strlenh = "";
            SqlDataReader myReader;

            if (radioBtnGV.Checked)
            {
                if (textBoxTenDN.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                    textBoxMK.Focus();
                    return;
                }
                Program.login = textBoxTenDN.Text;
                Program.password = textBoxMK.Text;
            }
            else
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
                Program.login = textBoxTenDN.Text;
                Program.password = textBoxMK.Text;
                strlenh = "EXEC SP_CHECK_SV_TONTAI '" + textBoxTenDN.Text + "'";
                Program.ketNoi();
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null)
                {
                    MessageBox.Show("SV không tồn tại!");
                    return;
                }

            }

            if (Program.ketNoi() == 0) return;
            else
            {
                Program.loginDN = Program.login;
                Program.passwordDN = Program.password;
                Program.bds_dspm = this.v_DSPMBindingSource;
                
                strlenh = "EXEC SP_DANGNHAP_FULL '" + Program.login + "'";
                Program.mCoso = cmbCoSo.SelectedIndex;
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                Program.username = myReader.GetString(0);
                Program.mHoten = myReader.GetString(1);
                Program.mGroup = myReader.GetString(2);
                myReader.Close();
                Program.conn.Close();
                this.SetVisibleCore(false);

                if (radioBtnSV.Checked)
                {
                    Program.formsv = new FormSV();
                    Program.formsv.Activate();
                    Program.formsv.Show();
                }
                else
                {
                    Program.formmain = new FormChinh();
                    Program.formmain.Activate();
                    Program.formmain.Show();
                }
                this.Hide();
            }
        }

        private void FormLogin_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnDN;
        }
    }
}
