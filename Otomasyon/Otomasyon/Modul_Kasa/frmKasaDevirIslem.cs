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
    public partial class frmKasaDevirIslem : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;

        public frmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI hareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                hareket.ACIKLAMA = txtAciklama.Text;
                hareket.BELGENO = txtBelgeNo.Text;
                hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) hareket.GCKODU = "C";
                if (rbtnGiris.Checked) hareket.GCKODU = "G";
                hareket.KASAID = KasaID;
                hareket.TARIH = DateTime.Parse(txtTarih.Text);
                hareket.TUTAR = decimal.Parse(txtTutar.Text);
                hareket.SAVEDATE = DateTime.Now;
                hareket.SAVEUSER = AnaForm.UserID;
                db.TBL_KASAHAREKETLERIs.InsertOnSubmit(hareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Devir Kartı Hareket Kaydı İşlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI hareket = db.TBL_KASAHAREKETLERIs.First(s=>s.ID == IslemID);
                hareket.ACIKLAMA = txtAciklama.Text;
                hareket.BELGENO = txtBelgeNo.Text;
                hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) hareket.GCKODU = "C";
                if (rbtnGiris.Checked) hareket.GCKODU = "G";
                hareket.KASAID = KasaID;
                hareket.TARIH = DateTime.Parse(txtTarih.Text);
                hareket.TUTAR = decimal.Parse(txtTutar.Text);
                hareket.EDITDATE = DateTime.Now;
                hareket.EDITUSER = AnaForm.UserID;
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
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.TBL_KASAHAREKETLERI hareket = db.TBL_KASAHAREKETLERIs.First(s=>s.ID==IslemID);
                txtAciklama.Text = hareket.ACIKLAMA;
                txtBelgeNo.Text = hareket.BELGENO;
                KasaAc(hareket.KASAID.Value);
                txtTarih.Text = hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = hareket.TUTAR.Value.ToString();
                if (hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (hareket.GCKODU == "C") rbtnCikis.Checked = true;
            }
            catch (Exception ex)
            {
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

            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}
