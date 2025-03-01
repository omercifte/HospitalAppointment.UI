﻿namespace HospitalAppointment.UI.Forms
{
    partial class MainForm
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
            hastaKayıtToolStripMenuItem = new ToolStripMenuItem();
            hastaKayıtToolStripMenuItem1 = new ToolStripMenuItem();
            doktorKayıtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            doktorYönetimiToolStripMenuItem = new ToolStripMenuItem();
            doktorKayıtToolStripMenuItem1 = new ToolStripMenuItem();
            doktorListesiToolStripMenuItem = new ToolStripMenuItem();
            doktorBilgiToolStripMenuItem = new ToolStripMenuItem();
            raporlarVeİstatistiklerToolStripMenuItem = new ToolStripMenuItem();
            hastaİstatistikleriToolStripMenuItem = new ToolStripMenuItem();
            randevuİstatistikleriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // hastaKayıtToolStripMenuItem
            // 
            hastaKayıtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hastaKayıtToolStripMenuItem1, doktorKayıtToolStripMenuItem });
            hastaKayıtToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            hastaKayıtToolStripMenuItem.Size = new Size(121, 24);
            hastaKayıtToolStripMenuItem.Text = "Hasta Yönetimi";
            // 
            // hastaKayıtToolStripMenuItem1
            // 
            hastaKayıtToolStripMenuItem1.Name = "hastaKayıtToolStripMenuItem1";
            hastaKayıtToolStripMenuItem1.Size = new Size(160, 24);
            hastaKayıtToolStripMenuItem1.Text = "Hasta Kayıt";
            hastaKayıtToolStripMenuItem1.Click += hastaKayıtToolStripMenuItem1_Click;
            // 
            // doktorKayıtToolStripMenuItem
            // 
            doktorKayıtToolStripMenuItem.Name = "doktorKayıtToolStripMenuItem";
            doktorKayıtToolStripMenuItem.Size = new Size(160, 24);
            doktorKayıtToolStripMenuItem.Text = "Hasta Listesi";
            doktorKayıtToolStripMenuItem.Click += doktorKayıtToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 192, 255);
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hastaKayıtToolStripMenuItem, doktorYönetimiToolStripMenuItem, raporlarVeİstatistiklerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1557, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // doktorYönetimiToolStripMenuItem
            // 
            doktorYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doktorKayıtToolStripMenuItem1, doktorListesiToolStripMenuItem, doktorBilgiToolStripMenuItem });
            doktorYönetimiToolStripMenuItem.Name = "doktorYönetimiToolStripMenuItem";
            doktorYönetimiToolStripMenuItem.Size = new Size(129, 24);
            doktorYönetimiToolStripMenuItem.Text = "Doktor Yönetimi";
            // 
            // doktorKayıtToolStripMenuItem1
            // 
            doktorKayıtToolStripMenuItem1.Name = "doktorKayıtToolStripMenuItem1";
            doktorKayıtToolStripMenuItem1.Size = new Size(168, 24);
            doktorKayıtToolStripMenuItem1.Text = "Doktor Kayıt";
            doktorKayıtToolStripMenuItem1.Click += doktorKayıtToolStripMenuItem1_Click;
            // 
            // doktorListesiToolStripMenuItem
            // 
            doktorListesiToolStripMenuItem.Name = "doktorListesiToolStripMenuItem";
            doktorListesiToolStripMenuItem.Size = new Size(168, 24);
            doktorListesiToolStripMenuItem.Text = "Doktor Listesi";
            doktorListesiToolStripMenuItem.Click += doktorListesiToolStripMenuItem_Click;
            // 
            // doktorBilgiToolStripMenuItem
            // 
            doktorBilgiToolStripMenuItem.Name = "doktorBilgiToolStripMenuItem";
            doktorBilgiToolStripMenuItem.Size = new Size(168, 24);
            doktorBilgiToolStripMenuItem.Text = "Doktor Bilgi";
            doktorBilgiToolStripMenuItem.Click += doktorBilgiToolStripMenuItem_Click;
            // 
            // raporlarVeİstatistiklerToolStripMenuItem
            // 
            raporlarVeİstatistiklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hastaİstatistikleriToolStripMenuItem, randevuİstatistikleriToolStripMenuItem });
            raporlarVeİstatistiklerToolStripMenuItem.Name = "raporlarVeİstatistiklerToolStripMenuItem";
            raporlarVeİstatistiklerToolStripMenuItem.Size = new Size(172, 24);
            raporlarVeİstatistiklerToolStripMenuItem.Text = "Raporlar ve İstatistikler";
            // 
            // hastaİstatistikleriToolStripMenuItem
            // 
            hastaİstatistikleriToolStripMenuItem.Name = "hastaİstatistikleriToolStripMenuItem";
            hastaİstatistikleriToolStripMenuItem.Size = new Size(214, 24);
            hastaİstatistikleriToolStripMenuItem.Text = "Hasta İstatistikleri";
            hastaİstatistikleriToolStripMenuItem.Click += hastaİstatistikleriToolStripMenuItem_Click;
            // 
            // randevuİstatistikleriToolStripMenuItem
            // 
            randevuİstatistikleriToolStripMenuItem.Name = "randevuİstatistikleriToolStripMenuItem";
            randevuİstatistikleriToolStripMenuItem.Size = new Size(214, 24);
            randevuİstatistikleriToolStripMenuItem.Text = "Randevu İstatistikleri";
            randevuİstatistikleriToolStripMenuItem.Click += randevuİstatistikleriToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1557, 802);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "HospitalAppointment";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private ToolStripMenuItem hastaKayıtToolStripMenuItem1;
        private ToolStripMenuItem doktorKayıtToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem doktorYönetimiToolStripMenuItem;
        private ToolStripMenuItem doktorKayıtToolStripMenuItem1;
        private ToolStripMenuItem doktorListesiToolStripMenuItem;
        private ToolStripMenuItem raporlarVeİstatistiklerToolStripMenuItem;
        private ToolStripMenuItem hastaİstatistikleriToolStripMenuItem;
        private ToolStripMenuItem randevuİstatistikleriToolStripMenuItem;
        private ToolStripMenuItem doktorBilgiToolStripMenuItem;
    }
}