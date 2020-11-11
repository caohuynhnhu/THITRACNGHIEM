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
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }
        Boolean checkButton = false;

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEM.GV_DAY' table. You can move, or remove it, as needed.
            this.gV_DAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gV_DAYTableAdapter.Fill(this.tRACNGHIEM.GV_DAY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.tRACNGHIEM.DANGKY);
            // TODO: This line of code loads data into the 'tRACNGHIEM.CAUHOI' table. You can move, or remove it, as needed.
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.tRACNGHIEM.CAUHOI);
            // TODO: This line of code loads data into the 'dSMK.V_LAYMAKHOA' table. You can move, or remove it, as needed.
            this.v_LAYMAKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_LAYMAKHOATableAdapter.Fill(this.dSMK.V_LAYMAKHOA);
            // TODO: This line of code loads data into the 'tRACNGHIEM.MONHOC' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter.Fill(this.tRACNGHIEM.MONHOC);
            if (Program.mGroup == "PGV      ")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
                btnThoat.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkButton = true;
            bdsMH.AddNew();
            gbMH.Enabled = txtMAMH.Enabled = true;
            btnOk.Visible = btnHuy.Visible = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled
                = btnLuu.Enabled = monhocGridControl.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            this.Close();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.monhocTableAdapter.Fill(this.tRACNGHIEM.MONHOC);
                bdsMH.CancelEdit();
                gbMH.Enabled = false;
                btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = monhocGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                gbMH.Enabled = false;
                btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = monhocGridControl.Enabled = true;
                this.monhocTableAdapter.Update(this.tRACNGHIEM.MONHOC);
                this.monhocTableAdapter.Fill(this.tRACNGHIEM.MONHOC);
                MessageBox.Show("Cập nhật môn học thành công!", "Notification", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học\n" + ex.Message, "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbMH.Enabled = btnLuu.Enabled = true;
            btnHuy.Visible = true;
            btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled
            = monhocGridControl.Enabled = txtMAMH.Enabled = txtMAKH.Enabled = false;
            checkButton = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsMH.CancelEdit();
                gbMH.Enabled = false;
                btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = monhocGridControl.Enabled = true;
            }
            else
            {
                if (btnLuu.Enabled == true)
                {
                    if (MessageBox.Show("Dữ liệu chưa được ghi!\n Bạn chắc chắn muốn hủy?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bdsMH.CancelEdit();
                        gbMH.Enabled = false;
                        btnHuy.Visible = false;
                        btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                            = btnLoad.Enabled = btnLuu.Enabled = monhocGridControl.Enabled = true;
                    }
                    else return;
                }
                else
                {
                    return;
                }
                    
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!");
                txtMAMH.Focus();
            }
            else if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!");
                txtTENMH.Focus();
            }
            else if (txtMAKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                txtMAKH.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAMH]" +
                "@MAMH = N'" + txtMAMH.Text + "'," + "@TENMH = N'" + txtTENMH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã môn học đã tồn tại. Hãy nhập lại.");
                    txtMAMH.Focus();
                }
                else if (value1 == 2)
                {
                    MessageBox.Show("Tên môn học đã tồn tại. Hãy nhập lại.");
                    txtTENMH.Focus();
                }
                else
                {
                    this.bdsMH.EndEdit();
                    MessageBox.Show("Thành công!");
                    bdsMH.ResetCurrentItem();
                    this.monhocTableAdapter.Update(this.tRACNGHIEM.MONHOC);
                    btnOk.Visible = btnHuy.Visible = false;
                    gbMH.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled 
                        = btnThoat.Enabled = monhocGridControl.Enabled = true;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCH.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã tạo câu hỏi!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã đăng ký thi!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGVD.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã đã có giảng viên dạy!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa môn học này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsMH.RemoveCurrent();

                    this.monhocTableAdapter.Update(this.tRACNGHIEM.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}