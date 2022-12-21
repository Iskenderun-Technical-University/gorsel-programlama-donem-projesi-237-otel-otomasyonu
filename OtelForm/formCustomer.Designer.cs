namespace OtelForm
{
    partial class formCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomer));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnShowList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDeleteCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTELDataSet3 = new OtelForm.OTELDataSet3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MüsteriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GirişTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ÇıkışTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupCustomer = new DevExpress.XtraBars.PopupMenu(this.components);
            this.musteriTableAdapter = new OtelForm.OTELDataSet3TableAdapters.musteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnShowList,
            this.btnAddCustomer,
            this.btnClose,
            this.btnDeleteCustomer,
            this.btnUpdateCustomer});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar1.Text = "Tools";
            // 
            // btnShowList
            // 
            this.btnShowList.Caption = "Listele";
            this.btnShowList.Id = 0;
            this.btnShowList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowList.ImageOptions.Image")));
            this.btnShowList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowList.ImageOptions.LargeImage")));
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Caption = "Müşteri Ekle";
            this.btnAddCustomer.Id = 1;
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.LargeImage")));
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCustomer_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Kapat";
            this.btnClose.Id = 2;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1044, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 418);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1044, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1044, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Caption = "Müşeri Sil";
            this.btnDeleteCustomer.Id = 3;
            this.btnDeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.ImageOptions.Image")));
            this.btnDeleteCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.ImageOptions.LargeImage")));
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Caption = "Müşteri Güncelle";
            this.btnUpdateCustomer.Id = 4;
            this.btnUpdateCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.ImageOptions.Image")));
            this.btnUpdateCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.ImageOptions.LargeImage")));
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1044, 394);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.musteriBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 370);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.oTELDataSet3;
            // 
            // oTELDataSet3
            // 
            this.oTELDataSet3.DataSetName = "OTELDataSet3";
            this.oTELDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MüsteriNo,
            this.ADI,
            this.Tc,
            this.Telefon,
            this.OdaNo,
            this.GirişTarihi,
            this.ÇıkışTarihi,
            this.Fiyat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MüsteriNo
            // 
            this.MüsteriNo.FieldName = "musteriid";
            this.MüsteriNo.Name = "MüsteriNo";
            this.MüsteriNo.Visible = true;
            this.MüsteriNo.VisibleIndex = 0;
            // 
            // ADI
            // 
            this.ADI.FieldName = "isim";
            this.ADI.Name = "ADI";
            this.ADI.Visible = true;
            this.ADI.VisibleIndex = 1;
            // 
            // Tc
            // 
            this.Tc.FieldName = "tc";
            this.Tc.Name = "Tc";
            this.Tc.Visible = true;
            this.Tc.VisibleIndex = 2;
            // 
            // Telefon
            // 
            this.Telefon.FieldName = "telno";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 3;
            // 
            // OdaNo
            // 
            this.OdaNo.FieldName = "odaid";
            this.OdaNo.Name = "OdaNo";
            this.OdaNo.Visible = true;
            this.OdaNo.VisibleIndex = 4;
            // 
            // GirişTarihi
            // 
            this.GirişTarihi.FieldName = "gtarihi";
            this.GirişTarihi.Name = "GirişTarihi";
            this.GirişTarihi.Visible = true;
            this.GirişTarihi.VisibleIndex = 5;
            // 
            // ÇıkışTarihi
            // 
            this.ÇıkışTarihi.FieldName = "ctarihi";
            this.ÇıkışTarihi.Name = "ÇıkışTarihi";
            this.ÇıkışTarihi.Visible = true;
            this.ÇıkışTarihi.VisibleIndex = 6;
            // 
            // Fiyat
            // 
            this.Fiyat.FieldName = "fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Visible = true;
            this.Fiyat.VisibleIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1044, 394);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1024, 374);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupCustomer
            // 
            this.popupCustomer.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateCustomer)});
            this.popupCustomer.Manager = this.barManager1;
            this.popupCustomer.Name = "popupCustomer";
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 418);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.formCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnShowList;
        private DevExpress.XtraBars.BarButtonItem btnAddCustomer;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCustomer;
        private DevExpress.XtraBars.BarButtonItem btnUpdateCustomer;
        private DevExpress.XtraBars.PopupMenu popupCustomer;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn MüsteriNo;
        private DevExpress.XtraGrid.Columns.GridColumn ADI;
        private DevExpress.XtraGrid.Columns.GridColumn Tc;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn OdaNo;
        private DevExpress.XtraGrid.Columns.GridColumn GirişTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn ÇıkışTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Fiyat;
        private OTELDataSet3 oTELDataSet3;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private OTELDataSet3TableAdapters.musteriTableAdapter musteriTableAdapter;
    }
}