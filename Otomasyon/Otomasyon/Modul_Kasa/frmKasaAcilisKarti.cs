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
    public partial class frmKasaAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int SecimID = -1;

        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numara.KasaKodNumarasi();
            Listele();

        }
        void Temizle()
        {
            txtKasaKodu.Text = Numara.KasaKodNumarasi();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR kasa = new Fonksiyonlar.TBL_KASALAR();
                kasa.KASAKODU = txtKasaKodu.Text;
                kasa.KASAADI = txtKasaAdi.Text;
                kasa.ACIKLAMA = txtAciklama.Text;
                kasa.SAVEDATE = DateTime.Now;
                kasa.SAVEUSER = AnaForm.UserID;
                db.TBL_KASALARs.InsertOnSubmit(kasa);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_KASALAR kasa = db.TBL_KASALARs.First(s => s.ID == SecimID);
                kasa.KASAKODU = txtKasaKodu.Text;
                kasa.KASAADI = txtKasaAdi.Text;
                kasa.ACIKLAMA = txtAciklama.Text;
                kasa.EDITDATE = DateTime.Now;
                kasa.EDITUSER = AnaForm.UserID;
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
                db.TBL_KASALARs.DeleteOnSubmit(db.TBL_KASALARs.First(s => s.ID == SecimID));
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
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                //txtAciklama.Text = db.TBL_KASALARs.First(s=>s.ID == SecimID).ACIKLAMA;
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in db.TBL_KASALARs
                      select s;
            Liste.DataSource = lst;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaAdi.Text != "" && txtAciklama.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else YeniKaydet();
            }
            else MessageBox.Show("Kasa adı ve açıklama girilmesi gereklidir.","İşlem Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
