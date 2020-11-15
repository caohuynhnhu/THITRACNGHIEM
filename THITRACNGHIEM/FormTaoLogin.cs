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
using System.Data.SqlClient;

namespace THITRACNGHIEM
{
    public partial class FormTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private static DataTable dsMAGV;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cmbNQ.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm quyên không được để trống. Kiểm tra lại !!!", "Thông báo");
            }
            else if (cmbMAGV.Text.Trim() == "")
            {
                if (Program.mGroup == "PGV")
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên cần tạo tài khoản !!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn giảng viên cần tạo tài khoản !!!", "Thông báo");
                }
            }
            else if (txtDN.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtDN.Focus();
            }
            else if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtMK.Focus();
            }
            else if (txtXNMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtXNMK.Focus();
            }
            else if (txtMK.Text.Trim().Equals(txtXNMK.Text.Trim()) == false)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau. Kiểm tra lại !!!", "Thông báo");
            }
            else
            {
                if (Program.ketNoi() == 0)
                {
                    return;
                }
                SqlDataReader myReader1;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_TAOLOGIN]"
                    + "@LGNAME = N'" + txtDN.Text.Trim() + "',"
                    + "@PASS = N'" + txtMK.Text.Trim() + "',"
                    + "@USERNAME = N'" + cmbMAGV.SelectedValue.ToString().Trim() + "',"
                    + "@ROLE = N'" + cmbNQ.Text.ToString().Trim() + "'"
                    + "SELECT  'Return Value' = @return_value";

                myReader1 = Program.ExecSqlDataReader(strlenh);

                if (myReader1 == null) return;

                myReader1.Read();
                int value = myReader1.GetInt32(0);

                myReader1.Close();
                if (value == 1 || value == 2)
                {
                    MessageBox.Show("UserName bị trùng.");
                    return;
                }
                else if (value == 0)
                {
                    MessageBox.Show("Tạo thành công!");
                    txtDN.Text = txtMK.Text = txtXNMK.Text = "";
                    cmbMAGV.SelectedIndex = cmbNQ.SelectedIndex = -1;

                    if (Program.mGroup == "PGV")
                    {
                        dsMAGV = new DataTable();
                        dsMAGV = Program.ExecSqlDataTable("SELECT * FROM V_DSNVCHUACOLOGIN");
                        cmbMAGV.DataSource = dsMAGV;
                        cmbMAGV.DisplayMember = "TEN";
                        cmbMAGV.ValueMember = "MANV";
                        cmbMAGV.SelectedIndex = -1;
                        cmbNQ.SelectedIndex = -1;
                    }
                    else
                    {
                        dsMAGV = new DataTable();
                        dsMAGV = Program.ExecSqlDataTable("SELECT * FROM V_DSGVCHUACOLOGIN");
                        cmbMAGV.DataSource = dsMAGV;
                        cmbMAGV.DisplayMember = "TEN";
                        cmbMAGV.ValueMember = "MAGV";
                        cmbMAGV.SelectedIndex = -1;
                        cmbNQ.SelectedIndex = -1;
                    }
                }
            }
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            Program.ketNoi();
            if (Program.mGroup == "PGV")
            {
                lbTen.Text = "Mã nhân viên";
                cmbNQ.Items.Add("PGV");
                dsMAGV = new DataTable();
                dsMAGV = Program.ExecSqlDataTable("SELECT * FROM V_DSNVCHUACOLOGIN");
                cmbMAGV.DataSource = dsMAGV;
                cmbMAGV.DisplayMember = "TEN";
                cmbMAGV.ValueMember = "MANV";
                cmbMAGV.SelectedIndex = -1;
                cmbNQ.SelectedIndex = -1;

            }
            else
            {
                lbTen.Text = "Mã giảng viên";
                cmbNQ.Items.Add("KHOA");
                cmbNQ.Items.Add("GIANGVIEN");
                
                dsMAGV = new DataTable();
                dsMAGV = Program.ExecSqlDataTable("SELECT * FROM V_DSGVCHUACOLOGIN");
                cmbMAGV.DataSource = dsMAGV;
                cmbMAGV.DisplayMember = "TEN";
                cmbMAGV.ValueMember = "MAGV";
                cmbMAGV.SelectedIndex = -1;
                cmbNQ.SelectedIndex = -1;
            }
        }
    }
}