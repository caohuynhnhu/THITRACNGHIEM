namespace THITRACNGHIEM
{
    partial class FormLogin
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
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTenDN = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.radioBtnSV = new System.Windows.Forms.RadioButton();
            this.radioBtnGV = new System.Windows.Forms.RadioButton();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMK
            // 
            this.textBoxMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMK.Location = new System.Drawing.Point(185, 110);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.PasswordChar = '*';
            this.textBoxMK.Size = new System.Drawing.Size(228, 26);
            this.textBoxMK.TabIndex = 13;
            this.textBoxMK.Text = "123";
            // 
            // textBoxTenDN
            // 
            this.textBoxTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDN.Location = new System.Drawing.Point(185, 74);
            this.textBoxTenDN.Name = "textBoxTenDN";
            this.textBoxTenDN.Size = new System.Drawing.Size(228, 26);
            this.textBoxTenDN.TabIndex = 14;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(72, 113);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(71, 19);
            this.lbMK.TabIndex = 10;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDN.Location = new System.Drawing.Point(72, 74);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(106, 19);
            this.lbTenDN.TabIndex = 11;
            this.lbTenDN.Text = "Tên Đăng Nhập";
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoSo.Location = new System.Drawing.Point(72, 43);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(49, 19);
            this.lbCoSo.TabIndex = 12;
            this.lbCoSo.Text = "Cơ Sở";
            // 
            // radioBtnSV
            // 
            this.radioBtnSV.AutoSize = true;
            this.radioBtnSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSV.Location = new System.Drawing.Point(329, 161);
            this.radioBtnSV.Name = "radioBtnSV";
            this.radioBtnSV.Size = new System.Drawing.Size(84, 23);
            this.radioBtnSV.TabIndex = 8;
            this.radioBtnSV.TabStop = true;
            this.radioBtnSV.Text = "Sinh Viên";
            this.radioBtnSV.UseVisualStyleBackColor = true;
            this.radioBtnSV.CheckedChanged += new System.EventHandler(this.radioBtnSV_CheckedChanged);
            // 
            // radioBtnGV
            // 
            this.radioBtnGV.AutoSize = true;
            this.radioBtnGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnGV.Location = new System.Drawing.Point(185, 161);
            this.radioBtnGV.Name = "radioBtnGV";
            this.radioBtnGV.Size = new System.Drawing.Size(93, 23);
            this.radioBtnGV.TabIndex = 9;
            this.radioBtnGV.TabStop = true;
            this.radioBtnGV.Text = "Giảng Viên";
            this.radioBtnGV.UseVisualStyleBackColor = true;
            this.radioBtnGV.CheckedChanged += new System.EventHandler(this.radioBtnGV_CheckedChanged);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDN.Location = new System.Drawing.Point(185, 211);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(117, 33);
            this.btnDN.TabIndex = 7;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.Location = new System.Drawing.Point(308, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 33);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.v_DSPMBindingSource;
            this.cmbCoSo.DisplayMember = "description";
            this.cmbCoSo.DropDownHeight = 150;
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.IntegralHeight = false;
            this.cmbCoSo.Location = new System.Drawing.Point(185, 44);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(228, 21);
            this.cmbCoSo.TabIndex = 16;
            this.cmbCoSo.ValueMember = "subscriber_server";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.v_DSPMComboBox_SelectedIndexChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 343);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTenDN);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTenDN);
            this.Controls.Add(this.lbCoSo);
            this.Controls.Add(this.radioBtnSV);
            this.Controls.Add(this.radioBtnGV);
            this.Controls.Add(this.btnDN);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Enter += new System.EventHandler(this.FormLogin_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTenDN;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.RadioButton radioBtnSV;
        private System.Windows.Forms.RadioButton radioBtnGV;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCoSo;
    }
}

