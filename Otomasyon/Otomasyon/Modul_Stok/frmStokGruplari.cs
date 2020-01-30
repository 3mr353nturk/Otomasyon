using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_STOKGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }

        void Temizle()
        {
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            Edit = false;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKGRUPLARI grup = new Fonksiyonlar.TBL_STOKGRUPLARI();
                grup.GRUPADI = txtGrupAdi.Text;
                grup.GRUPKODU = txtGrupKodu.Text;
                grup.GRUPSAVEDATE = DateTime.Now;
                grup.GRUPSAVEUSER = AnaForm.UserID;
                db.TBL_STOKGRUPLARIs.InsertOnSubmit(grup);
                db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu.");
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
                Fonksiyonlar.TBL_STOKGRUPLARI grup = db.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID);
                grup.GRUPKODU = txtGrupKodu.Text;
                grup.GRUPADI = txtGrupAdi.Text;
                grup.GRUPEDITUSER = AnaForm.UserID;
                grup.GRUPEDITDATE = DateTime.Now;
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
                db.TBL_STOKGRUPLARIs.DeleteOnSubmit(db.TBL_STOKGRUPLARIs.First(s => s.ID == SecimID));
                db.SubmitChanges();
                Temizle();
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
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
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
