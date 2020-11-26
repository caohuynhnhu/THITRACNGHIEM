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
using System.Globalization;

namespace THITRACNGHIEM
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public FormThi()
        {
            InitializeComponent();
        }

        String malop = "";
        String mamon = "";
        String td = "";
        int socau, thoigian;
        String ngayThi;
        Boolean mh = false;
        Boolean ngaythi = false;
        private void FormThi_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SINHVIEN")
            {
                dateNgayThi.Enabled = false;
                lbHT.Text = Program.mHoten;
                string strLenh = "EXEC THONGTINSV '" + Program.username + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                malop = lbML.Text = Program.myReader.GetString(0);
                lbTL.Text = Program.myReader.GetString(1);
                Program.myReader.Close();
                dateNgayThi.Text = DateTime.Now.ToShortDateString();
                
            }
            else
            {
                gbTT.Visible = false;
            }
            
        }

        private Boolean loadInfoThi()
        {
            mamon = cmbMM.SelectedValue.ToString();
            ngayThi = dateNgayThi.DateTime.Date.ToShortDateString();

            String sql = "EXEC THONGTINTHI '" + malop + "','" + mamon + "','" + ngayThi + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            td = lbTD.Text = Program.myReader.GetString(0);
            socau = Program.myReader.GetInt32(1);
            lbSC.Text = socau.ToString();
            thoigian = Program.myReader.GetInt32(2);
            lbTG.Text = thoigian.ToString();
            Program.myReader.Close();
            Program.conn.Close();

            return true;
        }

        private void cmbMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            mh = true;
        }

        private void cmbMM_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC @return_value = [dbo].[SP_MONTHICUASV] @MALOP = N'" + malop + "'");
            BindingSource bdsMaKhoa = new BindingSource();
            bdsMaKhoa.DataSource = dt;
            cmbMM.DataSource = bdsMaKhoa;
            cmbMM.DisplayMember = "MAMH";
            cmbMM.ValueMember = "MAMH";
            cmbMM.SelectedIndex = -1;
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            lbSC.Visible = lbSCText.Visible = lbTD.Visible =
                lbTDText.Visible = lbTG.Visible = lbTGText.Visible = true;
            loadInfoThi();
        }

     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}