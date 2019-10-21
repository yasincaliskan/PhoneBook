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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKayitSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSonIslemBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
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
            this.mnuKes.Size = new System.Drawing.Size(180, 22);
            this.mnuKes.Text = "Kes";
            // 
            // mnuKopyala
            // 
            this.mnuKopyala.Name = "mnuKopyala";
            this.mnuKopyala.Size = new System.Drawing.Size(180, 22);
            this.mnuKopyala.Text = "Kopyala";
            // 
            // mnuYapistir
            // 
            this.mnuYapistir.Name = "mnuYapistir";
            this.mnuYapistir.Size = new System.Drawing.Size(180, 22);
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
            this.mnuYeniKayit.Size = new System.Drawing.Size(180, 22);
            this.mnuYeniKayit.Text = "Yeni Kayıt";
            // 
            // mnuKayitDuzenle
            // 
            this.mnuKayitDuzenle.Name = "mnuKayitDuzenle";
            this.mnuKayitDuzenle.Size = new System.Drawing.Size(180, 22);
            this.mnuKayitDuzenle.Text = "Kayıt Düzenle";
            // 
            // mnuKayitSil
            // 
            this.mnuKayitSil.Name = "mnuKayitSil";
            this.mnuKayitSil.Size = new System.Drawing.Size(180, 22);
            this.mnuKayitSil.Text = "Kayıt Sil";
            this.mnuKayitSil.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuYenile
            // 
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.Size = new System.Drawing.Size(180, 22);
            this.mnuYenile.Text = "Yenile";
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
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(180, 22);
            this.mnuCikis.Text = "Çıkış";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 377);
            this.dataGridView1.TabIndex = 3;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

