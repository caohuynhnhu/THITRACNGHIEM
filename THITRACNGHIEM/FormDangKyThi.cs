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
    public partial class FormDangKyThi : DevExpress.XtraEditors.XtraForm
    {
        public FormDangKyThi()
        {
            InitializeComponent();
        }

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEM);

        }

        private void FormDangKyThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.SP_LAYTRINHDO' table. You can move, or remove it, as needed.
            this.sP_LAYTRINHDOTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_LAYTRINHDO);
            // TODO: This line of code loads data into the 'tRACNGHIEM.LOP' table. You can move, or remove it, as needed.
            lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.tRACNGHIEM.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEM.MONHOC' table. You can move, or remove it, as needed.
            monhocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter.Fill(this.tRACNGHIEM.MONHOC);
            // TODO: This line of code loads data into the 'tRACNGHIEM.DANGKY' table. You can move, or remove it, as needed.
            dangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangkyTableAdapter.Fill(this.tRACNGHIEM.DANGKY);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDK.AddNew();
            txtMANV.Text = Program.username;
            gbDK.Enabled = true;
            txtMANV.Enabled = btnThem.Enabled = btnThoat.Enabled = btnLoad.Enabled = dangkyGridControl.Enabled = false;
            btnHuy.Visible = btnOk.Visible = true;
            cmbMH.SelectedIndex = cmbML.SelectedIndex = cmbTD.SelectedIndex = -1;
            datetimeNT.Value = DateTime.Today;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool checkExists()
        {
            string strLenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_DANGKYTHI]" +
                        "@MAMH = N'" + cmbMH.Text + "'," + "@MALOP = N'" + cmbML.Text + "' SELECT  'Return Value' = @return_value";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                return false;
            }
            else
                return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã môn học!", "", MessageBoxButtons.OK);
                cmbMH.Focus();
                return;
            }
            if (cmbML.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã lớp!", "", MessageBoxButtons.OK);
                cmbML.Focus();
                return;
            }
            if (datetimeNT.Value <= DateTime.Today)
            {
                MessageBox.Show("Ngày thi không hợp lệ, Vui lòng nhập lại!", "", MessageBoxButtons.OK);
                datetimeNT.Focus();
                return;
            }
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (cmbTD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn trình độ!", "", MessageBoxButtons.OK);
                cmbTD.Focus();
                return;
            }
            if (spinTG.Value > 60 || spinTG.Value < 10)
            {
                MessageBox.Show("Thời gian thi phải từ 15 đến 60 phút!", "", MessageBoxButtons.OK);
                spinTG.Focus();
                return;
            }
            if (spinSC.Value < 10 || spinSC.Value > 30)
            {
                MessageBox.Show("Số câu thi phải lớn hơn hoặc bằng 10 và nhỏ hơn hoặc bằng 30!", "", MessageBoxButtons.OK);
                spinSC.Focus();
                return;
            }
            if (!checkExists())
            {
                MessageBox.Show("Môn học " + cmbMH.Text.Trim() + " đã được đăng ký cho lớp " + cmbML.Text, "", MessageBoxButtons.OK);
                return;
            }
            
            try
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_CHECKSOLUONGCAUTHI]" +
                "@maMH = N'" + cmbMH.Text + "'," + "@trinhDo = N'" + cmbTD.Text  + "'," + "@soCauThi = '" + spinSC.Value + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int soCauCSGoc = myReader1.GetInt32(0);
                int soCauCSKhac = myReader1.GetInt32(1);
                int soCauThieu = myReader1.GetInt32(2);

                myReader1.Close();
                if (soCauCSGoc < spinSC.Value)
                {
                    if(soCauThieu == 0)
                    {
                        MessageBox.Show(soCauCSGoc + " câu được lấy trong bộ đề thuộc cơ sở " + Program.CoSo +", " + (spinSC.Value - soCauCSGoc) + " câu được lấy trong bộ đề thuộc cơ sở còn lại", "", MessageBoxButtons.OK);
                        bdsDK.EndEdit();
                        bdsDK.ResetCurrentItem();
                        this.dangkyTableAdapter.Update(this.tRACNGHIEM.DANGKY);
                        MessageBox.Show("Đăng ký thành công!", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Bộ đề thiếu " + soCauThieu + " câu hỏi thuộc trình độ này. Xin nhập thêm câu hỏi!", "", MessageBoxButtons.OK);
                        bdsDK.CancelEdit();
                    }
                }
                else
                {
                    MessageBox.Show("Số câu đăng ký được lấy trong bộ đề thuộc cơ sở " + Program.CoSo,"", MessageBoxButtons.OK);
                    bdsDK.EndEdit();
                    bdsDK.ResetCurrentItem();
                    this.dangkyTableAdapter.Update(this.tRACNGHIEM.DANGKY);
                    MessageBox.Show("Đăng ký thành công!", "", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnLoad.Enabled = btnThoat.Enabled = dangkyGridControl.Enabled = true;
            btnHuy.Visible = btnOk.Visible = false;
            gbDK.Enabled = false;
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dangkyTableAdapter.Fill(this.tRACNGHIEM.DANGKY);
                bdsDK.CancelEdit();
                gbDK.Enabled = false;
                btnOk.Visible = btnHuy.Visible = false;
                btnThoat.Enabled = btnThem.Enabled = btnLoad.Enabled = 
                dangkyGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bdsDK.CancelEdit();
            gbDK.Enabled = false;
            btnOk.Visible = btnHuy.Visible = false;
            btnThoat.Enabled = btnThem.Enabled = btnLoad.Enabled = dangkyGridControl.Enabled = true;
        }
    }
}