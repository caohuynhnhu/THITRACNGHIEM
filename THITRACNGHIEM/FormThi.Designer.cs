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
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbML = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTT.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gbTT.Text = "Thông tin sinh viên";
            // 
            // gbDK
            // 
            this.gbDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDK.Location = new System.Drawing.Point(263, 3);
            this.gbDK.Name = "gbDK";
            this.gbDK.Size = new System.Drawing.Size(602, 141);
            this.gbDK.TabIndex = 1;
            this.gbDK.TabStop = false;
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
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(9, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(62, 19);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên lớp: ";
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
            // lbML
            // 
            this.lbML.AutoSize = true;
            this.lbML.Location = new System.Drawing.Point(90, 40);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(46, 19);
            this.lbML.TabIndex = 3;
            this.lbML.Text = "malop";
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
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(90, 109);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(42, 19);
            this.lbHT.TabIndex = 5;
            this.lbHT.Text = "hoten";
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
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(429, 17);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(90, 33);
            this.btnBD.TabIndex = 2;
            this.btnBD.Text = "Bắt đầu";
            this.btnBD.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}