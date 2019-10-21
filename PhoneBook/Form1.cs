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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable("Kisiler");
            //DataColumn dcId = new DataColumn("Id");
            //DataColumn dcAd = new DataColumn("Ad");
            //DataColumn dcSoyad = new DataColumn("Soyad");
            //DataColumn dcTelNo = new DataColumn("TelefonNo");

            //dt.Columns.Add(dcId);
            //dt.Columns.Add(dcAd);
            //dt.Columns.Add(dcSoyad);
            //dt.Columns.Add(dcTelNo);

            //ds.Tables.Add(dt);

            //this.dataGridView1.DataSource = dt;

            VerileriYukle();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mnuYenile_Click(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit frm = new frmYeniKayit();
            DialogResult sonuc = frm.ShowDialog();

            if (sonuc == System.Windows.Forms.DialogResult.OK)
            {
                Kisi yeniKisi = frm.YeniKisi;

                DataTable dt = this.dataGridView1.DataSource as DataTable;

                DataRow dr = dt.NewRow();
                dr[0] = yeniKisi.Id;
                dr[1] = yeniKisi.Ad;
                dr[2] = yeniKisi.Soyad;
                dr[3] = yeniKisi.TelefonNo;

                dt.Rows.Add(dr);

                this.KayitSayisiHesaplama();

                this.lblSonIslemBilgi.Text = "Yeni kayıt eklendi.";

            }

        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell != null)
            {
               
                frmDuzenle frm = new frmDuzenle();
                frm.GuncellenecekKisi = new Kisi();
                frm.GuncellenecekKisi.Ad = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.GuncellenecekKisi.Soyad = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.GuncellenecekKisi.TelefonNo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                DialogResult sonuc = frm.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;

                    dr[1] = frm.GuncellenecekKisi.Ad;
                    dr[2] = frm.GuncellenecekKisi.Soyad;
                    dr[3] = frm.GuncellenecekKisi.TelefonNo;

                    this.lblSonIslemBilgi.Text = "Kayıt düzenlendi.";

                }
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?","Kayıt Silme",MessageBoxButtons.YesNoCancel);

                if (sonuc == DialogResult.Yes)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;

                    dr.Delete();

                    this.KayitSayisiHesaplama();

                    this.lblSonIslemBilgi.Text = "Kayıt silindi.";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ds.WriteXml(Application.StartupPath + "\\" + "data.xml", XmlWriteMode.WriteSchema);
            this.lblSonIslemBilgi.Text = "Veriler kaydedildi.";
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            this.lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayitSayisiHesaplama()
        {
            this.lblKayitSayisi.Text = "Kayıt sayısı: " + this.dataGridView1.RowCount.ToString();
            
        }

        private void VerileriYukle()
        {
            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);

            if (ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
                this.KayitSayisiHesaplama();

                this.lblSonIslemBilgi.Text = "Veriler yüklendi.";
            }
        }

        private void mnuProgramBilgi_Click(object sender, EventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.ShowDialog();
        }
    }
}
