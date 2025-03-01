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
            btn_sil = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_ilacAdi
            // 
            lbl_ilacAdi.AutoSize = true;
            lbl_ilacAdi.Location = new Point(124, 75);
            lbl_ilacAdi.Name = "lbl_ilacAdi";
            lbl_ilacAdi.Size = new Size(59, 20);
            lbl_ilacAdi.TabIndex = 0;
            lbl_ilacAdi.Text = "İlaç Adı";
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(124, 151);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(40, 20);
            lbl_fiyat.TabIndex = 1;
            lbl_fiyat.Text = "Fiyat";
            // 
            // txt_ilacAdi
            // 
            txt_ilacAdi.Location = new Point(255, 75);
            txt_ilacAdi.Margin = new Padding(3, 4, 3, 4);
            txt_ilacAdi.Name = "txt_ilacAdi";
            txt_ilacAdi.Size = new Size(166, 27);
            txt_ilacAdi.TabIndex = 2;
            // 
            // txt_fiyat
            // 
            txt_fiyat.Location = new Point(255, 144);
            txt_fiyat.Margin = new Padding(3, 4, 3, 4);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(166, 27);
            txt_fiyat.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(234, 215);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(176, 45);
            btn_kaydet.TabIndex = 4;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(560, 390);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(98, 46);
            btn_sil.TabIndex = 6;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(560, 288);
            button1.Name = "button1";
            button1.Size = new Size(98, 63);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 600);
            Controls.Add(button1);
            Controls.Add(btn_sil);
            Controls.Add(btn_kaydet);
            Controls.Add(txt_fiyat);
            Controls.Add(txt_ilacAdi);
            Controls.Add(lbl_fiyat);
            Controls.Add(lbl_ilacAdi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MedicineForm";
            Text = "MedicineForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ilacAdi;
        private Label lbl_fiyat;
        private TextBox txt_ilacAdi;
        private TextBox txt_fiyat;
        private Button btn_kaydet;
        private Button btn_sil;
        private Button button1;
    }
}