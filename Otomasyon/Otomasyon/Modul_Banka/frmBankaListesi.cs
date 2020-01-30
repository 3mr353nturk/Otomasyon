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
    public partial class frmBankaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.VW_BANKALISTESIs
                      where s.HESAPADI.Contains(txtHesapAdi.Text) &&
                      s.HESAPNO.Contains(txtHesapNo.Text) &&
                      s.IBAN.Contains(txtIBAN.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
