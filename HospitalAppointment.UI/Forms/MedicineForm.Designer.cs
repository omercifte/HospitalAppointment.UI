namespace HospitalAppointment.UI.Forms
{
    partial class MedicineForm
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
            lbl_ilacAdi = new Label();
            lbl_fiyat = new Label();
            txt_ilacAdi = new TextBox();
            txt_fiyat = new TextBox();
            btn_kaydet = new Button();
            lstList = new ListBox();
            SuspendLayout();
            // 
            // lbl_ilacAdi
            // 
            lbl_ilacAdi.AutoSize = true;
            lbl_ilacAdi.Font = new Font("Segoe UI", 19.8000011F);
            lbl_ilacAdi.Location = new Point(21, 69);
            lbl_ilacAdi.Name = "lbl_ilacAdi";
            lbl_ilacAdi.Size = new Size(129, 46);
            lbl_ilacAdi.TabIndex = 0;
            lbl_ilacAdi.Text = "İlaç Adı";
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Font = new Font("Segoe UI", 19.8000011F);
            lbl_fiyat.Location = new Point(21, 143);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(90, 46);
            lbl_fiyat.TabIndex = 1;
            lbl_fiyat.Text = "Fiyat";
            // 
            // txt_ilacAdi
            // 
            txt_ilacAdi.Font = new Font("Segoe UI", 19.8000011F);
            txt_ilacAdi.Location = new Point(181, 69);
            txt_ilacAdi.Margin = new Padding(3, 4, 3, 4);
            txt_ilacAdi.Name = "txt_ilacAdi";
            txt_ilacAdi.Size = new Size(251, 51);
            txt_ilacAdi.TabIndex = 2;
            // 
            // txt_fiyat
            // 
            txt_fiyat.Font = new Font("Segoe UI", 19.8000011F);
            txt_fiyat.Location = new Point(181, 138);
            txt_fiyat.Margin = new Padding(3, 4, 3, 4);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(251, 51);
            txt_fiyat.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Font = new Font("Segoe UI", 19.8000011F);
            btn_kaydet.Location = new Point(230, 223);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(202, 57);
            btn_kaydet.TabIndex = 4;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // lstList
            // 
            lstList.Font = new Font("Segoe UI", 19.8000011F);
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 45;
            lstList.Location = new Point(473, 35);
            lstList.Margin = new Padding(3, 4, 3, 4);
            lstList.Name = "lstList";
            lstList.Size = new Size(388, 364);
            lstList.TabIndex = 5;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(873, 412);
            Controls.Add(lstList);
            Controls.Add(btn_kaydet);
            Controls.Add(txt_fiyat);
            Controls.Add(txt_ilacAdi);
            Controls.Add(lbl_fiyat);
            Controls.Add(lbl_ilacAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MedicineForm";
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ilacAdi;
        private Label lbl_fiyat;
        private TextBox txt_ilacAdi;
        private TextBox txt_fiyat;
        private Button btn_kaydet;
        private ListBox lstList;
    }
}