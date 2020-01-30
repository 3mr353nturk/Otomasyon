using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmCariGruplari()
        {
            InitializeComponent();
            Listele();
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

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_CARIGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                grup.GRUPADI = txtCariAdi.Text;
                grup.GRUPKODU = txtCariKodu.Text;
                grup.SAVEDATE = DateTime.Now;
                grup.SAVEUSER = AnaForm.UserID;
                db.TBL_CARIGRUPLARIs.InsertOnSubmit(grup);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_CARIGRUPLARI grup = db.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID);
                grup.GRUPKODU = txtCariKodu.Text;
                grup.GRUPADI = txtCariAdi.Text;
                grup.EDITUSER = AnaForm.UserID;
                grup.EDITDATE = DateTime.Now;
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
                db.TBL_CARIGRUPLARIs.DeleteOnSubmit(db.TBL_CARIGRUPLARIs.First(s => s.ID == SecimID));
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
                txtCariAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtCariKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}
