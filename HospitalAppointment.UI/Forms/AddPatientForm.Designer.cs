namespace HospitalAppointment.UI.Forms
{
    partial class AddPatientForm
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
            dgw_hastalar = new DataGridView();
            txt_hastaAra = new TextBox();
            label1 = new Label();
            lbl_bolum = new Label();
            lbl_ad = new Label();
            lbl_tc = new Label();
            txt_tc = new TextBox();
            lbl_soyad = new Label();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            cmb_bolum = new ComboBox();
            chkList = new CheckedListBox();
            lbl_doktor = new Label();
            btn_kaydet = new Button();
            cmb_doktor = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_tarih = new Label();
            groupBox2 = new GroupBox();
            btn_sil = new Button();
            btn_guncelle = new Button();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_hastalar).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgw_hastalar);
            groupBox1.Controls.Add(txt_hastaAra);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(277, 386);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıtlı Hastalar";
            // 
            // dgw_hastalar
            // 
            dgw_hastalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_hastalar.Location = new Point(5, 64);
            dgw_hastalar.Margin = new Padding(3, 2, 3, 2);
            dgw_hastalar.Name = "dgw_hastalar";
            dgw_hastalar.RowHeadersWidth = 51;
            dgw_hastalar.Size = new Size(255, 305);
            dgw_hastalar.TabIndex = 32;
            dgw_hastalar.CellContentClick += dgw_hastalar_CellContentClick;
            // 
            // txt_hastaAra
            // 
            txt_hastaAra.Location = new Point(75, 30);
            txt_hastaAra.Margin = new Padding(3, 2, 3, 2);
            txt_hastaAra.Name = "txt_hastaAra";
            txt_hastaAra.Size = new Size(185, 23);
            txt_hastaAra.TabIndex = 31;
            txt_hastaAra.TextChanged += txt_hastaAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 30;
            label1.Text = "Hasta TC";
            // 
            // lbl_bolum
            // 
            lbl_bolum.AutoSize = true;
            lbl_bolum.Location = new Point(17, 38);
            lbl_bolum.Name = "lbl_bolum";
            lbl_bolum.Size = new Size(81, 15);
            lbl_bolum.TabIndex = 39;
            lbl_bolum.Text = "Bölüm Seçiniz";
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(13, 35);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(22, 15);
            lbl_ad.TabIndex = 54;
            lbl_ad.Text = "Ad";
            // 
            // lbl_tc
            // 
            lbl_tc.AutoSize = true;
            lbl_tc.Location = new Point(10, 128);
            lbl_tc.Name = "lbl_tc";
            lbl_tc.Size = new Size(75, 15);
            lbl_tc.TabIndex = 53;
            lbl_tc.Text = "TC Numarası";
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(100, 120);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(179, 23);
            txt_tc.TabIndex = 52;
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(13, 81);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(39, 15);
            lbl_soyad.TabIndex = 51;
            lbl_soyad.Text = "Soyad";
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(100, 78);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(179, 23);
            txt_soyad.TabIndex = 50;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(100, 33);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(179, 23);
            txt_ad.TabIndex = 49;
            // 
            // cmb_bolum
            // 
            cmb_bolum.FormattingEnabled = true;
            cmb_bolum.Location = new Point(112, 36);
            cmb_bolum.Name = "cmb_bolum";
            cmb_bolum.Size = new Size(217, 23);
            cmb_bolum.TabIndex = 38;
            cmb_bolum.SelectedIndexChanged += cmb_bolum_SelectedIndexChanged;
            // 
            // chkList
            // 
            chkList.FormattingEnabled = true;
            chkList.Location = new Point(27, 134);
            chkList.Name = "chkList";
            chkList.Size = new Size(302, 94);
            chkList.TabIndex = 42;
            // 
            // lbl_doktor
            // 
            lbl_doktor.AutoSize = true;
            lbl_doktor.Location = new Point(349, 38);
            lbl_doktor.Name = "lbl_doktor";
            lbl_doktor.Size = new Size(82, 15);
            lbl_doktor.TabIndex = 37;
            lbl_doktor.Text = "Doktor Seçiniz";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(152, 298);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(333, 28);
            btn_kaydet.TabIndex = 40;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // cmb_doktor
            // 
            cmb_doktor.FormattingEnabled = true;
            cmb_doktor.Location = new Point(446, 36);
            cmb_doktor.Name = "cmb_doktor";
            cmb_doktor.Size = new Size(217, 23);
            cmb_doktor.TabIndex = 36;
            cmb_doktor.SelectedIndexChanged += cmb_doktor_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(112, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // lbl_tarih
            // 
            lbl_tarih.AutoSize = true;
            lbl_tarih.Location = new Point(17, 91);
            lbl_tarih.Name = "lbl_tarih";
            lbl_tarih.Size = new Size(72, 15);
            lbl_tarih.TabIndex = 31;
            lbl_tarih.Text = "Tarih Seçiniz";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonShadow;
            groupBox2.Controls.Add(btn_sil);
            groupBox2.Controls.Add(btn_guncelle);
            groupBox2.Location = new Point(293, 44);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(109, 346);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seçenekler";
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(13, 112);
            btn_sil.Margin = new Padding(3, 2, 3, 2);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(82, 55);
            btn_sil.TabIndex = 1;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(13, 28);
            btn_guncelle.Margin = new Padding(3, 2, 3, 2);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(82, 55);
            btn_guncelle.TabIndex = 0;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbl_ad);
            groupBox4.Controls.Add(lbl_tc);
            groupBox4.Controls.Add(txt_tc);
            groupBox4.Controls.Add(lbl_soyad);
            groupBox4.Controls.Add(txt_soyad);
            groupBox4.Controls.Add(txt_ad);
            groupBox4.Location = new Point(396, 81);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(284, 198);
            groupBox4.TabIndex = 43;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hasta Bilgileri";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonShadow;
            groupBox3.Controls.Add(lbl_bolum);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(cmb_bolum);
            groupBox3.Controls.Add(chkList);
            groupBox3.Controls.Add(lbl_doktor);
            groupBox3.Controls.Add(btn_kaydet);
            groupBox3.Controls.Add(cmb_doktor);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(lbl_tarih);
            groupBox3.Location = new Point(408, 22);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(684, 368);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Kaydet";
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1096, 430);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPatientForm";
            Text = "AddPatientForm";
            Load += AddPatientForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_hastalar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label lbl_ad;
        private Label lbl_tc;
        private TextBox txt_tc;
        private Label lbl_soyad;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private GroupBox groupBox2;
        private Button btn_sil;
        private Button btn_guncelle;
        private Label label1;
        private TextBox txt_hastaAra;
        private DataGridView dgw_hastalar;
        private Label lbl_bolum;
        private ComboBox cmb_bolum;
        private Label lbl_doktor;
        private ComboBox cmb_doktor;
        private CheckedListBox chkList;
        private Button btn_kaydet;
        private DateTimePicker dateTimePicker1;
        private Label lbl_tarih;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
    }
}