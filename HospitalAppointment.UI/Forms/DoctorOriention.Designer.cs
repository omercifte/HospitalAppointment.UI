namespace HospitalAppointment.UI.Forms
{
    partial class DoctorOriention
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
            cmbBranch = new ComboBox();
            dtDate = new DateTimePicker();
            cmbDoctor = new ComboBox();
            chkList = new CheckedListBox();
            dgHastalar = new DataGridView();
            cmbMedicine = new ComboBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgHastalar).BeginInit();
            SuspendLayout();
            // 
            // cmbBranch
            // 
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(162, 208);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(342, 45);
            cmbBranch.TabIndex = 0;
            cmbBranch.SelectedIndexChanged += cmbBranch_SelectedIndexChanged;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(162, 286);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(342, 43);
            dtDate.TabIndex = 1;
            dtDate.ValueChanged += dtDate_ValueChanged;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(746, 208);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(341, 45);
            cmbDoctor.TabIndex = 2;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            // 
            // chkList
            // 
            chkList.FormattingEnabled = true;
            chkList.Location = new Point(162, 357);
            chkList.Name = "chkList";
            chkList.Size = new Size(342, 80);
            chkList.TabIndex = 3;
            // 
            // dgHastalar
            // 
            dgHastalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHastalar.Location = new Point(162, 44);
            dgHastalar.Name = "dgHastalar";
            dgHastalar.Size = new Size(342, 131);
            dgHastalar.TabIndex = 4;
            // 
            // cmbMedicine
            // 
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(746, 284);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(341, 45);
            cmbMedicine.TabIndex = 5;
            cmbMedicine.SelectedIndexChanged += cmbMedicine_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(912, 368);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(175, 58);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 7;
            label1.Text = "Hastalar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 216);
            label2.Name = "label2";
            label2.Size = new Size(93, 37);
            label2.TabIndex = 8;
            label2.Text = "Bölüm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 292);
            label3.Name = "label3";
            label3.Size = new Size(73, 37);
            label3.TabIndex = 9;
            label3.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(607, 216);
            label5.Name = "label5";
            label5.Size = new Size(99, 37);
            label5.TabIndex = 11;
            label5.Text = "Doktor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 292);
            label6.Name = "label6";
            label6.Size = new Size(57, 37);
            label6.TabIndex = 12;
            label6.Text = "İlaç";
            // 
            // DoctorOriention
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 582);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(cmbMedicine);
            Controls.Add(dgHastalar);
            Controls.Add(chkList);
            Controls.Add(cmbDoctor);
            Controls.Add(dtDate);
            Controls.Add(cmbBranch);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorOriention";
            Text = "DoctorOriention";
            Load += DoctorOriention_Load;
            ((System.ComponentModel.ISupportInitialize)dgHastalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBranch;
        private DateTimePicker dtDate;
        private ComboBox cmbDoctor;
        private CheckedListBox chkList;
        private DataGridView dgHastalar;
        private ComboBox cmbMedicine;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}