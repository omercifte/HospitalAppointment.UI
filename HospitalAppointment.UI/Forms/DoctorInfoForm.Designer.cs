namespace HospitalAppointment.UI.Forms
{
    partial class DoctorInfoForm
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
            cmbDoctor = new ComboBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            btnKaydet = new Button();
            chkList = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(38, 55);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 1;
            label1.Text = "Doktor";
            // 
            // cmbDoctor
            // 
            cmbDoctor.Font = new Font("Segoe UI", 14F);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(225, 55);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(525, 39);
            cmbDoctor.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 14F);
            dtpDate.Location = new Point(225, 123);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(525, 39);
            dtpDate.TabIndex = 3;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(38, 129);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 4;
            label2.Text = "Tarih";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 14F);
            btnKaydet.Location = new Point(370, 346);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(186, 69);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // chkList
            // 
            chkList.Font = new Font("Segoe UI", 14F);
            chkList.FormattingEnabled = true;
            chkList.Location = new Point(225, 204);
            chkList.Name = "chkList";
            chkList.Size = new Size(525, 106);
            chkList.TabIndex = 7;
            // 
            // DoctorInfoForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(930, 504);
            Controls.Add(chkList);
            Controls.Add(btnKaydet);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(cmbDoctor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorInfoForm";
            Text = "DoctorInfoForm";
            Load += DoctorInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDoctor;
        private DateTimePicker dtpDate;
        private Label label2;
        private Button btnKaydet;
        private CheckedListBox chkList;
    }
}