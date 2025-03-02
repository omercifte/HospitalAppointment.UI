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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstCount
            // 
            lstCount.Font = new Font("Segoe UI", 14F);
            lstCount.FormattingEnabled = true;
            lstCount.ItemHeight = 31;
            lstCount.Location = new Point(25, 61);
            lstCount.Name = "lstCount";
            lstCount.Size = new Size(498, 252);
            lstCount.TabIndex = 0;
            // 
            // btnPdf
            // 
            btnPdf.Font = new Font("Segoe UI", 14F);
            btnPdf.Location = new Point(308, 319);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(215, 68);
            btnPdf.TabIndex = 1;
            btnPdf.Text = "Pdf Olustur";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcel
            // 
            btnExcel.Font = new Font("Segoe UI", 14F);
            btnExcel.Location = new Point(25, 319);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(215, 68);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Excel Olustur";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstCount);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnPdf);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(24, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 454);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Hasta Sayıları";
            // 
            // DoctorPatientsCountForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(757, 554);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorPatientsCountForm";
            Text = "DoctorPatientsCountForm";
            Load += DoctorPatientsCountForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCount;
        private Button btnPdf;
        private Button btnExcel;
        private GroupBox groupBox1;
    }
}