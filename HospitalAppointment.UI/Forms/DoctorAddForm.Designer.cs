namespace HospitalAppointment.UI.Forms
{
    partial class DoctorAddForm
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
            cmbBranch = new ComboBox();
            btnKaydet = new Button();
            label3 = new Label();
            txtDoctorSurname = new TextBox();
            txtDoctorName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgw_doktorlar = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Branch = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txt_aramaYap = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_ara = new Button();
            btn_sil = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_doktorlar).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbBranch);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDoctorSurname);
            groupBox1.Controls.Add(txtDoctorName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 340);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Ekle";
            // 
            // cmbBranch
            // 
            cmbBranch.Font = new Font("Segoe UI", 13.8F);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(127, 215);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(370, 39);
            cmbBranch.TabIndex = 15;
            cmbBranch.SelectedIndexChanged += cmbBranch_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F);
            btnKaydet.Location = new Point(313, 270);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(184, 45);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(17, 223);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 13;
            label3.Text = "Branş";
            // 
            // txtDoctorSurname
            // 
            txtDoctorSurname.Font = new Font("Segoe UI", 13.8F);
            txtDoctorSurname.Location = new Point(127, 132);
            txtDoctorSurname.Name = "txtDoctorSurname";
            txtDoctorSurname.Size = new Size(370, 38);
            txtDoctorSurname.TabIndex = 12;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Font = new Font("Segoe UI", 13.8F);
            txtDoctorName.Location = new Point(127, 46);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(370, 38);
            txtDoctorName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(17, 135);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 10;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(43, 31);
            label1.TabIndex = 9;
            label1.Text = "Ad";
            // 
            // dgw_doktorlar
            // 
            dgw_doktorlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgw_doktorlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_doktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_doktorlar.Columns.AddRange(new DataGridViewColumn[] { Id, colDoctorName, Surname, Branch });
            dgw_doktorlar.Location = new Point(594, 23);
            dgw_doktorlar.MultiSelect = false;
            dgw_doktorlar.Name = "dgw_doktorlar";
            dgw_doktorlar.RowHeadersWidth = 51;
            dgw_doktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_doktorlar.Size = new Size(477, 600);
            dgw_doktorlar.TabIndex = 10;
            dgw_doktorlar.CellClick += dgw_doktorlar_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 78;
            // 
            // colDoctorName
            // 
            colDoctorName.DataPropertyName = "Name";
            colDoctorName.HeaderText = "Name";
            colDoctorName.MinimumWidth = 6;
            colDoctorName.Name = "colDoctorName";
            colDoctorName.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDoctorName.Width = 115;
            // 
            // Surname
            // 
            Surname.DataPropertyName = "Surname";
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Surname.Width = 158;
            // 
            // Branch
            // 
            Branch.DataPropertyName = "Branch";
            Branch.HeaderText = "Branch";
            Branch.MinimumWidth = 6;
            Branch.Name = "Branch";
            Branch.SortMode = DataGridViewColumnSortMode.NotSortable;
            Branch.Width = 128;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_aramaYap);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(12, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 250);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ara";
            // 
            // txt_aramaYap
            // 
            txt_aramaYap.Location = new Point(6, 163);
            txt_aramaYap.Name = "txt_aramaYap";
            txt_aramaYap.Size = new Size(499, 38);
            txt_aramaYap.TabIndex = 14;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(158, 35);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Branşa Göre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 35);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "İsme Göre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_ara
            // 
            btn_ara.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_ara.Location = new Point(369, 633);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(184, 45);
            btn_ara.TabIndex = 13;
            btn_ara.Text = "Ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // btn_sil
            // 
            btn_sil.Font = new Font("Segoe UI", 13.8F);
            btn_sil.Location = new Point(887, 633);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(184, 45);
            btn_sil.TabIndex = 16;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1097, 690);
            Controls.Add(btn_sil);
            Controls.Add(btn_ara);
            Controls.Add(groupBox2);
            Controls.Add(dgw_doktorlar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorAddForm";
            Text = "DoctorAddForm";
            Load += DoctorAddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_doktorlar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbBranch;
        private Button btnKaydet;
        private Label label3;
        private TextBox txtDoctorSurname;
        private TextBox txtDoctorName;
        private Label label2;
        private Label label1;
        private DataGridView dgw_doktorlar;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btn_ara;
        private TextBox txt_aramaYap;
        private Button btn_sil;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colDoctorName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Branch;
    }
}