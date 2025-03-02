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
            SuspendLayout();
            // 
            // lstCount
            // 
            lstCount.FormattingEnabled = true;
            lstCount.ItemHeight = 37;
            lstCount.Location = new Point(241, 160);
            lstCount.Name = "lstCount";
            lstCount.Size = new Size(424, 263);
            lstCount.TabIndex = 0;
            // 
            // DoctorPatientsCountForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 722);
            Controls.Add(lstCount);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorPatientsCountForm";
            Text = "DoctorPatientsCountForm";
            Load += DoctorPatientsCountForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCount;
    }
}