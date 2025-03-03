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
            dgw_doktorlar = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Branch = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txt_aramaYap = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            btn_ara = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_doktorlar).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgw_doktorlar
            // 
            dgw_doktorlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgw_doktorlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_doktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_doktorlar.Columns.AddRange(new DataGridViewColumn[] { Id, colDoctorName, Surname, Branch });
            dgw_doktorlar.Location = new Point(9, 316);
            dgw_doktorlar.MultiSelect = false;
            dgw_doktorlar.Name = "dgw_doktorlar";
            dgw_doktorlar.RowHeadersWidth = 51;
            dgw_doktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_doktorlar.Size = new Size(857, 331);
            dgw_doktorlar.TabIndex = 16;
            dgw_doktorlar.CellContentClick += dgw_doktorlar_CellContentClick;
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
            colDoctorName.Width = 94;
            // 
            // Surname
            // 
            Surname.DataPropertyName = "Surname";
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Surname.Width = 127;
            // 
            // Branch
            // 
            Branch.DataPropertyName = "Branch";
            Branch.HeaderText = "Branch";
            Branch.MinimumWidth = 6;
            Branch.Name = "Branch";
            Branch.SortMode = DataGridViewColumnSortMode.NotSortable;
            Branch.Width = 103;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_aramaYap);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(24, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 218);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ara";
            // 
            // txt_aramaYap
            // 
            txt_aramaYap.Location = new Point(6, 163);
            txt_aramaYap.Name = "txt_aramaYap";
            txt_aramaYap.Size = new Size(499, 32);
            txt_aramaYap.TabIndex = 14;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(133, 29);
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
            radioButton1.Size = new Size(115, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "İsme Göre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 277);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 19;
            label1.Text = "Doktor Listesi";
            // 
            // btn_ara
            // 
            btn_ara.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_ara.Location = new Point(399, 230);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(146, 45);
            btn_ara.TabIndex = 18;
            btn_ara.Text = "Ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(929, 651);
            Controls.Add(dgw_doktorlar);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(btn_ara);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DoctorListForm";
            Text = "DoctorListForm";
            Load += DoctorListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_doktorlar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_doktorlar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colDoctorName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Branch;
        private GroupBox groupBox2;
        private TextBox txt_aramaYap;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button btn_ara;
    }
}