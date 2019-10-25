using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class frmYeniKayit : Form
    {

        public Kisi YeniKisi { get; set; }

        public frmYeniKayit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.YeniKisi = new Kisi();

            this.YeniKisi.Id = Guid.NewGuid();
            this.YeniKisi.Ad = txtAd.Text.ToString();
            this.YeniKisi.Soyad = txtSoyad.Text.ToString();
            this.YeniKisi.TelefonNo = txtTelNo.Text.ToString();

            string[] kisi = new string[4];

            System.IO.File.Create(Application.StartupPath + @"\kayitlar.txt");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;

            if (txt != null)
            {
                txt.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;

            if (txt != null)
            {
                txt.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;

            if (txt != null)
            {
                txt.Paste();
            }
        }
    }
}
