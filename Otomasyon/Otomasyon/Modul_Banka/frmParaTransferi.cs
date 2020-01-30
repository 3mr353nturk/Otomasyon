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
    public partial class frmParaTransferi : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;

        public frmParaTransferi()
        {
            InitializeComponent();
        }

        private void txtTransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTuru.SelectedIndex == 0)
            {
                rbtnGelen.Text = "Gelen Havale";
                rbtnGiden.Text = "Giden Havale";
            }
            else if(txtTransferTuru.SelectedIndex == 1)
            {
                rbtnGelen.Text = "Gelen EFT";
                rbtnGiden.Text = "Giden EFT";
            }
        }

        private void frmParaTransferi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            CariID = -1;
            AnaForm.Aktarma = -1;
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = db.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = db.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
                txtCariAdi.Text = db.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI banka = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                banka.ACIKLAMA = txtAciklama.Text;
                banka.BANKAID = BankaID;
                banka.BELGENO = txtBelgeNo.Text;
                banka.CARIID = CariID;
                banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) banka.GCKODU = "C";
                if (rbtnGiden.Checked) banka.GCKODU = "G";
                banka.TARIH = DateTime.Parse(txtTarih.Text);
                banka.TUTAR = decimal.Parse(txtTutar.Text);
                banka.SAVEDATE = DateTime.Now;
                banka.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKAHAREKETLERIs.InsertOnSubmit(banka);
                db.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI cari = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) cari.BORC = decimal.Parse(txtTutar.Text);
                cari.CARIID = CariID;
                cari.EVRAKID = banka.ID;
                cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) cari.TIPI = "EFT";
                cari.SAVEDATE = DateTime.Now;
                cari.SAVEUSER = AnaForm.UserID;
                db.TBL_CARIHAREKETLERIs.InsertOnSubmit(cari);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Para transfer kaydı işlendi.");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI banka = db.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                banka.ACIKLAMA = txtAciklama.Text;
                banka.BANKAID = BankaID;
                banka.BELGENO = txtBelgeNo.Text;
                banka.CARIID = CariID;
                banka.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) banka.GCKODU = "C";
                if (rbtnGiden.Checked) banka.GCKODU = "G";
                banka.TARIH = DateTime.Parse(txtTarih.Text);
                banka.TUTAR = decimal.Parse(txtTutar.Text);
                banka.EDITDATE = DateTime.Now;
                banka.EDITUSER = AnaForm.UserID;
                db.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI cari = db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID);
                cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) cari.BORC = decimal.Parse(txtTutar.Text);
                cari.CARIID = CariID;
                cari.EVRAKID = banka.ID;
                cari.EVRAKTURU = txtTransferTuru.SelectedItem.ToString();
                cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTuru.SelectedIndex == 0) cari.TIPI = "BH";
                if (txtTransferTuru.SelectedIndex == 1) cari.TIPI = "EFT";
                cari.EDITDATE = DateTime.Now;
                cari.EDITUSER = AnaForm.UserID;
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
                db.TBL_CARIHAREKETLERIs.DeleteOnSubmit(db.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTransferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID));
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
                CariAc(hareket.CARIID.Value);
                txtAciklama.Text = hareket.ACIKLAMA;
                txtBelgeNo.Text = hareket.BELGENO;
                txtTarih.Text = hareket.TARIH.Value.ToShortDateString();
                txtTransferTuru.Text = hareket.EVRAKTURU;
                txtTutar.Text = hareket.TUTAR.Value.ToString();
                if (hareket.GCKODU == "G") rbtnGelen.Checked = true;
                if (hareket.GCKODU == "C") rbtnGiden.Checked = true;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
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

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}
