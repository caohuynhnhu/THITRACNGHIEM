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
    public partial class FormGiangVien : DevExpress.XtraEditors.XtraForm
    {
        public FormGiangVien()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.AddNew();
            gbGV.Enabled = true;
            btnOk.Visible = btnHuy.Visible = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
            //txtMAGV.Focus();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEM.GV_DAY' table. You can move, or remove it, as needed.
            this.gV_DAYTableAdapter.Fill(this.tRACNGHIEM.GV_DAY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.CAUHOI' table. You can move, or remove it, as needed.
            this.giangvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.tRACNGHIEM.CAUHOI);
            // TODO: This line of code loads data into the 'dSMK.V_LAYMAKHOA' table. You can move, or remove it, as needed.
            this.v_LAYMAKHOATableAdapter.Fill(this.dSMK.V_LAYMAKHOA);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPM);
            // TODO: This line of code loads data into the 'tRACNGHIEM.GIANGVIEN' table. You can move, or remove it, as needed.
            this.giangvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangvienTableAdapter.Fill(this.tRACNGHIEM.GIANGVIEN);
            /*if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
                btnThoat.Enabled = true;
            }

            if (Program.mGroup == "GIANGVIEN")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
                btnThoat.Enabled = true;
            }*/
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!");
                txtMAGV.Focus();
            }
            else if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ giảng viên không được để trống!");
                txtHO.Focus();
            }
            else if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên giảng viên không được để trống!");
                txtTEN.Focus();
            }
            else if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                txtDC.Focus();
            }
            else if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                txtMAKH.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAGV]" +
                        "@MAGV = N'" + txtMAGV.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại. Hãy nhập lại.");
                    txtMAGV.Focus();
                }
                else
                {
                    this.bdsGV.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsGV.ResetCurrentItem();
                    this.giangvienTableAdapter.Update(this.tRACNGHIEM.GIANGVIEN);
                    btnOk.Visible = btnHuy.Visible = false;
                    gbGV.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = btnThoat.Enabled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bdsGV.RemoveCurrent();
            bdsGV.EndEdit();
            gbGV.Enabled = false;
            btnOk.Visible = btnHuy.Visible = false;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = giangvienGridControl.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDAY.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên đã giảng dạy!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCH.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên đã lập câu hỏi!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa giảng viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGV.RemoveCurrent();

                    this.giangvienTableAdapter.Update(this.tRACNGHIEM.GIANGVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbGV.Enabled = btnLuu.Enabled = true;
            btnHuySua.Visible = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = giangvienGridControl.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                gbGV.Enabled = false;
                btnHuySua.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = giangvienGridControl.Enabled = true;
                this.giangvienTableAdapter.Update(this.tRACNGHIEM.GIANGVIEN);
                this.giangvienTableAdapter.Fill(this.tRACNGHIEM.GIANGVIEN);
                MessageBox.Show("Cập nhật giảng viên thành công!", "Notification", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên\n" + ex.Message, "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            bdsGV.EndEdit();
            gbGV.Enabled = false;
            btnHuySua.Visible = false;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled 
                = btnLoad.Enabled = btnLuu.Enabled = giangvienGridControl.Enabled = true;
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.giangvienTableAdapter.Fill(this.tRACNGHIEM.GIANGVIEN);
                bdsGV.CancelEdit();
                gbGV.Enabled = false;
                btnHuySua.Visible = btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = giangvienGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}