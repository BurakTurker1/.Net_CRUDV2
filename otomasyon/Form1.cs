using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            urun yeniUrun = new urun();
            yeniUrun.uBarkod = txtBarkod.Text;
            yeniUrun.uAd = txtad.Text.Trim();
            yeniUrun.uMiktar = Convert.ToInt32(txtMiktar.Text.Trim());
            yeniUrun.uBrimFiyat = Convert.ToInt32(txtBirimFiyat.Text.Trim());
            yeniUrun.uSITarih = DateTime.Now;
            otomasyonEntities2 vt = new otomasyonEntities2();
            vt.urun.Add(yeniUrun);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                lblUyarı.Text = "kayıt başarıyla eklendi";
                temizle();

            }
            else
            {
                lblUyarı.Text = "kayıt eklenemedi";
            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            otomasyonEntities2 vt = new otomasyonEntities2();
            GvListele.DataSource = vt.urun.ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int silurunId = Convert.ToInt32(lbl_ID2.Text);
            otomasyonEntities2 vt = new otomasyonEntities2();
            urun silinecekUrun = vt.urun.FirstOrDefault(p => p.uID == silurunId);
            vt.urun.Remove(silinecekUrun);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                lblUyarı.Text = "urun başarıyla silindi";
                temizle();

            }
            else
            {
                lblUyarı.Text = "urun silinemedi";
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekUrunId = Convert.ToInt32(lbl_ID2.Text);
            otomasyonEntities2 vt = new otomasyonEntities2();
            urun guncelUrun = vt.urun.FirstOrDefault(p => p.uID == guncellenecekUrunId);
            guncelUrun.uBarkod = txtBarkod.Text;
            guncelUrun.uAd = txtad.Text.Trim();
            guncelUrun.uMiktar = Convert.ToInt32(txtMiktar.Text.Trim());
            guncelUrun.uBrimFiyat = Convert.ToInt32(txtBirimFiyat.Text.Trim());
            guncelUrun.uSITarih = DateTime.Now;
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                lblUyarı.Text = "urun güncellendi ";
                temizle();
            }
            else
            {
                lblUyarı.Text = "urun güncellenemedi";
            }
        }

        public void temizle()
        {
            txtad.Text = "";
            txtBarkod.Text = "";
            txtBirimFiyat.Text = "";
            txtMiktar.Text = "";
            lbl_ID2.Text = "";
        }
        string silinecekUrunNO;
        private void GvListele_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                silinecekUrunNO = GvListele.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void GvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID2.Text = GvListele.CurrentRow.Cells["uID"].Value.ToString();
            txtad.Text = GvListele.CurrentRow.Cells[1].Value.ToString();
            txtMiktar.Text = GvListele.CurrentRow.Cells[2].Value.ToString();
            txtBirimFiyat.Text = GvListele.CurrentRow.Cells[3].Value.ToString();
            txtBarkod.Text = GvListele.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananBarkod = txtBarkod.Text.Trim();

            if (string.IsNullOrEmpty(arananBarkod))
            {
                MessageBox.Show("Lütfen bir barkod girin.");
                return;
            }

            using (otomasyonEntities2 context = new otomasyonEntities2())
            {
                var urunler = context.urun.Where(u => u.uBarkod == arananBarkod).ToList();

                if (urunler.Count > 0)
                {
                    GvListele.DataSource = urunler;
                }
                else
                {
                    MessageBox.Show("Aranan barkoda uygun ürün bulunamadı.");
                }
            }

        }
    }
}
