﻿namespace HospitalAppointment.UI.Forms
{
    partial class PatientCountForm
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
            lstCount = new ListBox();
            btnPdf = new Button();
            btnExcel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 56);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 0;
            label1.Text = "Branş Hasta Sayıları";
            label1.Click += label1_Click;
            // 
            // lstCount
            // 
            lstCount.FormattingEnabled = true;
            lstCount.ItemHeight = 37;
            lstCount.Location = new Point(285, 123);
            lstCount.Name = "lstCount";
            lstCount.Size = new Size(459, 263);
            lstCount.TabIndex = 1;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(555, 415);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(189, 98);
            btnPdf.TabIndex = 3;
            btnPdf.Text = "Pdf Oluştur";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(285, 415);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(189, 98);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "Excel Oluştur";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // PatientCountForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 664);
            Controls.Add(btnExcel);
            Controls.Add(btnPdf);
            Controls.Add(lstCount);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "PatientCountForm";
            Text = "PatientCountForm";
            Load += PatientCountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstCount;
        private Button btnPdf;
        private Button btnExcel;
    }
}