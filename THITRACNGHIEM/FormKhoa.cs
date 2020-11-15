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
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        Boolean checkButton = false;
        Boolean khoa = true;
        String macs = "";

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHOA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEM.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.tRACNGHIEM.GIANGVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'tRACNGHIEM.LOP' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEM.KHOA' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter.Fill(this.tRACNGHIEM.KHOA);
            macs = ((DataRowView)bdsKHOA[0])["MACS"].ToString();

            if (Program.mCoso == 0)
            {
                cmbCS.SelectedItem = cmbCS.Items[0];
            }
            else
            {
                cmbCS.SelectedItem = cmbCS.Items[1];
            }
            if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
                btnThoat.Enabled = true;
            }
            if (Program.mGroup == "KHOA")
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
            
        }

        private void btnHuyKHOA_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsKHOA.CancelEdit();
                
                gbKHOA.Enabled = false;
                btnOkKHOA.Visible = btnHuyKHOA.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = khoaGridControl.Enabled = true;
            }
            else
            {
                bdsKHOA.CancelEdit();
                gbKHOA.Enabled = false;
                btnHuyKHOA.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = khoaGridControl.Enabled = true;
            }
        }

        private void kHOAGridControl_Click(object sender, EventArgs e)
        {
            khoa = true;
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {
            khoa = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkButton = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
            if(khoa)
            {
                bdsKHOA.AddNew();
                gbKHOA.Enabled = txtMAKH.Enabled = true;
                khoaGridControl.Enabled = false;
                btnOkKHOA.Visible = btnHuyKHOA.Visible = true;
                txtMACS.Text = macs;
                txtMACS.Enabled = false;
            }
            else
            {
                bdsLOP.AddNew();
                gbLOP.Enabled = txtMALOP.Enabled = true;
                gbKHOA.Enabled = false;
                txtMAKH1.Text = txtMAKH.Text;
                lopGridControl.Enabled = txtMAKH1.Enabled = false;
                btnOkLOP.Visible = btnHuyLOP.Visible = true;
            }                
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (khoa)
            {
                if (bdsLOP.Count > 0)
                {
                    MessageBox.Show("Không thể xóa khoa đã có lớp!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsGV.Count > 0)
                {
                    MessageBox.Show("Không thể xóa khoa đã có giáo viên!", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thực sự muốn xóa khoa này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsKHOA.RemoveCurrent();

                        this.khoaTableAdapter.Update(this.tRACNGHIEM.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (khoa)
            {
                gbKHOA.Enabled = btnLuu.Enabled = true;
                btnHuyKHOA.Visible = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = khoaGridControl.Enabled = txtMACS.Enabled = txtMAKH.Enabled = false;
                checkButton = false;
            }
            else
            {
                gbLOP.Enabled = btnLuu.Enabled = true;
                btnHuyLOP.Visible = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = lopGridControl.Enabled = txtMALOP.Enabled = txtMAKH1.Enabled = false;
                checkButton = false;
            }

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(khoa)
            {
                try
                {
                    bdsKHOA.EndEdit();
                    bdsKHOA.ResetCurrentItem();
                    gbKHOA.Enabled = false;
                    btnHuyKHOA.Visible = false;
                    btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                        = btnLoad.Enabled = btnLuu.Enabled = khoaGridControl.Enabled = true;
                    this.khoaTableAdapter.Update(this.tRACNGHIEM.KHOA);
                    this.khoaTableAdapter.Fill(this.tRACNGHIEM.KHOA);
                    MessageBox.Show("Cập nhật khoa thành công!", "Notification", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    gbLOP.Enabled = false;
                    btnHuyLOP.Visible = false;
                    btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                        = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled = true;
                    this.lopTableAdapter.Update(this.tRACNGHIEM.LOP);
                    this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
                    MessageBox.Show("Cập nhật lớp thành công!", "Notification", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                }
            }
            
        }

        private void btnHuyLOP_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsLOP.CancelEdit();
                gbLOP.Enabled = false;
                btnOkLOP.Visible = btnHuyLOP.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled = true;
            }
            else
            {
                bdsLOP.CancelEdit();
                gbLOP.Enabled = false;
                btnHuyLOP.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled = true;
            }
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoaTableAdapter.Fill(this.tRACNGHIEM.KHOA);
                this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
                bdsKHOA.CancelEdit();
                gbKHOA.Enabled = false;
                bdsLOP.CancelEdit();
                gbLOP.Enabled = false;
                btnOkKHOA.Visible = btnHuyKHOA.Visible = false;
                btnOkLOP.Visible = btnHuyLOP.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = khoaGridControl.Enabled =
                    khoaGridControl.Enabled = true;      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnOkKHOA_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                txtMAKH.Focus();
            }
            else if (txtTENKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được để trống!");
                txtTENKH.Focus();
            }
            else if (txtMACS.Text.Trim() == "")
            {
                MessageBox.Show("Mã cơ sở không được để trống!");
                txtMACS.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAMK]" +
                        "@MAKH = N'" + txtMAKH.Text + "'," + "@TENKH = N'" + txtTENKH.Text + "' SELECT  'Return Value' = @return_value";
                
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã khoa đã tồn tại. Hãy nhập lại.");
                    txtMAKH.Focus();
                }
                else if (value1 == 2)
                {
                    MessageBox.Show("Tên khoa đã tồn tại. Hãy nhập lại.");
                    txtTENKH.Focus();
                }
                else
                {
                    this.bdsKHOA.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsKHOA.ResetCurrentItem();
                    this.khoaTableAdapter.Update(this.tRACNGHIEM.KHOA);
                    btnOkKHOA.Visible = btnHuyKHOA.Visible = false;
                    gbKHOA.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled 
                        = btnLuu.Enabled = btnThoat.Enabled = khoaGridControl.Enabled =true;
                }
            }
        }

        private void btnOkLOP_Click(object sender, EventArgs e)
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                txtMALOP.Focus();
            }
            else if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!");
                txtTENLOP.Focus();
            }
            else if (txtMAKH1.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                txtMAKH1.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMALOP]" +
                        "@MALOP = N'" + txtMALOP.Text + "'," + "@TENLOP = N'" + txtTENLOP.Text + "' SELECT  'Return Value' = @return_value";

                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Hãy nhập lại.");
                    txtMALOP.Focus();
                }
                else if (value1 == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại. Hãy nhập lại.");
                    txtTENLOP.Focus();
                }
                else
                {
                    this.bdsLOP.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsLOP.ResetCurrentItem();
                    this.lopTableAdapter.Update(this.tRACNGHIEM.LOP);
                    btnOkLOP.Visible = btnHuyLOP.Visible = false;
                    gbLOP.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled
                        = btnLuu.Enabled = btnThoat.Enabled = lopGridControl.Enabled = true;
                }
            }
        }

        private void cmbCS_SelectedIndexChanged_1(object sender, EventArgs e)
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
                        this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoaTableAdapter.Fill(this.tRACNGHIEM.KHOA);
                        this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
                    }
                }
            }
        }
    }
}