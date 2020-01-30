namespace Otomasyon.Modul_Banka
{
    partial class frmBankaHareketleri
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaHareketleri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BankaIsleminiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.BankaParaTransferiniDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtHesapAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(917, 122);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl4
            // 
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(272, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(313, 86);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(52, 20);
            this.txtBakiye.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(168, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Çıkış:";
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(199, 86);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(52, 20);
            this.txtCikis.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(12, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Giriş:";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(94, 86);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(52, 20);
            this.txtGiris.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Hesap No:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(94, 60);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(271, 20);
            this.txtHesapNo.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Hesap Türü/Adı:";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(94, 32);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapAdi.Properties.ReadOnly = true;
            this.txtHesapAdi.Size = new System.Drawing.Size(271, 20);
            this.txtHesapAdi.TabIndex = 5;
            this.txtHesapAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapAdi_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 122);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(917, 370);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagTik;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 20);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(913, 348);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTURU,
            this.EVRAKID,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA,
            this.TARIH});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 100;
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.Caption = "EVRAK TÜRÜ";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 1;
            this.EVRAKTURU.Width = 100;
            // 
            // EVRAKID
            // 
            this.EVRAKID.Caption = "EVRAK ID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.Name = "EVRAKID";
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            this.ACIKLAMA.Width = 452;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 2;
            this.TARIH.Width = 95;
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BankaIsleminiDuzenle,
            this.BankaParaTransferiniDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(236, 70);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // BankaIsleminiDuzenle
            // 
            this.BankaIsleminiDuzenle.Enabled = false;
            this.BankaIsleminiDuzenle.Name = "BankaIsleminiDuzenle";
            this.BankaIsleminiDuzenle.Size = new System.Drawing.Size(235, 22);
            this.BankaIsleminiDuzenle.Text = "Banka İşlemini Düzenle";
            this.BankaIsleminiDuzenle.Click += new System.EventHandler(this.BankaIsleminiDuzenle_Click);
            // 
            // BankaParaTransferiniDuzenle
            // 
            this.BankaParaTransferiniDuzenle.Enabled = false;
            this.BankaParaTransferiniDuzenle.Name = "BankaParaTransferiniDuzenle";
            this.BankaParaTransferiniDuzenle.Size = new System.Drawing.Size(235, 22);
            this.BankaParaTransferiniDuzenle.Text = "Banka Para Transferini Düzenle";
            this.BankaParaTransferiniDuzenle.Click += new System.EventHandler(this.BankaParaTransferiniDuzenle_Click);
            // 
            // frmBankaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 492);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hareketleri";
            this.Load += new System.EventHandler(this.frmBankaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.ButtonEdit txtHesapAdi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem BankaIsleminiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem BankaParaTransferiniDuzenle;
    }
}