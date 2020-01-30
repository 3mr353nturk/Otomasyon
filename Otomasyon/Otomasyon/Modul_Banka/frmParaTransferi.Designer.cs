namespace Otomasyon.Modul_Banka
{
    partial class frmParaTransferi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParaTransferi));
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnGiden = new System.Windows.Forms.RadioButton();
            this.rbtnGelen = new System.Windows.Forms.RadioButton();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtHesapAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransferTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(246, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 35);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtnGiden);
            this.groupControl2.Controls.Add(this.rbtnGelen);
            this.groupControl2.Location = new System.Drawing.Point(231, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(107, 81);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = " İşlem Türü";
            // 
            // rbtnGiden
            // 
            this.rbtnGiden.AutoSize = true;
            this.rbtnGiden.Location = new System.Drawing.Point(7, 55);
            this.rbtnGiden.Name = "rbtnGiden";
            this.rbtnGiden.Size = new System.Drawing.Size(88, 17);
            this.rbtnGiden.TabIndex = 19;
            this.rbtnGiden.TabStop = true;
            this.rbtnGiden.Text = "Giden Havale";
            this.rbtnGiden.UseVisualStyleBackColor = true;
            // 
            // rbtnGelen
            // 
            this.rbtnGelen.AutoSize = true;
            this.rbtnGelen.Checked = true;
            this.rbtnGelen.Location = new System.Drawing.Point(8, 29);
            this.rbtnGelen.Name = "rbtnGelen";
            this.rbtnGelen.Size = new System.Drawing.Size(88, 17);
            this.rbtnGelen.TabIndex = 18;
            this.rbtnGelen.TabStop = true;
            this.rbtnGelen.Text = "Gelen Havale";
            this.rbtnGelen.UseVisualStyleBackColor = true;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(93, 31);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(144, 20);
            this.txtBelgeNo.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(246, 138);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 35);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Açıklama:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(93, 81);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(132, 20);
            this.txtTutar.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Tarih:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Hesap Türü/Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Belge No:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(94, 114);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(244, 74);
            this.txtAciklama.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Hesap No:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtCariAdi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.txtHesapAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 186);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Temel Bilgiler";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(92, 153);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Properties.ReadOnly = true;
            this.txtCariAdi.Size = new System.Drawing.Size(145, 20);
            this.txtCariAdi.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Cari Adı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 127);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Cari Kodu:";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(92, 124);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(145, 20);
            this.txtCariKodu.TabIndex = 11;
            this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(94, 92);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Properties.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(143, 20);
            this.txtHesapNo.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btnKaydet.Location = new System.Drawing.Point(246, 30);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 35);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(94, 61);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapAdi.Properties.ReadOnly = true;
            this.txtHesapAdi.Size = new System.Drawing.Size(143, 20);
            this.txtHesapAdi.TabIndex = 6;
            this.txtHesapAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapAdi_ButtonClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.groupControl2);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtTutar);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtAciklama);
            this.groupControl3.Controls.Add(this.txtTransferTuru);
            this.groupControl3.Controls.Add(this.txtTarih);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 186);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(346, 198);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "İşlem Bilgileri";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 26);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Transfer Türü:";
            // 
            // txtTransferTuru
            // 
            this.txtTransferTuru.EditValue = "Banka Havale";
            this.txtTransferTuru.Location = new System.Drawing.Point(94, 23);
            this.txtTransferTuru.Name = "txtTransferTuru";
            this.txtTransferTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTransferTuru.Properties.Items.AddRange(new object[] {
            "Banka Havale",
            "Banka EFT"});
            this.txtTransferTuru.Size = new System.Drawing.Size(132, 20);
            this.txtTransferTuru.TabIndex = 20;
            this.txtTransferTuru.SelectedIndexChanged += new System.EventHandler(this.txtTransferTuru_SelectedIndexChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(94, 51);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(132, 20);
            this.txtTarih.TabIndex = 10;
            // 
            // frmParaTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 384);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParaTransferi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Transferi Formu";
            this.Load += new System.EventHandler(this.frmParaTransferi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rbtnGiden;
        private System.Windows.Forms.RadioButton rbtnGelen;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ButtonEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit txtTransferTuru;
        private DevExpress.XtraEditors.ButtonEdit txtHesapAdi;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}