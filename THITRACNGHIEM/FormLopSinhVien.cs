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
using DevExpress.Utils.Extensions;
using System.Data.SqlClient;

namespace THITRACNGHIEM
{
    public partial class FormLopSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public FormLopSinhVien()
        {
            InitializeComponent();
        }

        Boolean checkButton = false;
        Boolean lop = true;
        
        
        private void FormLopSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEM.GV_DAY' table. You can move, or remove it, as needed.
            this.gvdayTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gvdayTableAdapter.Fill(this.tRACNGHIEM.GV_DAY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.DANGKY' table. You can move, or remove it, as needed.
            this.dangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangkyTableAdapter.Fill(this.tRACNGHIEM.DANGKY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.THI' table. You can move, or remove it, as needed.
            this.thiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thiTableAdapter.Fill(this.tRACNGHIEM.THI);
            // TODO: This line of code loads data into the 'tRACNGHIEM.SINHVIEN' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter.Fill(this.tRACNGHIEM.SINHVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEM.LOP' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            //this.v_DSPMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
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
                bdsLOP.Filter = "MAKH = '" + Program.mKhoa + "'";
                cmbCS.Enabled = false;
            }
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

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
                this.sinhvienTableAdapter.Fill(this.tRACNGHIEM.SINHVIEN);
                bdsLOP.CancelEdit();
                gbSV.Enabled = false;
                bdsSV.CancelEdit();
                gbLop.Enabled = false;
                btnOkLop.Visible = btnHuyLop.Visible = false;
                btnOkSV.Visible = btnHuySV.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled =
                    sinhvienGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lop)
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    gbLop.Enabled = false;
                    btnHuyLop.Visible = false;
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
            else
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    gbSV.Enabled = false;
                    btnHuySV.Visible = false;
                    btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                        = btnLoad.Enabled = btnLuu.Enabled = sinhvienGridControl.Enabled = true;
                    this.sinhvienTableAdapter.Update(this.tRACNGHIEM.SINHVIEN);
                    this.sinhvienTableAdapter.Fill(this.tRACNGHIEM.SINHVIEN);
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Notification", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkButton = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
            if (lop)
            {
                bdsLOP.AddNew();
                gbLop.Enabled = true;
                lopGridControl.Enabled = gbSV.Enabled = false;
                btnOkLop.Visible = btnHuyLop.Visible = true;
                txtMAKH.Text = Program.mKhoa;
                txtMAKH.Enabled = false;
            }
            else
            {
                bdsSV.AddNew();
                gbSV.Enabled = true;
                gbLop.Enabled = false;
                txtMALOP1.Text = txtMALOP.Text;
                sinhvienGridControl.Enabled = txtMALOP1.Enabled = false;
                btnOkSV.Visible = btnHuySV.Visible = true;
            }
        }

        private void lopGridControl_Click(object sender, EventArgs e)
        {
            lop = true;
        }

        private void sinhvienGridControl_Click(object sender, EventArgs e)
        {
            lop = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lop)
            {
                gbLop.Enabled = btnLuu.Enabled = true;
                btnHuyLop.Visible = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = lopGridControl.Enabled = txtMAKH.Enabled = txtMALOP.Enabled = false;
                checkButton = false;
            }
            else
            {
                gbSV.Enabled = btnLuu.Enabled = true;
                btnHuySV.Visible = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = sinhvienGridControl.Enabled = txtMALOP1.Enabled = txtMASV.Enabled = false;
                checkButton = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lop)
            {
                if (bdsSV.Count > 0)
                {
                    MessageBox.Show("Không thể xóa lớp đã có sinh viên!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsGVDAY.Count > 0)
                {
                    MessageBox.Show("Không thể xóa lớp đã có giảng viên dạy!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsDK.Count > 0)
                {
                    MessageBox.Show("Không thể xóa lớp đã đăng ký thi!", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thực sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsLOP.RemoveCurrent();

                        this.lopTableAdapter.Update(this.tRACNGHIEM.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa lớp!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                if (bdsThi.Count > 0)
                {
                    MessageBox.Show("Không thể xóa sinh viên đã làm bài thi!", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsSV.RemoveCurrent();
                        this.sinhvienTableAdapter.Update(this.tRACNGHIEM.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnOkLop_Click(object sender, EventArgs e)
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
            else if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                txtMAKH.Focus();
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
                    btnOkLop.Visible = btnHuyLop.Visible = false;
                    gbLop.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled
                        = btnLuu.Enabled = btnThoat.Enabled = lopGridControl.Enabled = true;
                }
            }
        }

        private void btnHuyLop_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsLOP.CancelEdit();
                gbLop.Enabled = false;
                btnOkLop.Visible = btnHuyLop.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled = true;
            }
            else
            {
                bdsLOP.CancelEdit();
                gbLop.Enabled = false;
                btnHuyLop.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = lopGridControl.Enabled = true;
            }
        }

        private void btnOkSV_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!");
                txtMASV.Focus();
            }
            else if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được để trống!");
                txtHO.Focus();
            }
            else if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được để trống!");
                txtTEN.Focus();
            }
            else if (txtNS.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được để trống!");
                txtNS.Focus();
            }
            else if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                txtDC.Focus();
            }
            else if (txtMALOP1.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                txtMALOP1.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMASV]" +
                        "@MASV = N'" + txtMASV.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Hãy nhập lại.");
                    txtMASV.Focus();
                }
                else
                {
                    this.bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    MessageBox.Show("Thành công!");
                    this.sinhvienTableAdapter.Update(this.tRACNGHIEM.SINHVIEN);
                    btnOkSV.Visible = btnHuySV.Visible = false;
                    gbSV.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled
                        = btnThoat.Enabled = sinhvienGridControl.Enabled = true;
                }
            }
        }

        private void btnHuySV_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsSV.CancelEdit();
                gbSV.Enabled = false;
                btnOkSV.Visible = btnHuySV.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = sinhvienGridControl.Enabled = true;
            }
            else
            {
                bdsSV.CancelEdit();
                gbSV.Enabled = false;
                btnHuySV.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = sinhvienGridControl.Enabled = true;
            }
        }
    }
}