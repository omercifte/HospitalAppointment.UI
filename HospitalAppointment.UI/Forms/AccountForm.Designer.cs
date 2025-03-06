namespace HospitalAppointment.UI.Forms
{
    partial class AccountForm
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            button1 = new Button();
            lstList = new ListBox();
            txtMedicinePrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(724, 214);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(777, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 304);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 108);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(226, 43);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 45);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(226, 43);
            textBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 175);
            label7.Name = "label7";
            label7.Size = new Size(211, 37);
            label7.TabIndex = 7;
            label7.Text = "Sigorta Durumu:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(151, 224);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 41);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "SGK";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 41);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Özel";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 1;
            label3.Text = "TC No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 51);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(928, 394);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(226, 43);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 400);
            label5.Name = "label5";
            label5.Size = new Size(209, 37);
            label5.TabIndex = 10;
            label5.Text = "Ödenecek Tutar:";
            // 
            // button1
            // 
            button1.Location = new Point(921, 580);
            button1.Name = "button1";
            button1.Size = new Size(233, 59);
            button1.TabIndex = 11;
            button1.Text = "Pdf Oluştur";
            button1.UseVisualStyleBackColor = true;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 37;
            lstList.Location = new Point(49, 350);
            lstList.Name = "lstList";
            lstList.Size = new Size(337, 300);
            lstList.TabIndex = 12;
            // 
            // txtMedicinePrice
            // 
            txtMedicinePrice.Location = new Point(928, 478);
            txtMedicinePrice.Name = "txtMedicinePrice";
            txtMedicinePrice.ReadOnly = true;
            txtMedicinePrice.Size = new Size(226, 43);
            txtMedicinePrice.TabIndex = 13;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 674);
            Controls.Add(txtMedicinePrice);
            Controls.Add(lstList);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "AccountForm";
            Text = "AccountForm";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtPrice;
        private Label label5;
        private Button button1;
        private ListBox lstList;
        private TextBox txtMedicinePrice;
    }
}