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
            Id = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            TcNo = new DataGridViewTextBoxColumn();
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
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Id
            // 
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // colPatientName
            // 
            colPatientName.MinimumWidth = 6;
            colPatientName.Name = "colPatientName";
            colPatientName.Width = 125;
            // 
            // Surname
            // 
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // TcNo
            // 
            TcNo.DataPropertyName = "TcNo";
            TcNo.HeaderText = "TcNo";
            TcNo.MinimumWidth = 6;
            TcNo.Name = "TcNo";
            TcNo.Width = 72;
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
            chkList.Size = new Size(302, 76);
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
            groupBox3.Location = new Point(29, 20);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(707, 368);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Kaydet";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(756, 416);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPatientForm";
            Text = "AddPatientForm";
            Load += AddPatientForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_ad;
        private Label lbl_tc;
        private TextBox txt_tc;
        private Label lbl_soyad;
        private TextBox txt_soyad;
        private TextBox txt_ad;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn TcNo;
    }
}