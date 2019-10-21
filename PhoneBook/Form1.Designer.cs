namespace PhoneBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKayitDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKayitSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProgramBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKayitSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSonIslemBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.btnKayitDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnKayitSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuDuzen,
            this.mnuIslem,
            this.mnuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKaydet,
            this.toolStripSeparator2,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuKaydet.Size = new System.Drawing.Size(150, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuCikis.Size = new System.Drawing.Size(150, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuDuzen
            // 
            this.mnuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKes,
            this.mnuKopyala,
            this.mnuYapistir});
            this.mnuDuzen.Name = "mnuDuzen";
            this.mnuDuzen.Size = new System.Drawing.Size(52, 20);
            this.mnuDuzen.Text = "Düzen";
            // 
            // mnuKes
            // 
            this.mnuKes.Name = "mnuKes";
            this.mnuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuKes.Size = new System.Drawing.Size(158, 22);
            this.mnuKes.Text = "Kes";
            // 
            // mnuKopyala
            // 
            this.mnuKopyala.Name = "mnuKopyala";
            this.mnuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuKopyala.Size = new System.Drawing.Size(158, 22);
            this.mnuKopyala.Text = "Kopyala";
            // 
            // mnuYapistir
            // 
            this.mnuYapistir.Name = "mnuYapistir";
            this.mnuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuYapistir.Size = new System.Drawing.Size(158, 22);
            this.mnuYapistir.Text = "Yapıştır";
            // 
            // mnuIslem
            // 
            this.mnuIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeniKayit,
            this.mnuKayitDuzenle,
            this.mnuKayitSil,
            this.toolStripMenuItem1,
            this.mnuYenile});
            this.mnuIslem.Name = "mnuIslem";
            this.mnuIslem.Size = new System.Drawing.Size(47, 20);
            this.mnuIslem.Text = "İşlem";
            // 
            // mnuYeniKayit
            // 
            this.mnuYeniKayit.Name = "mnuYeniKayit";
            this.mnuYeniKayit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuYeniKayit.Size = new System.Drawing.Size(187, 22);
            this.mnuYeniKayit.Text = "Yeni Kayıt";
            this.mnuYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // mnuKayitDuzenle
            // 
            this.mnuKayitDuzenle.Name = "mnuKayitDuzenle";
            this.mnuKayitDuzenle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuKayitDuzenle.Size = new System.Drawing.Size(187, 22);
            this.mnuKayitDuzenle.Text = "Kayıt Düzenle";
            this.mnuKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // mnuKayitSil
            // 
            this.mnuKayitSil.Name = "mnuKayitSil";
            this.mnuKayitSil.RightToLeftAutoMirrorImage = true;
            this.mnuKayitSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuKayitSil.Size = new System.Drawing.Size(187, 22);
            this.mnuKayitSil.Text = "Kayıt Sil";
            this.mnuKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuYenile
            // 
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.RightToLeftAutoMirrorImage = true;
            this.mnuYenile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuYenile.Size = new System.Drawing.Size(187, 22);
            this.mnuYenile.Text = "Yenile";
            this.mnuYenile.Click += new System.EventHandler(this.mnuYenile_Click);
            // 
            // mnuHakkinda
            // 
            this.mnuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYardim,
            this.toolStripMenuItem3,
            this.mnuProgramBilgi});
            this.mnuHakkinda.Name = "mnuHakkinda";
            this.mnuHakkinda.Size = new System.Drawing.Size(69, 20);
            this.mnuHakkinda.Text = "Hakkında";
            // 
            // mnuYardim
            // 
            this.mnuYardim.Name = "mnuYardim";
            this.mnuYardim.Size = new System.Drawing.Size(180, 22);
            this.mnuYardim.Text = "Yardım";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuProgramBilgi
            // 
            this.mnuProgramBilgi.Name = "mnuProgramBilgi";
            this.mnuProgramBilgi.Size = new System.Drawing.Size(180, 22);
            this.mnuProgramBilgi.Text = "Program Bilgi";
            this.mnuProgramBilgi.Click += new System.EventHandler(this.mnuProgramBilgi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.lblKayitSayisi,
            this.lblSonIslemBilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "status";
            // 
            // lblSaat
            // 
            this.lblSaat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSaat.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSaat.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSaat.LinkColor = System.Drawing.Color.OrangeRed;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 19);
            this.lblSaat.Text = "Saat";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblKayitSayisi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(69, 19);
            this.lblKayitSayisi.Text = "Kayıt Sayısı";
            this.lblKayitSayisi.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblSonIslemBilgi
            // 
            this.lblSonIslemBilgi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSonIslemBilgi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSonIslemBilgi.Name = "lblSonIslemBilgi";
            this.lblSonIslemBilgi.Size = new System.Drawing.Size(65, 19);
            this.lblSonIslemBilgi.Text = "Son İşlem ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 377);
            this.dataGridView1.TabIndex = 3;
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniKayit.Image = global::PhoneBook.Properties.Resources.icon_ekle;
            this.btnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(23, 22);
            this.btnYeniKayit.Text = "&New";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitDuzenle.Image = global::PhoneBook.Properties.Resources.icon_duzenle;
            this.btnKayitDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(23, 22);
            this.btnKayitDuzenle.Text = "&Open";
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitSil.Image = global::PhoneBook.Properties.Resources.icon_sil;
            this.btnKayitSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(23, 22);
            this.btnKayitSil.Text = "&Open";
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "&Save";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.btnKayitDuzenle,
            this.btnKayitSil,
            this.toolStripSeparator1,
            this.btnKaydet,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuDuzen;
        private System.Windows.Forms.ToolStripMenuItem mnuKes;
        private System.Windows.Forms.ToolStripMenuItem mnuKopyala;
        private System.Windows.Forms.ToolStripMenuItem mnuYapistir;
        private System.Windows.Forms.ToolStripMenuItem mnuIslem;
        private System.Windows.Forms.ToolStripMenuItem mnuYeniKayit;
        private System.Windows.Forms.ToolStripMenuItem mnuKayitDuzenle;
        private System.Windows.Forms.ToolStripMenuItem mnuKayitSil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuYenile;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem mnuYardim;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramBilgi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblKayitSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblSonIslemBilgi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer tmrSaat;
        private System.Windows.Forms.ToolStripButton btnYeniKayit;
        private System.Windows.Forms.ToolStripButton btnKayitDuzenle;
        private System.Windows.Forms.ToolStripButton btnKayitSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

