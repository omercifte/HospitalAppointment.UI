namespace HospitalAppointment.UI.Forms
{
    partial class DoctorAddForm
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
            groupBox1 = new GroupBox();
            cmbBranch = new ComboBox();
            btnKaydet = new Button();
            label3 = new Label();
            txtDoctorSurname = new TextBox();
            txtDoctorName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbBranch);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDoctorSurname);
            groupBox1.Controls.Add(txtDoctorName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F);
            groupBox1.Location = new Point(45, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 340);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Ekle";
            // 
            // cmbBranch
            // 
            cmbBranch.Font = new Font("Segoe UI", 13.8F);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(127, 215);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(370, 39);
            cmbBranch.TabIndex = 15;
            cmbBranch.SelectedIndexChanged += cmbBranch_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F);
            btnKaydet.Location = new Point(313, 270);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(184, 45);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(17, 223);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 13;
            label3.Text = "Branş";
            // 
            // txtDoctorSurname
            // 
            txtDoctorSurname.Font = new Font("Segoe UI", 13.8F);
            txtDoctorSurname.Location = new Point(127, 132);
            txtDoctorSurname.Name = "txtDoctorSurname";
            txtDoctorSurname.Size = new Size(370, 38);
            txtDoctorSurname.TabIndex = 12;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Font = new Font("Segoe UI", 13.8F);
            txtDoctorName.Location = new Point(127, 46);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(370, 38);
            txtDoctorName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(17, 135);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 10;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(43, 31);
            label1.TabIndex = 9;
            label1.Text = "Ad";
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(731, 432);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorAddForm";
            Text = "DoctorAddForm";
            Load += DoctorAddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbBranch;
        private Button btnKaydet;
        private Label label3;
        private TextBox txtDoctorSurname;
        private TextBox txtDoctorName;
        private Label label2;
        private Label label1;
    }
}