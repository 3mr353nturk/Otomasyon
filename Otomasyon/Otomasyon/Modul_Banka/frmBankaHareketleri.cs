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
    public partial class frmBankaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int IslemID = -1;
        int BankaID = -1;
        string EvrakTuru;

        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            var lst = from s in db.VW_BANKAHAREKETLERIs
                      where s.BANKAID == BankaID
                      select s;
            Liste.DataSource = lst;
        }

        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI banka = db.VW_BANKALISTESIs.First(s=>s.ID==BankaID);
                txtHesapNo.Text = banka.HESAPNO;
                txtHesapAdi.Text = banka.HESAPADI;
                txtGiris.Text = banka.GIRIS.Value.ToString();
                txtCikis.Text = banka.CIKIS.Value.ToString();
                txtBakiye.Text = banka.BAKIYE.Value.ToString();
                Listele();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        void Sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                EvrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                IslemID = -1;
                EvrakTuru = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (IslemID > 0)
            {
                if (EvrakTuru == "Banka İşlemi")
                {
                    BankaIsleminiDuzenle.Enabled = true;
                    BankaParaTransferiniDuzenle.Enabled = false;
                }
                else if (EvrakTuru == "Banka Havale" || EvrakTuru == "Banka EFT")
                {
                    BankaIsleminiDuzenle.Enabled = false;
                    BankaParaTransferiniDuzenle.Enabled = true;
                } 
            }
        }

        private void BankaIsleminiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true, IslemID);
            Listele();
        }

        private void BankaParaTransferiniDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            Listele();
        }
    }
}
