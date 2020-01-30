using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Banka
{
    public partial class frmBankaIslemi : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;

        public frmBankaIslemi()
        {
            InitializeComponent();
        }

        private void frmBankaIslemi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                hareket.ACIKLAMA = txtAciklama.Text;
                hareket.BANKAID = BankaID;
                hareket.BELGENO = txtBelgeNo.Text;
                hareket.EVRAKTURU = "Banka İşlemi";
                if (rbtnCikis.Checked) hareket.GCKODU = "C";
                if (rbtnGiris.Checked) hareket.GCKODU = "G";            
                hareket.TARIH = DateTime.Parse(txtTarih.Text);
                hareket.TUTAR = decimal.Parse(txtTutar.Text);
                hareket.SAVEDATE = DateTime.Now;
                hareket.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKAHAREKETLERIs.InsertOnSubmit(hareket);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Banka işlemi kaydı yapılmıştır.");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI hareket = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                hareket.ACIKLAMA = txtAciklama.Text;
                hareket.BANKAID = BankaID;
                hareket.BELGENO = txtBelgeNo.Text;
                hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) hareket.GCKODU = "C";
                if (rbtnGiris.Checked) hareket.GCKODU = "G";               
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
                db.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI hareket = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(hareket.BANKAID.Value);
                txtAciklama.Text = hareket.ACIKLAMA;
                txtBelgeNo.Text = hareket.BELGENO;
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

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception)
            {

            }
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

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0)
            {
                BankaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}
