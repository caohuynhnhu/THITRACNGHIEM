namespace THITRACNGHIEM
{
    partial class FormTaoLogin
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
            this.btnTao = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNQ = new System.Windows.Forms.ComboBox();
            this.cmbMAGV = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(345, 258);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(100, 35);
            this.btnTao.TabIndex = 0;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(474, 258);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMAGV);
            this.groupBox1.Controls.Add(this.cmbNQ);
            this.groupBox1.Controls.Add(this.txtDN);
            this.groupBox1.Controls.Add(this.txtXNMK);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(345, 102);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(224, 21);
            this.txtDN.TabIndex = 9;
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(345, 203);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.PasswordChar = '*';
            this.txtXNMK.Size = new System.Drawing.Size(224, 21);
            this.txtXNMK.TabIndex = 8;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(345, 155);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(224, 21);
            this.txtMK.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(215, 63);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(93, 19);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Mã giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhóm quyền";
            // 
            // cmbNQ
            // 
            this.cmbNQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNQ.FormattingEnabled = true;
            this.cmbNQ.Location = new System.Drawing.Point(345, 15);
            this.cmbNQ.Name = "cmbNQ";
            this.cmbNQ.Size = new System.Drawing.Size(224, 21);
            this.cmbNQ.TabIndex = 10;
            // 
            // cmbMAGV
            // 
            this.cmbMAGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAGV.FormattingEnabled = true;
            this.cmbMAGV.Location = new System.Drawing.Point(345, 61);
            this.cmbMAGV.Name = "cmbMAGV";
            this.cmbMAGV.Size = new System.Drawing.Size(224, 21);
            this.cmbMAGV.TabIndex = 11;
            // 
            // FormTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTaoLogin";
            this.Text = "Tạo Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTaoLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNQ;
        private System.Windows.Forms.ComboBox cmbMAGV;
    }
}