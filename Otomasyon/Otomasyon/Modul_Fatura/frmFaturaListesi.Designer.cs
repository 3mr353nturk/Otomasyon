namespace Otomasyon.Modul_Fatura
{
    partial class frmFaturaListesi
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
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtStokKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBarkod = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 85);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(161, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.STOKBARKOD});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(752, 468);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tarih:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Fatura No:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(175, 440);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(181, 468);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(938, 468);
            this.splitContainerControl1.SplitterPosition = 181;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(95, 156);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 50);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 156);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 50);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOK KODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 0;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOK ADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.FixedWidth = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 1;
            // 
            // STOKBARKOD
            // 
            this.STOKBARKOD.Caption = "STOKBARKOD";
            this.STOKBARKOD.FieldName = "STOKBARKOD";
            this.STOKBARKOD.Name = "STOKBARKOD";
            this.STOKBARKOD.OptionsColumn.AllowEdit = false;
            this.STOKBARKOD.OptionsColumn.AllowFocus = false;
            this.STOKBARKOD.OptionsColumn.FixedWidth = true;
            this.STOKBARKOD.Visible = true;
            this.STOKBARKOD.VisibleIndex = 2;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.EditValue = "Satış Faturası";
            this.txtStokKodu.Location = new System.Drawing.Point(12, 40);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStokKodu.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txtStokKodu.Size = new System.Drawing.Size(161, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.EditValue = null;
            this.txtBarkod.Location = new System.Drawing.Point(11, 130);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBarkod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBarkod.Properties.DisplayFormat.FormatString = "";
            this.txtBarkod.Properties.EditFormat.FormatString = "";
            this.txtBarkod.Properties.Mask.EditMask = "";
            this.txtBarkod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtBarkod.Size = new System.Drawing.Size(161, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // frmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 468);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFaturaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn STOKBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtStokKodu;
        private DevExpress.XtraEditors.DateEdit txtBarkod;
    }
}