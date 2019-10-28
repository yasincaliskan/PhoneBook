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
    public partial class frmDuzenle : Form
    {
        public Kisi GuncellenecekKisi { get; set; }

        public frmDuzenle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.GuncellenecekKisi.Ad = this.txtAd.Text;
            this.GuncellenecekKisi.Soyad = this.txtSoyad.Text;
            this.GuncellenecekKisi.TelefonNo = this.txtTelNo.Text;

            System.IO.File.Create(Application.StartupPath + @"\kayitlar.txt");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmDuzenle_Load(object sender, EventArgs e)
        {
            if (this.GuncellenecekKisi != null)
            {
                this.txtAd.Text = this.GuncellenecekKisi.Ad;
                this.txtSoyad.Text = this.GuncellenecekKisi.Soyad;
                this.txtTelNo.Text = this.GuncellenecekKisi.TelefonNo;
            }
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
