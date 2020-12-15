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
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class FormXemKetQua : DevExpress.XtraEditors.XtraForm
    {
        public FormXemKetQua()
        {
            InitializeComponent();
        }

        String malop;
        private void cmbMon_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC @return_value = [dbo].[SP_MONSVDATHI] @MASV = N'" + Program.username + "'");
            BindingSource bdsMaMon = new BindingSource();
            bdsMaMon.DataSource = dt;
            cmbMon.DataSource = bdsMaMon;
            cmbMon.DisplayMember = "TENMH";
            cmbMon.ValueMember = "MAMH";
            cmbMon.SelectedIndex = -1;
        }

        private void cmbTrinhDo_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecSqlDataTable("select * from TRINHDO");
            BindingSource bdsTD = new BindingSource();
            bdsTD.DataSource = dt;
            cmbTrinhDo.DataSource = bdsTD;
            cmbTrinhDo.DisplayMember = "TENTRINHDO";
            cmbTrinhDo.ValueMember = "MATRINHDO";
            cmbTrinhDo.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            XtraRptXemKetQua rpt = new XtraRptXemKetQua(Program.username, cmbMon.Text, malop, cmbTrinhDo.Text);
            //rpt.lbLop.Text = malop;
            //rpt.lbHoTen.Text = Program.mHoten;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void FormXemKetQua_Load(object sender, EventArgs e)
        {
            lbHT.Text = Program.mHoten;
            string strLenh = "EXEC THONGTINSV '" + Program.username + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            malop = Program.myReader.GetString(0);
            lbTenLop.Text = Program.myReader.GetString(1);
            Program.myReader.Close();
        }
    }
}