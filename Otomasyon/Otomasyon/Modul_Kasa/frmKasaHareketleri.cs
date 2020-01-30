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
    public partial class frmKasaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int HareketID = -1;
        int EvrakID = -1;
        int KasaID = -1;
        string EvrakTuru;

        public frmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }

        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = db.TBL_KASALARs.First(s=>s.ID == KasaID).KASAKODU;
                txtKasaAdi.Text = db.TBL_KASALARs.First(s=>s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM kasa = db.VW_KASADURUMs.First(s => s.KASAID == KasaID);
            txtGiris.Text = kasa.GIRIS.Value.ToString();
            txtCikis.Text = kasa.CIKIS.Value.ToString();
            txtBakiye.Text = kasa.BAKIYE.Value.ToString();
        }

        void Listele()
        {
            var lst = from s in db.VW_KASAHAREKETLERIs
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if(ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());
                }
                catch (Exception)
                {
                    EvrakID = -1;
                }
                EvrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                EvrakTuru = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if(EvrakTuru == "Kasa Devir Kartı")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled = false;
            }
            else if (EvrakTuru == "Kasa Tahsilat" || EvrakTuru == "Kasa Ödeme")
            {
                DevirKartiDuzenle.Enabled = false;
                TahsilatOdemeDuzenle.Enabled = true;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaDevirIslemKarti(true,HareketID);
            Listele();
        }

        private void TahsilatOdemeDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti(true, HareketID);
            Listele();
        }
    }
}
