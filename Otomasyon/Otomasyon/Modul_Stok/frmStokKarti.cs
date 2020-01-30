using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int StokID = -1;

        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKodu.Text = Numara.StokKodNumarasi();
            Mesajlar.FormAcilis(this.Text);
        }

        void Temizle()
        {
            txtStokKodu.Text = Numara.StokKodNumarasi();
            txtStokAdi.Text = "";
            txtStokGrupKodu.Text = "";
            txtStokGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            txtAlisKDV.Text = "";
            txtSatisKDV.Text = "";
            Edit = false;
            Resim = false;
            pictureBox1.Image = null;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR stok = new Fonksiyonlar.TBL_STOKLAR();
                stok.STOKADI = txtStokAdi.Text;
                stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                stok.STOKBARKOD = txtBarkod.Text;
                stok.STOKBIRIM = txtBirim.Text;
                stok.STOKGRUPID = GrupID;
                stok.STOKKODU = txtStokKodu.Text;
                stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                stok.STOKSAVEDATE = DateTime.Now;
                stok.STOKSAVEUSER = AnaForm.UserID;
                db.TBL_STOKLARs.InsertOnSubmit(stok);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Stok Kaydı Oluşturuldu.");
                Temizle();

            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR stok = db.TBL_STOKLARs.First(s=>s.ID == StokID);
                stok.STOKADI = txtStokAdi.Text;
                stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                stok.STOKBARKOD = txtBarkod.Text;
                stok.STOKBIRIM = txtBirim.Text;
                stok.STOKGRUPID = GrupID;
                stok.STOKKODU = txtStokKodu.Text;
                if (Resim) stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                stok.STOKEDITDATE = DateTime.Now;
                stok.STOKEDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();

            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Sil()
        {
            try
            {
                db.TBL_STOKLARs.DeleteOnSubmit(db.TBL_STOKLARs.First(s => s.ID == StokID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtStokGrupAdi.Text = db.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPADI;
            txtStokGrupKodu.Text = db.TBL_STOKGRUPLARIs.First(s => s.ID == GrupID).GRUPKODU;
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR stok = db.TBL_STOKLARs.First(s => s.ID == StokID);
            GrupAc(stok.STOKGRUPID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(stok.STOKRESIM.ToArray());
            txtAlisFiyat.Text = stok.STOKALISFIYAT.ToString();
            txtAlisKDV.Text = stok.STOKALISKDV.ToString();
            txtBarkod.Text = stok.STOKBARKOD.ToString();
            txtBirim.Text = stok.STOKBIRIM;
            txtSatisFiyat.Text = stok.STOKSATISFIYAT.ToString();
            txtSatisKDV.Text = stok.STOKSATISKDV.ToString();
            txtStokAdi.Text = stok.STOKADI;
            txtStokKodu.Text = stok.STOKKODU;
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);  
            }
            AnaForm.Aktarma = -1;
        }

        private void txtStokGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void frmStokKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesajlar.FormKapanis(this.Text);
        }
    }
}
