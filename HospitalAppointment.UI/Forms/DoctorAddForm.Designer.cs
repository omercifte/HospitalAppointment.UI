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
            label1 = new Label();
            label2 = new Label();
            txtDoctorName = new TextBox();
            txtDoctorSurname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnKaydet = new Button();
            cmbBranch = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 125);
            label1.Name = "label1";
            label1.Size = new Size(62, 46);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 214);
            label2.Name = "label2";
            label2.Size = new Size(111, 46);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(318, 125);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(370, 52);
            txtDoctorName.TabIndex = 2;
            // 
            // txtDoctorSurname
            // 
            txtDoctorSurname.Location = new Point(318, 214);
            txtDoctorSurname.Name = "txtDoctorSurname";
            txtDoctorSurname.Size = new Size(370, 52);
            txtDoctorSurname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 302);
            label3.Name = "label3";
            label3.Size = new Size(101, 46);
            label3.TabIndex = 5;
            label3.Text = "Branş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 57);
            label4.Name = "label4";
            label4.Size = new Size(241, 46);
            label4.TabIndex = 6;
            label4.Text = "Doktor Ekleme";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(548, 372);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(140, 65);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBranch
            // 
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(318, 302);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(370, 53);
            cmbBranch.TabIndex = 8;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 497);
            Controls.Add(cmbBranch);
            Controls.Add(btnKaydet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDoctorSurname);
            Controls.Add(txtDoctorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorAddForm";
            Text = "DoctorAddForm";
            Load += DoctorAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDoctorName;
        private TextBox txtDoctorSurname;
        private Label label3;
        private Label label4;
        private Button btnKaydet;
        private ComboBox cmbBranch;
    }
}