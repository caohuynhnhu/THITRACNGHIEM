namespace THITRACNGHIEM
{
    partial class FormThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.lbML = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.lbTG = new System.Windows.Forms.Label();
            this.lbSC = new System.Windows.Forms.Label();
            this.lbTD = new System.Windows.Forms.Label();
            this.lbTGText = new System.Windows.Forms.Label();
            this.lbSCText = new System.Windows.Forms.Label();
            this.lbTDText = new System.Windows.Forms.Label();
            this.dateNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmbMM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.sPMONTHICUASVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_MONTHICUASVTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.SP_MONTHICUASVTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTT.SuspendLayout();
            this.gbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMONTHICUASVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.gbTT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDK, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.lbHT);
            this.gbTT.Controls.Add(this.lbTL);
            this.gbTT.Controls.Add(this.lbML);
            this.gbTT.Controls.Add(this.lbHoTen);
            this.gbTT.Controls.Add(this.lbTen);
            this.gbTT.Controls.Add(this.lbMa);
            this.gbTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTT.Location = new System.Drawing.Point(3, 3);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(254, 141);
            this.gbTT.TabIndex = 0;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin:";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(90, 109);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(42, 19);
            this.lbHT.TabIndex = 5;
            this.lbHT.Text = "hoten";
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.Location = new System.Drawing.Point(90, 76);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(46, 19);
            this.lbTL.TabIndex = 4;
            this.lbTL.Text = "tenlop";
            // 
            // lbML
            // 
            this.lbML.AutoSize = true;
            this.lbML.Location = new System.Drawing.Point(90, 40);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(46, 19);
            this.lbML.TabIndex = 3;
            this.lbML.Text = "malop";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(12, 109);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 19);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ tên: ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(9, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(62, 19);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên lớp: ";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(9, 40);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(60, 19);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã lớp: ";
            // 
            // gbDK
            // 
            this.gbDK.Controls.Add(this.lbTG);
            this.gbDK.Controls.Add(this.lbSC);
            this.gbDK.Controls.Add(this.lbTD);
            this.gbDK.Controls.Add(this.lbTGText);
            this.gbDK.Controls.Add(this.lbSCText);
            this.gbDK.Controls.Add(this.lbTDText);
            this.gbDK.Controls.Add(this.dateNgayThi);
            this.gbDK.Controls.Add(this.cmbMM);
            this.gbDK.Controls.Add(this.label2);
            this.gbDK.Controls.Add(this.label1);
            this.gbDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDK.Location = new System.Drawing.Point(263, 3);
            this.gbDK.Name = "gbDK";
            this.gbDK.Size = new System.Drawing.Size(602, 141);
            this.gbDK.TabIndex = 1;
            this.gbDK.TabStop = false;
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTG.Location = new System.Drawing.Point(358, 61);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(45, 19);
            this.lbTG.TabIndex = 9;
            this.lbTG.Text = "label9";
            this.lbTG.Visible = false;
            // 
            // lbSC
            // 
            this.lbSC.AutoSize = true;
            this.lbSC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSC.Location = new System.Drawing.Point(358, 17);
            this.lbSC.Name = "lbSC";
            this.lbSC.Size = new System.Drawing.Size(45, 19);
            this.lbSC.TabIndex = 8;
            this.lbSC.Text = "label8";
            this.lbSC.Visible = false;
            // 
            // lbTD
            // 
            this.lbTD.AutoSize = true;
            this.lbTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTD.Location = new System.Drawing.Point(520, 17);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(45, 19);
            this.lbTD.TabIndex = 7;
            this.lbTD.Text = "label7";
            this.lbTD.Visible = false;
            // 
            // lbTGText
            // 
            this.lbTGText.AutoSize = true;
            this.lbTGText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGText.Location = new System.Drawing.Point(282, 61);
            this.lbTGText.Name = "lbTGText";
            this.lbTGText.Size = new System.Drawing.Size(67, 19);
            this.lbTGText.TabIndex = 6;
            this.lbTGText.Text = "Thời gian:";
            this.lbTGText.Visible = false;
            // 
            // lbSCText
            // 
            this.lbSCText.AutoSize = true;
            this.lbSCText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSCText.Location = new System.Drawing.Point(282, 17);
            this.lbSCText.Name = "lbSCText";
            this.lbSCText.Size = new System.Drawing.Size(54, 19);
            this.lbSCText.TabIndex = 5;
            this.lbSCText.Text = "Số câu:";
            this.lbSCText.Visible = false;
            // 
            // lbTDText
            // 
            this.lbTDText.AutoSize = true;
            this.lbTDText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDText.Location = new System.Drawing.Point(452, 17);
            this.lbTDText.Name = "lbTDText";
            this.lbTDText.Size = new System.Drawing.Size(62, 19);
            this.lbTDText.TabIndex = 4;
            this.lbTDText.Text = "Trình độ:";
            this.lbTDText.Visible = false;
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.EditValue = new System.DateTime(((long)(0)));
            this.dateNgayThi.Location = new System.Drawing.Point(103, 58);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.Properties.Appearance.Options.UseFont = true;
            this.dateNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThi.Size = new System.Drawing.Size(121, 26);
            this.dateNgayThi.TabIndex = 3;
            // 
            // cmbMM
            // 
            this.cmbMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMM.FormattingEnabled = true;
            this.cmbMM.Location = new System.Drawing.Point(103, 14);
            this.cmbMM.Name = "cmbMM";
            this.cmbMM.Size = new System.Drawing.Size(121, 27);
            this.cmbMM.TabIndex = 2;
            this.cmbMM.SelectedIndexChanged += new System.EventHandler(this.cmbMM_SelectedIndexChanged);
            this.cmbMM.Click += new System.EventHandler(this.cmbMM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNB);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnBD);
            this.groupBox1.Controls.Add(this.lbTimer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNB
            // 
            this.btnNB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNB.Location = new System.Drawing.Point(761, 17);
            this.btnNB.Name = "btnNB";
            this.btnNB.Size = new System.Drawing.Size(95, 33);
            this.btnNB.TabIndex = 4;
            this.btnNB.Text = "Nộp bài";
            this.btnNB.UseVisualStyleBackColor = true;
            this.btnNB.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(590, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(429, 17);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(90, 33);
            this.btnBD.TabIndex = 2;
            this.btnBD.Text = "Bắt đầu";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(102, 24);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(43, 19);
            this.lbTimer.TabIndex = 1;
            this.lbTimer.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian:";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMONTHICUASVBindingSource
            // 
            this.sPMONTHICUASVBindingSource.DataMember = "SP_MONTHICUASV";
            this.sPMONTHICUASVBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // sP_MONTHICUASVTableAdapter
            // 
            this.sP_MONTHICUASVTableAdapter.ClearBeforeFill = true;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormThi";
            this.Text = "THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.gbDK.ResumeLayout(false);
            this.gbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMONTHICUASVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.Label lbML;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox gbDK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTGText;
        private System.Windows.Forms.Label lbSCText;
        private System.Windows.Forms.Label lbTDText;
        private DevExpress.XtraEditors.DateEdit dateNgayThi;
        private System.Windows.Forms.ComboBox cmbMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Label lbSC;
        private System.Windows.Forms.Label lbTD;
        private System.Windows.Forms.BindingSource sPMONTHICUASVBindingSource;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private TRACNGHIEMDataSetTableAdapters.SP_MONTHICUASVTableAdapter sP_MONTHICUASVTableAdapter;
    }
}