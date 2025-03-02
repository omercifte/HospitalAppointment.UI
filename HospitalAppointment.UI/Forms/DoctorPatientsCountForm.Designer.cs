namespace HospitalAppointment.UI.Forms
{
    partial class DoctorPatientsCountForm
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
            lstCount = new ListBox();
            btnPdf = new Button();
            btnExcel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstCount
            // 
            lstCount.FormattingEnabled = true;
            lstCount.ItemHeight = 37;
            lstCount.Location = new Point(232, 150);
            lstCount.Name = "lstCount";
            lstCount.Size = new Size(498, 263);
            lstCount.TabIndex = 0;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(493, 465);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(237, 101);
            btnPdf.TabIndex = 1;
            btnPdf.Text = "Pdf Olustur";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(232, 465);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(237, 101);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Excel Olustur";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 72);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 3;
            label1.Text = "Doktor Hasta Sayıları";
            // 
            // DoctorPatientsCountForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 722);
            Controls.Add(label1);
            Controls.Add(btnExcel);
            Controls.Add(btnPdf);
            Controls.Add(lstCount);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorPatientsCountForm";
            Text = "DoctorPatientsCountForm";
            Load += DoctorPatientsCountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCount;
        private Button btnPdf;
        private Button btnExcel;
        private Label label1;
    }
}