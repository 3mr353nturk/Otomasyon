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
    public partial class frmBankaKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int SecimID = -1;

        public frmBankaKarti()
        {
            InitializeComponent();
        }

        private void frmBankaKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "";
            txtSube.Text = "";
            txtTelefon.Text = "";
            txtTemsilci.Text = "";
            txtTemsilciEmail.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_BANKALARs
                      select s;
            Liste.DataSource = lst;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR banka = new Fonksiyonlar.TBL_BANKALAR();
                banka.ADRES = txtAdres.Text;
                banka.BANKAADI = txtBankaAdi.Text;
                banka.HESAPADI = txtHesapAdi.Text;
                banka.HESAPNO = txtHesapNo.Text;
                banka.IBAN = txtIBAN.Text;
                banka.SUBE = txtSube.Text;
                banka.TELEFON = txtTelefon.Text;
                banka.TEMSILCI = txtTemsilci.Text;
                banka.TEMSILCIEMAIL = txtTemsilciEmail.Text;
                banka.SAVEDATE = DateTime.Now;
                banka.SAVEUSER = AnaForm.UserID;
                db.TBL_BANKALARs.InsertOnSubmit(banka);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni banka kaydı açılmıştır.");
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
                Fonksiyonlar.TBL_BANKALAR banka = db.TBL_BANKALARs.First(s=>s.ID == SecimID);
                banka.ADRES = txtAdres.Text;
                banka.BANKAADI = txtBankaAdi.Text;
                banka.HESAPADI = txtHesapAdi.Text;
                banka.HESAPNO = txtHesapNo.Text;
                banka.IBAN = txtIBAN.Text;
                banka.SUBE = txtSube.Text;
                banka.TELEFON = txtTelefon.Text;
                banka.TEMSILCI = txtTemsilci.Text;
                banka.TEMSILCIEMAIL = txtTemsilciEmail.Text;
                banka.EDITDATE = DateTime.Now;
                banka.EDITUSER = AnaForm.UserID;
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
                db.TBL_BANKALARs.DeleteOnSubmit(db.TBL_BANKALARs.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                if (SecimID > 0) Ac();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR banka = db.TBL_BANKALARs.First(s => s.ID == SecimID);
                txtAdres.Text = banka.ADRES;
                txtBankaAdi.Text = banka.BANKAADI;
                txtHesapAdi.Text = banka.HESAPADI;
                txtHesapNo.Text = banka.HESAPNO;
                txtIBAN.Text = banka.IBAN;
                txtSube.Text = banka.SUBE;
                txtTelefon.Text = banka.TELEFON;
                txtTemsilci.Text = banka.TEMSILCI;
                txtTemsilciEmail.Text = banka.TEMSILCIEMAIL;
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
