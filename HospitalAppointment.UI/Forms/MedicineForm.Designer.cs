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
            lbl_ilacAdi.Location = new Point(108, 56);
            lbl_ilacAdi.Name = "lbl_ilacAdi";
            lbl_ilacAdi.Size = new Size(46, 15);
            lbl_ilacAdi.TabIndex = 0;
            lbl_ilacAdi.Text = "İlaç Adı";
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(108, 113);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(32, 15);
            lbl_fiyat.TabIndex = 1;
            lbl_fiyat.Text = "Fiyat";
            // 
            // txt_ilacAdi
            // 
            txt_ilacAdi.Location = new Point(223, 56);
            txt_ilacAdi.Name = "txt_ilacAdi";
            txt_ilacAdi.Size = new Size(146, 23);
            txt_ilacAdi.TabIndex = 2;
            // 
            // txt_fiyat
            // 
            txt_fiyat.Location = new Point(223, 108);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(146, 23);
            txt_fiyat.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(215, 159);
            btn_kaydet.Margin = new Padding(3, 2, 3, 2);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(154, 34);
            btn_kaydet.TabIndex = 4;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(501, 56);
            lstList.Name = "lstList";
            lstList.Size = new Size(271, 124);
            lstList.TabIndex = 5;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(lstList);
            Controls.Add(btn_kaydet);
            Controls.Add(txt_fiyat);
            Controls.Add(txt_ilacAdi);
            Controls.Add(lbl_fiyat);
            Controls.Add(lbl_ilacAdi);
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