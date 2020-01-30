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

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in db.TBL_STOKLARs
                      where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
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
    }
}
