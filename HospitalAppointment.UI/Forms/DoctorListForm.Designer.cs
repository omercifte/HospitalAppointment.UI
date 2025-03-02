namespace HospitalAppointment.UI.Forms
{
    partial class DoctorListForm
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
            lstDoctors = new ListBox();
            label = new Label();
            SuspendLayout();
            // 
            // lstDoctors
            // 
            lstDoctors.FormattingEnabled = true;
            lstDoctors.ItemHeight = 37;
            lstDoctors.Location = new Point(87, 154);
            lstDoctors.Name = "lstDoctors";
            lstDoctors.Size = new Size(543, 226);
            lstDoctors.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(87, 79);
            label.Name = "label";
            label.Size = new Size(178, 37);
            label.TabIndex = 1;
            label.Text = "Doktorlarımız";
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 651);
            Controls.Add(label);
            Controls.Add(lstDoctors);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorListForm";
            Text = "DoctorListForm";
            Load += DoctorListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDoctors;
        private Label label;
    }
}