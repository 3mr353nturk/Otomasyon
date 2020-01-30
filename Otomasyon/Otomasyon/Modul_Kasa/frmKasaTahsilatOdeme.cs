using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaTahsilatOdeme : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int IslemID = -1;
        int CariHareketID = -1;
        int KasaID = -1;
        int CariID = -1;


        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void frmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;

        }

        public void Ac(int hareketID)
        {
            try
            {
                Edit = true;
                IslemID = hareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERI hareket = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                CariHareketID = db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == hareket.EVRAKTURU && s.EVRAKID == IslemID).ID;
                MessageBox.Show("Cari Hareket ID : " + CariHareketID.ToString());
                txtAciklama.Text = hareket.ACIKLAMA;
                txtBelgeNo.Text = hareket.BELGENO;      
                if (hareket.EVRAKTURU == "Kasa Tahsilat") txtIslemTuru.SelectedIndex = 0;
                if (hareket.EVRAKTURU == "Kasa Ödeme") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = hareket.TUTAR.Value.ToString();
                KasaAc(hareket.KASAID.Value);
                CariAc(hareket.CARIID.Value);
            }
            catch (Exception ex)
            {
                Temizle();
                Mesajlar.Hata(ex);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = db.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {
                KasaID = -1;
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdi.Text = db.TBL_CARILERs.First(s => s.ID == KasaID).CARIADI;
                txtCariKodu.Text = db.TBL_CARILERs.First(s => s.ID == KasaID).CARIKODU;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI kasaHareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                kasaHareket.ACIKLAMA = txtAciklama.Text;
                kasaHareket.BELGENO = txtBelgeNo.Text;
                kasaHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) kasaHareket.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) kasaHareket.GCKODU = "C";
                kasaHareket.KASAID = KasaID;
                kasaHareket.CARIID = CariID;
                kasaHareket.TARIH = DateTime.Parse(txtTarih.Text);
                kasaHareket.TUTAR = decimal.Parse(txtTutar.Text);
                kasaHareket.SAVEDATE = DateTime.Now;
                kasaHareket.SAVEUSER = AnaForm.UserID;
                db.TBL_KASAHAREKETLERIs.InsertOnSubmit(kasaHareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString() + " yeni kasa hareketi işlenmiştir.");
                Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                cariHareket.ACIKLAMA = txtBelgeNo.Text + "belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) cariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) cariHareket.BORC = decimal.Parse(txtTutar.Text);
                cariHareket.CARIID = CariID;
                cariHareket.EVRAKID = kasaHareket.ID;
                cariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                cariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) cariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) cariHareket.TIPI = "KÖ";
                cariHareket.SAVEDATE = DateTime.Now;
                cariHareket.SAVEUSER = AnaForm.UserID;
                db.TBL_CARIHAREKETLERIs.InsertOnSubmit(cariHareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString() + " yeni cari hareketi işlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI kasaHareket = db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID);
                kasaHareket.ACIKLAMA = txtAciklama.Text;
                kasaHareket.BELGENO = txtBelgeNo.Text;
                kasaHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) kasaHareket.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) kasaHareket.GCKODU = "C";
                kasaHareket.KASAID = KasaID;
                kasaHareket.CARIID = CariID;
                kasaHareket.TARIH = DateTime.Parse(txtTarih.Text);
                kasaHareket.TUTAR = decimal.Parse(txtTutar.Text);
                kasaHareket.EDITDATE = DateTime.Now;
                kasaHareket.EDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Fonksiyonlar.TBL_CARIHAREKETLERI cariHareket = db.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID);
                cariHareket.ACIKLAMA = txtBelgeNo.Text + "belge numaralı " + txtIslemTuru.SelectedItem.ToString() + " işlemi";
                if (txtIslemTuru.SelectedIndex == 0) cariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) cariHareket.BORC = decimal.Parse(txtTutar.Text);
                cariHareket.CARIID = CariID;
                cariHareket.EVRAKID = kasaHareket.ID;
                cariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                cariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) cariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) cariHareket.TIPI = "KÖ";
                cariHareket.EDITDATE = DateTime.Now;
                cariHareket.EDITUSER = AnaForm.UserID;
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
                db.TBL_KASAHAREKETLERIs.DeleteOnSubmit(db.TBL_KASAHAREKETLERIs.First(s => s.ID == IslemID));
                db.TBL_CARIHAREKETLERIs.DeleteOnSubmit(db.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if(Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
