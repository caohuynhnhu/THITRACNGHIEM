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
using System.Collections;

namespace THITRACNGHIEM
{
    public partial class FormBoDe : DevExpress.XtraEditors.XtraForm
    {
        public FormBoDe()
        {
            InitializeComponent();
        }

        Boolean checkButton = false;

        private void cAUHOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_LAYTRINHDO' table. You can move, or remove it, as needed.
            this.trinhdoTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_LAYTRINHDO);
            // TODO: This line of code loads data into the 'tRACNGHIEM.CAUHOI' table. You can move, or remove it, as needed.
            this.cauhoiTableAdapter.Fill(this.tRACNGHIEM.CAUHOI);
            
            if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = false;
                btnThoat.Enabled = true;
            }
            if (Program.mGroup == "KHOA")
            {
                btnThem.Enabled = btnXoa.Enabled =  false;
                btnThoat.Enabled = btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = true;
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsCH.Filter = "MAGV = '" + Program.username + "'";
                btnThem.Enabled = btnXoa.Enabled = btnLoad.Enabled = btnLuu.Enabled = btnThoat.Enabled = btnSua.Enabled = true;
            }
        }

        private void cmbMK_Click(object sender, EventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN")
            {
                DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC @return_value = [dbo].[SP_MON_GVDAY] @MAGV = N'" + Program.username + "'");
                BindingSource bdsMaKhoa = new BindingSource();
                bdsMaKhoa.DataSource = dt;
                cmbMH.DataSource = bdsMaKhoa;
                cmbMH.DisplayMember = "MAMH";
                cmbMH.ValueMember = "MAMH";
                cmbMH.SelectedIndex = -1;
            }
            if (Program.mGroup == "KHOA")
            {
                DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC @return_value = [dbo].[SP_MON_THUOC_KHOA] @MAMK = N'" + Program.mKhoa + "'");
                BindingSource bdsMH = new BindingSource();
                bdsMH.DataSource = dt;
                cmbMH.DataSource = bdsMH;
                cmbMH.DisplayMember = "MAMH";
                cmbMH.ValueMember = "MAMH";
                cmbMH.SelectedIndex = -1;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMH.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn môn để thêm câu hỏi!\n", "Notification", MessageBoxButtons.OK);
                return;
            }
            else
            {
                bdsCH.AddNew();
                gbCH.Enabled = true;
                checkButton = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = cmbMH.Enabled = false;
                string sp1 = "EXEC SP_LAY_MAX_MACH";
                Program.myReader = Program.ExecSqlDataReader(sp1);
                Program.myReader.Read();
                int mach = Program.myReader.GetInt32(0) + 1;
                String MaCH = Convert.ToString(mach);
                Program.myReader.Close();
                txtMACH.Text = MaCH;
                txtMAMH.Text = cmbMH.SelectedValue.ToString();
                txtMAGV.Text = Program.username;
                txtTD.SelectedIndex = -1;
                txtMACH.Enabled = txtMAGV.Enabled = txtMAMH.Enabled = false;
                cauhoiGridControl.Enabled = false;
                btnOk.Visible = btnHuy.Visible = true;
            }   
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsCH.Filter = "MAMH = '" + cmbMH.Text.Trim() + "'" + " And MAGV = '" + Program.username + "'";
            }
            else if(Program.mGroup == "KHOA")
            {
                bdsCH.Filter = "MAMH = '" + cmbMH.Text.Trim() + "'";
            }
                
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cauhoiTableAdapter.Fill(this.tRACNGHIEM.CAUHOI);
                bdsCH.CancelEdit();
                gbCH.Enabled = false;
                btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = cauhoiGridControl.Enabled = true;
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
                bdsCH.EndEdit();
                bdsCH.ResetCurrentItem();
                gbCH.Enabled = false;
                btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = cauhoiGridControl.Enabled = cmbMH.Enabled = true;
                this.cauhoiTableAdapter.Update(this.tRACNGHIEM.CAUHOI);
                this.cauhoiTableAdapter.Fill(this.tRACNGHIEM.CAUHOI);
                MessageBox.Show("Cập nhật bộ đề thành công!", "Notification", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề\n" + ex.Message, "Notification", MessageBoxButtons.OK);
            }
        }

        private String parseListToObj(Object listMH)
        {
            String result = "(";
            IList objList = (IList)listMH;
            foreach (var v in objList)
            {
                result = result + "'" + v.ToString() + "',";
            }
            result = result.Substring(0, result.LastIndexOf(",")) + ")";
            return result;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMH.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn môn để hiệu chỉnh câu hỏi!\n", "Notification", MessageBoxButtons.OK);
                return;
            }
            else
            {
                gbCH.Enabled = btnLuu.Enabled = true;
                btnHuy.Visible = true;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = cmbMH.Enabled = btnSua.Enabled
                = btnLoad.Enabled = cauhoiGridControl.Enabled = txtMAMH.Enabled = txtMAGV.Enabled = false;
                checkButton = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (checkButton)
            {
                bdsCH.CancelEdit();
                gbCH.Enabled = false;
                btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                = btnLoad.Enabled = btnLuu.Enabled = cauhoiGridControl.Enabled = cmbMH.Enabled = true;
            }
            else
            {
                bdsCH.CancelEdit();
                gbCH.Enabled = false;
                btnHuy.Visible = false;
                if (Program.mGroup == "GIANGVIEN")
                {
                    btnThoat.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled
                    = btnLoad.Enabled = btnLuu.Enabled = cauhoiGridControl.Enabled = cmbMH.Enabled = true;
                }
                else if (Program.mGroup == "KHOA")
                {
                    btnThoat.Enabled =  btnSua.Enabled = btnLoad.Enabled = btnLuu.Enabled = cauhoiGridControl.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMACH.Text.Trim() == "")
            {
                MessageBox.Show("Mã câu hỏi không được để trống!");
                txtMACH.Focus();
            }
            else if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!");
                txtMAMH.Focus();
            }
            else if (txtND.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung không được để trống!");
                txtND.Focus();
            }
            else if (txtDA.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án không được để trống!");
                txtDA.Focus();
            }
            else if (txtLCH.Text.Trim() == "")
            {
                MessageBox.Show("Loại câu hỏi không được để trống!");
                txtLCH.Focus();
            }
            else if (txtTD.Text.Trim() == "")
            {
                MessageBox.Show("Trình độ không được để trống!");
                txtTD.Focus();
            }
            else if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!");
                txtMAGV.Focus();
            }
            else
            {
                this.bdsCH.EndEdit();
                MessageBox.Show("Thành công!");
                bdsCH.ResetCurrentItem();
                this.cauhoiTableAdapter.Update(this.tRACNGHIEM.CAUHOI);
                btnOk.Visible = btnHuy.Visible = false;
                gbCH.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLoad.Enabled
                    = btnLuu.Enabled = btnThoat.Enabled = cauhoiGridControl.Enabled = cmbMH.Enabled = true;
            }
        }
    }
}