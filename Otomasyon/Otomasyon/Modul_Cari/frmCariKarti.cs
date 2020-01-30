using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public frmCariKarti()
        {
            InitializeComponent();
        }

        private void frmCariKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
        }

        void Temizle()
        {
            foreach (Control ct in groupControl1.Controls)
                if (ct is DevExpress.XtraEditors.TextEdit || ct is DevExpress.XtraEditors.ButtonEdit) ct.Text = "";
            foreach (Control ct in groupControl2.Controls)
                if (ct is DevExpress.XtraEditors.TextEdit || ct is DevExpress.XtraEditors.ButtonEdit || ct is DevExpress.XtraEditors.MemoEdit) ct.Text = "";
            Edit = false;
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = new Fonksiyonlar.TBL_CARILER();
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKODU = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtIlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.VERGIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIMAIL1 = txtYetkiliMail1.Text;
                Cari.YETKILIMAIL2 = txtYetkiliMail2.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                db.TBL_CARILERs.InsertOnSubmit(Cari);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_CARILER Cari = db.TBL_CARILERs.First(s=>s.ID == CariID);
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKODU = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtIlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.VERGIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIMAIL1 = txtYetkiliMail1.Text;
                Cari.YETKILIMAIL2 = txtYetkiliMail2.Text;
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
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
                db.TBL_CARILERs.DeleteOnSubmit(db.TBL_CARILERs.First(s => s.ID == CariID));
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
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = db.TBL_CARIGRUPLARIs.First(s => s.ID == GrupID);
                txtCariGrupAdi.Text = Grup.GRUPADI;
                txtCariGrupKodu.Text = Grup.GRUPKODU;
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
                Edit = true;
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = db.TBL_CARILERs.First(s => s.ID == CariID);
                txtAdres.Text = Cari.ADRES;
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
                txtFax1.Text = Cari.FAX1;
                txtFax2.Text = Cari.FAX2;
                txtIlce.Text = Cari.ILCE;
                txtMailInfo.Text = Cari.MAILINFO;
                txtSehir.Text = Cari.SEHIR;
                txtTelefon1.Text = Cari.TELEFON1;
                txtTelefon2.Text = Cari.TELEFON2;
                txtUlke.Text = Cari.ULKE;
                txtVergiDairesi.Text = Cari.VERGIDAIRESI;
                txtVergiNo.Text = Cari.VERGINO;
                txtWebAdres.Text = Cari.WEBADRES;
                txtYetkili1.Text = Cari.YETKILI1;
                txtYetkili2.Text = Cari.YETKILI2;
                txtYetkiliMail1.Text = Cari.YETKILIMAIL1;
                txtYetkiliMail2.Text = Cari.YETKILIMAIL2;
                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }
    }
}
