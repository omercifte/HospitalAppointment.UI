﻿namespace HospitalAppointment.UI.Forms
{
    partial class BranchPrice
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
            cmbBransh = new ComboBox();
            txtPrice = new TextBox();
            lstList = new ListBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbBransh
            // 
            cmbBransh.FormattingEnabled = true;
            cmbBransh.Location = new Point(156, 100);
            cmbBransh.Name = "cmbBransh";
            cmbBransh.Size = new Size(307, 53);
            cmbBransh.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(156, 191);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(307, 52);
            txtPrice.TabIndex = 1;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 45;
            lstList.Location = new Point(523, 24);
            lstList.Name = "lstList";
            lstList.Size = new Size(389, 409);
            lstList.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(283, 289);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(161, 80);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(138, 46);
            label1.TabIndex = 4;
            label1.Text = "Branşlar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(101, 46);
            label2.TabIndex = 5;
            label2.Text = "Ücret";
            // 
            // BranchPrice
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(955, 459);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(lstList);
            Controls.Add(txtPrice);
            Controls.Add(cmbBransh);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "BranchPrice";
            Text = "BranchPrice";
            Load += BranchPrice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBransh;
        private TextBox txtPrice;
        private ListBox lstList;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
    }
}