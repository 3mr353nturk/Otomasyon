using Otomasyon.Fonksiyonlar;

namespace Otomasyon
{
    partial class AnaForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankaKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnParaTransferi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankaIslemi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKasaAcilisKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKasaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKasaDevirIslemKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKasaTahsilatOdeme = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSatisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlisIadeFaturası = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSatisIrsaliyesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlisIrsaliyesi = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtSaat = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnKasaHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage9 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnStokKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnStokListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnStokGruplari = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnCariAcilisKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnCariGruplari = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnCariListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnCariHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnBankaAcilisKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnParaTransferi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnBankaListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnBankaIslemi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnBankaHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBtnKasaAcilisKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnKasaListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnKasaDevirIslem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBtnKasaHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.ALC = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.ribbonPage10 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage11 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barBtnMusteriCeki = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKendiCekimiz = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankayaCekCikisi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariyeCekCikisi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnStokKarti,
            this.barBtnStokListesi,
            this.barBtnStokGruplari,
            this.barBtnStokHareketleri,
            this.barBtnCariKarti,
            this.barBtnCariGruplari,
            this.barBtnCariListesi,
            this.barBtnCariHareketleri,
            this.barBtnBankaKarti,
            this.barBtnParaTransferi,
            this.barBtnBankaListesi,
            this.barBtnBankaIslemi,
            this.barBtnBankaHareketleri,
            this.barBtnKasaAcilisKarti,
            this.barBtnKasaListesi,
            this.barBtnKasaDevirIslemKarti,
            this.barBtnKasaTahsilatOdeme,
            this.barBtnSatisFaturasi,
            this.barBtnSatisIadeFaturasi,
            this.barBtnAlisFaturasi,
            this.barBtnAlisIadeFaturası,
            this.barBtnSatisIrsaliyesi,
            this.barBtnAlisIrsaliyesi,
            this.barStaticItem1,
            this.txtSaat,
            this.barBtnKasaHareketleri,
            this.barBtnMusteriCeki,
            this.barBtnKendiCekimiz,
            this.barBtnBankayaCekCikisi,
            this.barBtnCariyeCekCikisi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 32;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage6,
            this.ribbonPage8,
            this.ribbonPage10});
            this.ribbon.Size = new System.Drawing.Size(993, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnStokKarti
            // 
            this.barBtnStokKarti.Caption = "Stok Kartı";
            this.barBtnStokKarti.Id = 1;
            this.barBtnStokKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Kartı32x32;
            this.barBtnStokKarti.LargeWidth = 100;
            this.barBtnStokKarti.Name = "barBtnStokKarti";
            this.barBtnStokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKarti_ItemClick);
            // 
            // barBtnStokListesi
            // 
            this.barBtnStokListesi.Caption = "Stok Listesi";
            this.barBtnStokListesi.Id = 2;
            this.barBtnStokListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Liste32x32;
            this.barBtnStokListesi.LargeWidth = 100;
            this.barBtnStokListesi.Name = "barBtnStokListesi";
            this.barBtnStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokListesi_ItemClick);
            // 
            // barBtnStokGruplari
            // 
            this.barBtnStokGruplari.Caption = "Stok Grupları";
            this.barBtnStokGruplari.Id = 3;
            this.barBtnStokGruplari.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Grup32x32;
            this.barBtnStokGruplari.LargeWidth = 100;
            this.barBtnStokGruplari.Name = "barBtnStokGruplari";
            this.barBtnStokGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokGruplari_ItemClick);
            // 
            // barBtnStokHareketleri
            // 
            this.barBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.barBtnStokHareketleri.Id = 4;
            this.barBtnStokHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Stok_Hareket32x32;
            this.barBtnStokHareketleri.LargeWidth = 100;
            this.barBtnStokHareketleri.Name = "barBtnStokHareketleri";
            this.barBtnStokHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokHareketleri_ItemClick);
            // 
            // barBtnCariKarti
            // 
            this.barBtnCariKarti.Caption = "Cari Açılış Kartı";
            this.barBtnCariKarti.Id = 5;
            this.barBtnCariKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Kart32x32;
            this.barBtnCariKarti.LargeWidth = 100;
            this.barBtnCariKarti.Name = "barBtnCariKarti";
            this.barBtnCariKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariKarti_ItemClick);
            // 
            // barBtnCariGruplari
            // 
            this.barBtnCariGruplari.Caption = "Cari Grupları";
            this.barBtnCariGruplari.Id = 6;
            this.barBtnCariGruplari.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Grup32x32;
            this.barBtnCariGruplari.LargeWidth = 100;
            this.barBtnCariGruplari.Name = "barBtnCariGruplari";
            this.barBtnCariGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariGruplari_ItemClick);
            // 
            // barBtnCariListesi
            // 
            this.barBtnCariListesi.Caption = "Cari Listesi";
            this.barBtnCariListesi.Id = 7;
            this.barBtnCariListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Liste32x32;
            this.barBtnCariListesi.LargeWidth = 100;
            this.barBtnCariListesi.Name = "barBtnCariListesi";
            this.barBtnCariListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariListesi_ItemClick);
            // 
            // barBtnCariHareketleri
            // 
            this.barBtnCariHareketleri.Caption = "Cari Hareketleri";
            this.barBtnCariHareketleri.Id = 8;
            this.barBtnCariHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cari_Hareket32x32;
            this.barBtnCariHareketleri.LargeWidth = 100;
            this.barBtnCariHareketleri.Name = "barBtnCariHareketleri";
            this.barBtnCariHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariHareketleri_ItemClick);
            // 
            // barBtnBankaKarti
            // 
            this.barBtnBankaKarti.Caption = "Banka Açılış Kartı";
            this.barBtnBankaKarti.Id = 9;
            this.barBtnBankaKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Kartı32x32;
            this.barBtnBankaKarti.LargeWidth = 100;
            this.barBtnBankaKarti.Name = "barBtnBankaKarti";
            this.barBtnBankaKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBankaKarti_ItemClick);
            // 
            // barBtnParaTransferi
            // 
            this.barBtnParaTransferi.Caption = "Para Transferi";
            this.barBtnParaTransferi.Id = 10;
            this.barBtnParaTransferi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Havale32x32;
            this.barBtnParaTransferi.LargeWidth = 100;
            this.barBtnParaTransferi.Name = "barBtnParaTransferi";
            this.barBtnParaTransferi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnParaTransferi_ItemClick);
            // 
            // barBtnBankaListesi
            // 
            this.barBtnBankaListesi.Caption = "Banka Listesi";
            this.barBtnBankaListesi.Id = 11;
            this.barBtnBankaListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Liste32x32;
            this.barBtnBankaListesi.LargeWidth = 100;
            this.barBtnBankaListesi.Name = "barBtnBankaListesi";
            this.barBtnBankaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBankaListesi_ItemClick);
            // 
            // barBtnBankaIslemi
            // 
            this.barBtnBankaIslemi.Caption = "Banka İşlemi";
            this.barBtnBankaIslemi.Id = 12;
            this.barBtnBankaIslemi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Islem32x32;
            this.barBtnBankaIslemi.LargeWidth = 100;
            this.barBtnBankaIslemi.Name = "barBtnBankaIslemi";
            this.barBtnBankaIslemi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBankaIslemi_ItemClick);
            // 
            // barBtnBankaHareketleri
            // 
            this.barBtnBankaHareketleri.Caption = "Banka Hareketleri";
            this.barBtnBankaHareketleri.Id = 13;
            this.barBtnBankaHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Banka_Hareket32x32;
            this.barBtnBankaHareketleri.LargeWidth = 100;
            this.barBtnBankaHareketleri.Name = "barBtnBankaHareketleri";
            this.barBtnBankaHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBankaHareketleri_ItemClick);
            // 
            // barBtnKasaAcilisKarti
            // 
            this.barBtnKasaAcilisKarti.Caption = "Kasa Açılış Kartı";
            this.barBtnKasaAcilisKarti.Id = 14;
            this.barBtnKasaAcilisKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Karti32x32;
            this.barBtnKasaAcilisKarti.LargeWidth = 120;
            this.barBtnKasaAcilisKarti.Name = "barBtnKasaAcilisKarti";
            this.barBtnKasaAcilisKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasaAcilisKarti_ItemClick);
            // 
            // barBtnKasaListesi
            // 
            this.barBtnKasaListesi.Caption = "Kasa Listesi";
            this.barBtnKasaListesi.Id = 15;
            this.barBtnKasaListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Liste32x32;
            this.barBtnKasaListesi.LargeWidth = 120;
            this.barBtnKasaListesi.Name = "barBtnKasaListesi";
            this.barBtnKasaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasaListesi_ItemClick);
            // 
            // barBtnKasaDevirIslemKarti
            // 
            this.barBtnKasaDevirIslemKarti.Caption = "Kasa Devir/İşlem Kartı";
            this.barBtnKasaDevirIslemKarti.Id = 16;
            this.barBtnKasaDevirIslemKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Devir32x32;
            this.barBtnKasaDevirIslemKarti.LargeWidth = 120;
            this.barBtnKasaDevirIslemKarti.Name = "barBtnKasaDevirIslemKarti";
            this.barBtnKasaDevirIslemKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasaDevirIslemKarti_ItemClick);
            // 
            // barBtnKasaTahsilatOdeme
            // 
            this.barBtnKasaTahsilatOdeme.Caption = "Kasa Tahsilat/Ödeme";
            this.barBtnKasaTahsilatOdeme.Id = 17;
            this.barBtnKasaTahsilatOdeme.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Odeme32x32;
            this.barBtnKasaTahsilatOdeme.LargeWidth = 120;
            this.barBtnKasaTahsilatOdeme.Name = "barBtnKasaTahsilatOdeme";
            this.barBtnKasaTahsilatOdeme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasaTahsilatOdeme_ItemClick);
            // 
            // barBtnSatisFaturasi
            // 
            this.barBtnSatisFaturasi.Caption = "Satış Faturası";
            this.barBtnSatisFaturasi.Id = 18;
            this.barBtnSatisFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_Satis32x32;
            this.barBtnSatisFaturasi.LargeWidth = 100;
            this.barBtnSatisFaturasi.Name = "barBtnSatisFaturasi";
            // 
            // barBtnSatisIadeFaturasi
            // 
            this.barBtnSatisIadeFaturasi.Caption = "Satış İade Faturası";
            this.barBtnSatisIadeFaturasi.Id = 19;
            this.barBtnSatisIadeFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_SatisIade32x32;
            this.barBtnSatisIadeFaturasi.LargeWidth = 100;
            this.barBtnSatisIadeFaturasi.Name = "barBtnSatisIadeFaturasi";
            // 
            // barBtnAlisFaturasi
            // 
            this.barBtnAlisFaturasi.Caption = "Alış Faturası";
            this.barBtnAlisFaturasi.Id = 20;
            this.barBtnAlisFaturasi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_Alis32x32;
            this.barBtnAlisFaturasi.LargeWidth = 100;
            this.barBtnAlisFaturasi.Name = "barBtnAlisFaturasi";
            // 
            // barBtnAlisIadeFaturası
            // 
            this.barBtnAlisIadeFaturası.Caption = "Alış İade Faturası";
            this.barBtnAlisIadeFaturası.Id = 21;
            this.barBtnAlisIadeFaturası.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_AlisIade32x32;
            this.barBtnAlisIadeFaturası.LargeWidth = 100;
            this.barBtnAlisIadeFaturası.Name = "barBtnAlisIadeFaturası";
            // 
            // barBtnSatisIrsaliyesi
            // 
            this.barBtnSatisIrsaliyesi.Caption = "Satış İrsaliyesi";
            this.barBtnSatisIrsaliyesi.Id = 22;
            this.barBtnSatisIrsaliyesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_SatisIade32x32;
            this.barBtnSatisIrsaliyesi.LargeWidth = 100;
            this.barBtnSatisIrsaliyesi.Name = "barBtnSatisIrsaliyesi";
            // 
            // barBtnAlisIrsaliyesi
            // 
            this.barBtnAlisIrsaliyesi.Caption = "Alış İrsaliyesi";
            this.barBtnAlisIrsaliyesi.Id = 23;
            this.barBtnAlisIrsaliyesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Fatura_AlisIade32x32;
            this.barBtnAlisIrsaliyesi.LargeWidth = 100;
            this.barBtnAlisIrsaliyesi.Name = "barBtnAlisIrsaliyesi";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Genel Otomasyon Yazılımı";
            this.barStaticItem1.Id = 24;
            this.barStaticItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.barStaticItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.barStaticItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // txtSaat
            // 
            this.txtSaat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtSaat.Caption = "27.01.2020";
            this.txtSaat.Id = 26;
            this.txtSaat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSaat.ItemAppearance.Hovered.Options.UseFont = true;
            this.txtSaat.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSaat.ItemAppearance.Normal.Options.UseFont = true;
            this.txtSaat.Name = "txtSaat";
            // 
            // barBtnKasaHareketleri
            // 
            this.barBtnKasaHareketleri.Caption = "Kasa Hareketleri";
            this.barBtnKasaHareketleri.Id = 27;
            this.barBtnKasaHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Kasa_Hareket32x32;
            this.barBtnKasaHareketleri.Name = "barBtnKasaHareketleri";
            this.barBtnKasaHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasaHareketleri_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = global::Otomasyon.Properties.Resources.Stok32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokGruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = global::Otomasyon.Properties.Resources.Cari32x32;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cari";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCariKarti);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCariGruplari);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCariListesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCariHareketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cari İşlemleri";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.Image = global::Otomasyon.Properties.Resources.Banka32x32;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Banka İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankaKarti);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnParaTransferi);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankaListesi);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankaIslemi);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnBankaHareketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Banka İşlemleri";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage6.Image = global::Otomasyon.Properties.Resources.Kasa32x32;
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Kasa";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnKasaAcilisKarti);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnKasaListesi);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnKasaDevirIslemKarti);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnKasaTahsilatOdeme);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnKasaHareketleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kasa İşlemleri";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage8.Image = global::Otomasyon.Properties.Resources.Fatura32x32;
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "Fatura";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnSatisFaturasi);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnSatisIadeFaturasi);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnAlisFaturasi, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnAlisIadeFaturası);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Fatura İşlemleri";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnSatisIrsaliyesi);
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnAlisIrsaliyesi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "İrsaliye İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtSaat);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 473);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(993, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "ribbonPage7";
            // 
            // ribbonPage9
            // 
            this.ribbonPage9.Name = "ribbonPage9";
            this.ribbonPage9.Text = "ribbonPage9";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBtnStokKarti,
            this.navBtnStokListesi,
            this.navBtnStokGruplari,
            this.navBtnStokHareketleri,
            this.navBtnCariAcilisKarti,
            this.navBtnCariGruplari,
            this.navBtnCariListesi,
            this.navBtnCariHareketleri,
            this.navBtnBankaAcilisKarti,
            this.navBtnParaTransferi,
            this.navBtnBankaListesi,
            this.navBtnBankaIslemi,
            this.navBtnKasaAcilisKarti,
            this.navBtnKasaListesi,
            this.navBtnKasaDevirIslem,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navBtnBankaHareketleri,
            this.navBtnKasaHareketleri});
            this.navBarControl1.Location = new System.Drawing.Point(0, 162);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 185;
            this.navBarControl1.Size = new System.Drawing.Size(185, 311);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("DevExpress Style");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnStokKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnStokListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnStokGruplari),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnStokHareketleri)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBtnStokKarti
            // 
            this.navBtnStokKarti.Caption = "Stok Kartı";
            this.navBtnStokKarti.Name = "navBtnStokKarti";
            this.navBtnStokKarti.SmallImage = global::Otomasyon.Properties.Resources.Stok_Kartı16x16;
            this.navBtnStokKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnStokKarti_LinkClicked);
            // 
            // navBtnStokListesi
            // 
            this.navBtnStokListesi.Caption = "Stok Listesi";
            this.navBtnStokListesi.Name = "navBtnStokListesi";
            this.navBtnStokListesi.SmallImage = global::Otomasyon.Properties.Resources.Stok_Liste16x16;
            this.navBtnStokListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnStokListesi_LinkClicked);
            // 
            // navBtnStokGruplari
            // 
            this.navBtnStokGruplari.Caption = "Stok Grupları";
            this.navBtnStokGruplari.Name = "navBtnStokGruplari";
            this.navBtnStokGruplari.SmallImage = global::Otomasyon.Properties.Resources.Stok_Grup16x16;
            this.navBtnStokGruplari.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnStokGruplari_LinkClicked);
            // 
            // navBtnStokHareketleri
            // 
            this.navBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.navBtnStokHareketleri.Name = "navBtnStokHareketleri";
            this.navBtnStokHareketleri.SmallImage = global::Otomasyon.Properties.Resources.Stok_Hareket16x16;
            this.navBtnStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnStokHareketleri_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnCariAcilisKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnCariGruplari),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnCariListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnCariHareketleri)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBtnCariAcilisKarti
            // 
            this.navBtnCariAcilisKarti.Caption = "Cari Açılış Kartı";
            this.navBtnCariAcilisKarti.Name = "navBtnCariAcilisKarti";
            this.navBtnCariAcilisKarti.SmallImage = global::Otomasyon.Properties.Resources.Cari_Kart16x16;
            this.navBtnCariAcilisKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnCariAcilisKarti_LinkClicked);
            // 
            // navBtnCariGruplari
            // 
            this.navBtnCariGruplari.Caption = "Cari Grupları";
            this.navBtnCariGruplari.Name = "navBtnCariGruplari";
            this.navBtnCariGruplari.SmallImage = global::Otomasyon.Properties.Resources.Cari_Grup16x16;
            this.navBtnCariGruplari.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnCariGruplari_LinkClicked);
            // 
            // navBtnCariListesi
            // 
            this.navBtnCariListesi.Caption = "Cari Listesi";
            this.navBtnCariListesi.Name = "navBtnCariListesi";
            this.navBtnCariListesi.SmallImage = global::Otomasyon.Properties.Resources.Cari_Liste16x16;
            this.navBtnCariListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnCariListesi_LinkClicked);
            // 
            // navBtnCariHareketleri
            // 
            this.navBtnCariHareketleri.Caption = "Cari Hareketleri";
            this.navBtnCariHareketleri.Name = "navBtnCariHareketleri";
            this.navBtnCariHareketleri.SmallImage = global::Otomasyon.Properties.Resources.Cari_Hareket16x16;
            this.navBtnCariHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnCariHareketleri_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Banka";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnBankaAcilisKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnParaTransferi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnBankaListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnBankaIslemi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnBankaHareketleri)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.TopVisibleLinkIndex = 1;
            // 
            // navBtnBankaAcilisKarti
            // 
            this.navBtnBankaAcilisKarti.Caption = "Banka Açılış Kartı";
            this.navBtnBankaAcilisKarti.Name = "navBtnBankaAcilisKarti";
            this.navBtnBankaAcilisKarti.SmallImage = global::Otomasyon.Properties.Resources.Banka_Kartı16x16;
            this.navBtnBankaAcilisKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnBankaAcilisKarti_LinkClicked);
            // 
            // navBtnParaTransferi
            // 
            this.navBtnParaTransferi.Caption = "Para Transferi";
            this.navBtnParaTransferi.Name = "navBtnParaTransferi";
            this.navBtnParaTransferi.SmallImage = global::Otomasyon.Properties.Resources.Banka_Havale16x16;
            this.navBtnParaTransferi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnParaTransferi_LinkClicked);
            // 
            // navBtnBankaListesi
            // 
            this.navBtnBankaListesi.Caption = "Banka Listesi";
            this.navBtnBankaListesi.Name = "navBtnBankaListesi";
            this.navBtnBankaListesi.SmallImage = global::Otomasyon.Properties.Resources.Banka_Liste16x16;
            this.navBtnBankaListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnBankaListesi_LinkClicked);
            // 
            // navBtnBankaIslemi
            // 
            this.navBtnBankaIslemi.Caption = "Banka İşlemi";
            this.navBtnBankaIslemi.Name = "navBtnBankaIslemi";
            this.navBtnBankaIslemi.SmallImage = global::Otomasyon.Properties.Resources.Banka_Islem16x16;
            this.navBtnBankaIslemi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnBankaIslemi_LinkClicked);
            // 
            // navBtnBankaHareketleri
            // 
            this.navBtnBankaHareketleri.Caption = "Banka Hareketleri";
            this.navBtnBankaHareketleri.Name = "navBtnBankaHareketleri";
            this.navBtnBankaHareketleri.SmallImage = global::Otomasyon.Properties.Resources.Banka_Hareket16x16;
            this.navBtnBankaHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnBankaHareketleri_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Kasa";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnKasaAcilisKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnKasaListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnKasaDevirIslem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBtnKasaHareketleri)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBtnKasaAcilisKarti
            // 
            this.navBtnKasaAcilisKarti.Caption = "Kasa Açılış Kartı";
            this.navBtnKasaAcilisKarti.Name = "navBtnKasaAcilisKarti";
            this.navBtnKasaAcilisKarti.SmallImage = global::Otomasyon.Properties.Resources.Kasa_Karti16x16;
            this.navBtnKasaAcilisKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnKasaAcilisKarti_LinkClicked);
            // 
            // navBtnKasaListesi
            // 
            this.navBtnKasaListesi.Caption = "Kasa Listesi";
            this.navBtnKasaListesi.Name = "navBtnKasaListesi";
            this.navBtnKasaListesi.SmallImage = global::Otomasyon.Properties.Resources.Kasa_Liste16x16;
            this.navBtnKasaListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnKasaListesi_LinkClicked);
            // 
            // navBtnKasaDevirIslem
            // 
            this.navBtnKasaDevirIslem.Caption = "Kasa Devir/İşlem";
            this.navBtnKasaDevirIslem.Name = "navBtnKasaDevirIslem";
            this.navBtnKasaDevirIslem.SmallImage = global::Otomasyon.Properties.Resources.Kasa_Devir16x16;
            this.navBtnKasaDevirIslem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnKasaDevirIslem_LinkClicked);
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Kasa Tahsilat/Ödeme";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImage = global::Otomasyon.Properties.Resources.Kasa_Odeme16x16;
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // navBtnKasaHareketleri
            // 
            this.navBtnKasaHareketleri.Caption = "Kasa Hareketleri";
            this.navBtnKasaHareketleri.Name = "navBtnKasaHareketleri";
            this.navBtnKasaHareketleri.SmallImage = global::Otomasyon.Properties.Resources.Kasa_Hareket16x16;
            this.navBtnKasaHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBtnKasaHareketleri_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Fatura";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "navBarItem9";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "navBarItem10";
            this.navBarItem10.Name = "navBarItem10";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "navBarItem11";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "navBarItem12";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // ribbonPage10
            // 
            this.ribbonPage10.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage10.Image = global::Otomasyon.Properties.Resources.Cek32x32;
            this.ribbonPage10.Name = "ribbonPage10";
            this.ribbonPage10.Text = "Çekler";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnMusteriCeki);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnKendiCekimiz);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnBankayaCekCikisi);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnCariyeCekCikisi);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Çek İşlemleri";
            // 
            // ribbonPage11
            // 
            this.ribbonPage11.Name = "ribbonPage11";
            this.ribbonPage11.Text = "ribbonPage11";
            // 
            // barBtnMusteriCeki
            // 
            this.barBtnMusteriCeki.Caption = "Müşteri Çeki";
            this.barBtnMusteriCeki.Id = 28;
            this.barBtnMusteriCeki.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cek_Musteri32x32;
            this.barBtnMusteriCeki.LargeWidth = 100;
            this.barBtnMusteriCeki.Name = "barBtnMusteriCeki";
            // 
            // barBtnKendiCekimiz
            // 
            this.barBtnKendiCekimiz.Caption = "Kendi Çekimiz";
            this.barBtnKendiCekimiz.Id = 29;
            this.barBtnKendiCekimiz.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cek_Kendi32x32;
            this.barBtnKendiCekimiz.LargeWidth = 100;
            this.barBtnKendiCekimiz.Name = "barBtnKendiCekimiz";
            // 
            // barBtnBankayaCekCikisi
            // 
            this.barBtnBankayaCekCikisi.Caption = "Bankaya Çek Çıkışı";
            this.barBtnBankayaCekCikisi.Id = 30;
            this.barBtnBankayaCekCikisi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cek_Bankaya32x32;
            this.barBtnBankayaCekCikisi.LargeWidth = 100;
            this.barBtnBankayaCekCikisi.Name = "barBtnBankayaCekCikisi";
            // 
            // barBtnCariyeCekCikisi
            // 
            this.barBtnCariyeCekCikisi.Caption = "Cariye Çek Çıkışı";
            this.barBtnCariyeCekCikisi.Id = 31;
            this.barBtnCariyeCekCikisi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.Cek_Cariye32x32;
            this.barBtnCariyeCekCikisi.LargeWidth = 100;
            this.barBtnCariyeCekCikisi.Name = "barBtnCariyeCekCikisi";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 504);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnStokListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnStokGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barBtnCariKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnCariGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnCariListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnCariHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem barBtnBankaKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnParaTransferi;
        private DevExpress.XtraBars.BarButtonItem barBtnBankaListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnBankaIslemi;
        private DevExpress.XtraBars.BarButtonItem barBtnBankaHareketleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.BarButtonItem barBtnKasaAcilisKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnKasaListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnKasaDevirIslemKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnKasaTahsilatOdeme;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage9;
        private DevExpress.XtraBars.BarButtonItem barBtnSatisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barBtnSatisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barBtnAlisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barBtnAlisIadeFaturası;
        private DevExpress.XtraBars.BarButtonItem barBtnSatisIrsaliyesi;
        private DevExpress.XtraBars.BarButtonItem barBtnAlisIrsaliyesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem txtSaat;
        private DevExpress.XtraBars.BarButtonItem barBtnKasaHareketleri;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBtnStokKarti;
        private DevExpress.XtraNavBar.NavBarItem navBtnStokListesi;
        private DevExpress.XtraNavBar.NavBarItem navBtnStokGruplari;
        private DevExpress.XtraNavBar.NavBarItem navBtnStokHareketleri;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBtnCariAcilisKarti;
        private DevExpress.XtraNavBar.NavBarItem navBtnCariGruplari;
        private DevExpress.XtraNavBar.NavBarItem navBtnCariListesi;
        private DevExpress.XtraNavBar.NavBarItem navBtnCariHareketleri;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBtnBankaAcilisKarti;
        private DevExpress.XtraNavBar.NavBarItem navBtnParaTransferi;
        private DevExpress.XtraNavBar.NavBarItem navBtnBankaListesi;
        private DevExpress.XtraNavBar.NavBarItem navBtnBankaIslemi;
        private DevExpress.XtraNavBar.NavBarItem navBtnBankaHareketleri;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBtnKasaAcilisKarti;
        private DevExpress.XtraNavBar.NavBarItem navBtnKasaListesi;
        private DevExpress.XtraNavBar.NavBarItem navBtnKasaDevirIslem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBtnKasaHareketleri;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraBars.Alerter.AlertControl ALC;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage11;
        private DevExpress.XtraBars.BarButtonItem barBtnMusteriCeki;
        private DevExpress.XtraBars.BarButtonItem barBtnKendiCekimiz;
        private DevExpress.XtraBars.BarButtonItem barBtnBankayaCekCikisi;
        private DevExpress.XtraBars.BarButtonItem barBtnCariyeCekCikisi;
    }
}