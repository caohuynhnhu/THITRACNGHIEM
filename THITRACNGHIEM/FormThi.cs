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
using System.Data.SqlClient;

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
        DateTime layNgayThi;
        List<CauHoi> listCauHoi = new List<CauHoi>();
        int index = 0;
        int soCauDung = 0;
        int soCauSai = 0;
        float diemThi = 0;
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
            String sql1 = "EXEC SP_LAYNGAYTHI '" + malop.Trim() + "','" + mamon.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(sql1);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            layNgayThi = Program.myReader.GetDateTime(0);
            Console.WriteLine(layNgayThi.ToString("MM/dd/yyyy"));
            Program.myReader.Close();
            Program.conn.Close();

            if (layNgayThi.CompareTo(DateTime.Today) != 0 ){
                MessageBox.Show("Hôm nay không phải ngày thi! Về đi!");
                cmbMM.Focus();
            }

            String sql = "EXEC THONGTINTHI '" + malop + "','" + mamon + "','" + ngayThi + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            td = lbTD.Text = Program.myReader.GetString(0);
            socau = Program.myReader.GetInt32(1);
            lbSC.Text = socau.ToString();
            thoigian = Program.myReader.GetInt32(2);
            lbTG.Text = thoigian.ToString() + " phút";
            Program.myReader.Close();
            Program.conn.Close();

            String sqllaycauhoi = "EXEC SP_LAYCAUHOI '" + malop.Trim() + "','" + mamon.Trim() + "','" + td.Trim() + "','" + socau + "'";
            Program.myReader = Program.ExecSqlDataReader(sqllaycauhoi);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            while (Program.myReader.Read())
            {
                CauHoi cauHoi = new CauHoi();
                cauHoi.noiDung =  Program.myReader["NOIDUNG"].ToString();
                cauHoi.maCauHoi = Program.myReader["MACH"].ToString();
                cauHoi.maTringDo = Program.myReader["MATRINHDO"].ToString();
                cauHoi.dapAn = Program.myReader["DAPAN"].ToString();
                
                listCauHoi.Add(cauHoi);
            }
            lbSoCau.Text = (index + 1).ToString();
            tblNoiDung.Text = listCauHoi[index].noiDung;

            Program.myReader.Close();
            
            for(int i =0;  i < listCauHoi.Count; i++)
            {
                CauHoi cauHoi = listCauHoi[i];
                cauHoi.listLuaChon = new List<LuaChonCauhoi>();
                String sqlLuaChon = "select * from LUACHON where mach = " + cauHoi.maCauHoi;
                SqlDataReader dataReader = Program.ExecSqlDataReader(sqlLuaChon);
                while (dataReader.Read())
                {
                    LuaChonCauhoi luaChonCauhoi = new LuaChonCauhoi();
                    luaChonCauhoi.maLc = dataReader["MALC"].ToString();
                    luaChonCauhoi.tenLc = dataReader["TENLC"].ToString();
                    luaChonCauhoi.noiDung = dataReader["NOIDUNG"].ToString();
                    luaChonCauhoi.maCauHoi = dataReader["MACH"].ToString();
                    cauHoi.listLuaChon.Add(luaChonCauhoi);
                }
                dataReader.Close();
            }
            lbA.Text = listCauHoi[index].listLuaChon[0].noiDung;
            lbB.Text = listCauHoi[index].listLuaChon[1].noiDung;
            lbC.Text = listCauHoi[index].listLuaChon[2].noiDung;
            lbD.Text = listCauHoi[index].listLuaChon[3].noiDung;
            btnFirst.Enabled = false;
            btnTruoc.Enabled = false;
            btnLast.Enabled = true;
            btnSau.Enabled = true;
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
            if(cmbMM.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn môn thi!");
                cmbMM.Focus();
            }
            else
            {
                lbSC.Visible = lbSCText.Visible = lbTD.Visible = labelTG.Visible = lbTimer.Visible =
                lbTDText.Visible = lbTG.Visible = lbTGText.Visible = btnNB.Visible = gbCH.Visible = true;
                btnThoat.Visible = cmbMM.Enabled = btnBD.Visible = false;
                loadInfoThi();
                timer1.Start();
            }
        }

        private int s = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == 0)
            {
                if (thoigian != 0)
                {
                    thoigian--;
                    s = 59;
                }
            }
            lbTimer.Text = thoigian.ToString() + " : " + s.ToString();
            if (thoigian == 0 && s == 0)
            {
                timer1.Stop(); 
                MessageBox.Show("Đã hết thời gian làm bài!", "Notification", MessageBoxButtons.OK);
                tinhDiem();
                if (Program.mGroup == "SINHVIEN")
                {
                    insertDiemSV();
                }
                btnNB.Visible = false;
                btnThoat.Visible = true;
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index < listCauHoi.Count)
            {
                btnTruoc.Enabled = true;
                btnFirst.Enabled = true;
                btnSau.Enabled = true;
                lbSoCau.Text = (index + 1).ToString();
                tblNoiDung.Text = listCauHoi[index].noiDung;
                lbA.Text = listCauHoi[index].listLuaChon[0].noiDung;
                lbB.Text = listCauHoi[index].listLuaChon[1].noiDung;
                lbC.Text = listCauHoi[index].listLuaChon[2].noiDung;
                lbD.Text = listCauHoi[index].listLuaChon[3].noiDung;
            } 
            else
            {
                btnSau.Enabled = false;
                btnLast.Enabled = false;
            }

            if (index == listCauHoi.Count - 1)
            {
                btnSau.Enabled = false;
                btnLast.Enabled = false;
            }

            if (listCauHoi[index].chonNgu == null || listCauHoi[index].chonNgu == "")
            {
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
            } else
            {
                checkDapan();
            }

        }

        public void checkDapan()
        {
            switch (listCauHoi[index].chonNgu)
            {
                case "A":
                    radioA.Checked = true;
                    radioB.Checked = false;
                    radioC.Checked = false;
                    radioD.Checked = false;
                    break;
                case "B":
                    radioA.Checked = false;
                    radioB.Checked = true;
                    radioC.Checked = false;
                    radioD.Checked = false;
                    break;
                case "C":
                    radioA.Checked = false;
                    radioB.Checked = false;
                    radioC.Checked = true;
                    radioD.Checked = false;
                    break;
                case "D":
                    radioA.Checked = false;
                    radioB.Checked = false;
                    radioC.Checked = false;
                    radioD.Checked = true;
                    break;
                default:
                    break;
            }
        }


        private void btnTruoc_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index >= 0)
            {
                btnSau.Enabled = true;
                btnLast.Enabled = true;
                btnTruoc.Enabled = true;
                lbSoCau.Text = (index + 1).ToString();
                tblNoiDung.Text = listCauHoi[index].noiDung;
                lbA.Text = listCauHoi[index].listLuaChon[0].noiDung;
                lbB.Text = listCauHoi[index].listLuaChon[1].noiDung;
                lbC.Text = listCauHoi[index].listLuaChon[2].noiDung;
                lbD.Text = listCauHoi[index].listLuaChon[3].noiDung;
            }
            else
            {
                btnTruoc.Enabled = false;
            }

            if (index == 0)
            {
                btnTruoc.Enabled = false;
                btnFirst.Enabled = false;
            }

            if (listCauHoi[index].chonNgu == null || listCauHoi[index].chonNgu == "")
            {
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
            }
            else
            {
                checkDapan();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = listCauHoi.Count - 1;
            btnSau.Enabled = false;
            btnLast.Enabled = false;
            btnTruoc.Enabled = true;
            btnFirst.Enabled = true;
            lbSoCau.Text = (index + 1).ToString();
            tblNoiDung.Text = listCauHoi[index].noiDung;
            lbA.Text = listCauHoi[index].listLuaChon[0].noiDung;
            lbB.Text = listCauHoi[index].listLuaChon[1].noiDung;
            lbC.Text = listCauHoi[index].listLuaChon[2].noiDung;
            lbD.Text = listCauHoi[index].listLuaChon[3].noiDung;

            if (listCauHoi[index].chonNgu == null || listCauHoi[index].chonNgu == "")
            {
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
            }
            else
            {
                checkDapan();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            btnSau.Enabled = true;
            btnLast.Enabled = true;
            btnTruoc.Enabled = false;
            btnFirst.Enabled = false;
            lbSoCau.Text = (index + 1).ToString();
            tblNoiDung.Text = listCauHoi[index].noiDung;
            lbA.Text = listCauHoi[index].listLuaChon[0].noiDung;
            lbB.Text = listCauHoi[index].listLuaChon[1].noiDung;
            lbC.Text = listCauHoi[index].listLuaChon[2].noiDung;
            lbD.Text = listCauHoi[index].listLuaChon[3].noiDung;

            if (listCauHoi[index].chonNgu == null || listCauHoi[index].chonNgu == "")
            {
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
            }
            else
            {
                checkDapan();
            }
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            listCauHoi[index].chonNgu = "A";
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            listCauHoi[index].chonNgu = "B";
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            listCauHoi[index].chonNgu = "C";
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            listCauHoi[index].chonNgu = "D";
        }

        private void btnNB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn nộp bài không?", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Stop();
                btnThoat.Visible = true;
                btnNB.Visible = false;
                tinhDiem();
                if(Program.mGroup == "SINHVIEN")
                {
                    insertDiemSV();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void insertDiemSV()
        {
            String sqlIDDK = "select IDDK from DANGKY where MAMH = '" + mamon.Trim() + "' and MALOP = '" + malop.Trim() + "' and NGAYTHI = '" + ngayThi + "'";
            SqlDataReader dataReaderIDDK = Program.ExecSqlDataReader(sqlIDDK);
            dataReaderIDDK.Read();
            int iddk = dataReaderIDDK.GetInt32(0);
            dataReaderIDDK.Close();


            String sqlInsetThi = "INSERT INTO THI(MASV, IDDK, DIEM) VALUES('" + Program.username + "', " + iddk + ", " + diemThi + ")";
            SqlDataReader dataReaderInsertThi = Program.ExecSqlDataReader(sqlInsetThi);
            dataReaderInsertThi.Read();
            dataReaderInsertThi.Close();

            String sqlIDTHI = "select IDTHI from THI where MASV = '" + Program.username + "' and IDDK = " + iddk;
            SqlDataReader dataReaderIdthi = Program.ExecSqlDataReader(sqlIDTHI);
            dataReaderIdthi.Read();
            int idthi = dataReaderIdthi.GetInt32(0);
            dataReaderIdthi.Close();

            for (int i = 0; i < listCauHoi.Count; i++)
            {
                CauHoi cauHoi = listCauHoi[i];
                String sqlIDLBT = "select IDLBT from LAYBAITHI where IDDK = " + iddk + " and MACH = " + cauHoi.maCauHoi;
                SqlDataReader dataReaderIdlbt = Program.ExecSqlDataReader(sqlIDLBT);
                dataReaderIdlbt.Read();
                int idlbt = dataReaderIdlbt.GetInt32(0);
                dataReaderIdlbt.Close();

                String sqlInsetCTThi = "INSERT INTO CTBAITHI(IDTHI, IDLBT, CAUTRALOI) VALUES(" + idthi + "," + idlbt + ", '" + cauHoi.chonNgu + "')";
                SqlDataReader dataReaderInsertCTThi = Program.ExecSqlDataReader(sqlInsetCTThi);
                dataReaderInsertCTThi.Close();
            }
        }

        public void tinhDiem()
        {
            for (int i = 0; i < listCauHoi.Count; i++)
            {
                CauHoi cauhoi = listCauHoi[i];
                if (cauhoi.chonNgu == cauhoi.dapAn)
                {
                    soCauDung = soCauDung + 1;
                }
                else
                {
                    soCauSai++;
                }

            }
            diemThi = (float)Math.Round((double)(10 * soCauDung) / listCauHoi.Count, 2);
            MessageBox.Show("So cau dung : " + diemThi, "Notification", MessageBoxButtons.OK);
        }

    }

}
public class CauHoi
{
    public String maCauHoi { get; set; }
    public String maTringDo { get; set; }
    public String noiDung { get; set; }
    public String dapAn { get; set; }
    public String chonNgu { get; set; }
    public List<LuaChonCauhoi> listLuaChon { get; set; }
}

public class LuaChonCauhoi
{
    public String maCauHoi { get; set; }
    public String tenLc { get; set; }
    public String maLc { get; set; }
    public String noiDung { get; set; }
}