using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        AnaForm MesajForm = new AnaForm();
        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("Yeni Kayıt Girişi", Mesaj);
            //MessageBox.Show(,"Yeni Kayıt Girişi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kalıcı olarak güncellenecektir\n Güncelleme işlemini onaylıyor musunuz?","Güncelleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir\n Silme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir.");
            //MessageBox.Show("Kayıt Güncellenmiştir.","Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu.", Hata.Message);
            //MessageBox.Show(Hata.Message, "Hata Oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FormAcilis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu açıldı.");
        }
        public void FormKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu kapatıldı.");
        }
    }
}
