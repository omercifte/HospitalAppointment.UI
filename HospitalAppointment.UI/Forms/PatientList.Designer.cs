namespace HospitalAppointment.UI.Forms
{
    partial class PatientList
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
            lstPatients = new ListBox();
            label2 = new Label();
            txt_tc = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstPatients);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(39, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 405);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Listesi";
            // 
            // lstPatients
            // 
            lstPatients.Font = new Font("Segoe UI", 14F);
            lstPatients.FormattingEnabled = true;
            lstPatients.ItemHeight = 31;
            lstPatients.Location = new Point(18, 38);
            lstPatients.Name = "lstPatients";
            lstPatients.Size = new Size(723, 345);
            lstPatients.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(477, 40);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 6;
            label2.Text = "Hasta Tc";
            // 
            // txt_tc
            // 
            txt_tc.Font = new Font("Segoe UI", 14F);
            txt_tc.Location = new Point(585, 36);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(226, 39);
            txt_tc.TabIndex = 5;
            txt_tc.TextChanged += txt_tc_TextChanged;
            // 
            // PatientList
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(859, 506);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txt_tc);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "PatientList";
            Text = "PatientList";
            Load += PatientList_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstPatients;
        private Label label2;
        private TextBox txt_tc;
    }
}