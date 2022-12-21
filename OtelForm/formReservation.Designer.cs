namespace OtelForm
{
    partial class formReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReservation));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnShowList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddReservation = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDeleteReservation = new DevExpress.XtraBars.BarButtonItem();
            this.btnRezervasyonOnayla = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridReservation = new DevExpress.XtraGrid.GridControl();
            this.viewReservation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.otelDataSet11 = new OtelForm.OTELDataSet1();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.popupReservation = new DevExpress.XtraBars.PopupMenu(this.components);
            this.musteriTableAdapter1 = new OtelForm.OTELDataSet1TableAdapters.musteriTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupReservation)).BeginInit();
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
            this.btnAddReservation,
            this.btnClose,
            this.btnDeleteReservation,
            this.btnRezervasyonOnayla,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddReservation),
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
            this.btnShowList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowList_ItemClick);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Caption = "Rezervasyon Ekle";
            this.btnAddReservation.Id = 1;
            this.btnAddReservation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReservation.ImageOptions.Image")));
            this.btnAddReservation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddReservation.ImageOptions.LargeImage")));
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddReservation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddReservation_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1082, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1082, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1082, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Caption = "Rezervasyon Sil";
            this.btnDeleteReservation.Id = 3;
            this.btnDeleteReservation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteReservation.ImageOptions.Image")));
            this.btnDeleteReservation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteReservation.ImageOptions.LargeImage")));
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteReservation_ItemClick);
            // 
            // btnRezervasyonOnayla
            // 
            this.btnRezervasyonOnayla.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnRezervasyonOnayla.Caption = "Rezervayonu Onayla";
            this.btnRezervasyonOnayla.Id = 4;
            this.btnRezervasyonOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervasyonOnayla.ImageOptions.Image")));
            this.btnRezervasyonOnayla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRezervasyonOnayla.ImageOptions.LargeImage")));
            this.btnRezervasyonOnayla.Name = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRezerva);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridReservation);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1082, 462);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridReservation
            // 
            this.gridReservation.Location = new System.Drawing.Point(12, 12);
            this.gridReservation.MainView = this.viewReservation;
            this.gridReservation.MenuManager = this.barManager1;
            this.gridReservation.Name = "gridReservation";
            this.gridReservation.Size = new System.Drawing.Size(1058, 438);
            this.gridReservation.TabIndex = 4;
            this.gridReservation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewReservation});
            // 
            // viewReservation
            // 
            this.viewReservation.GridControl = this.gridReservation;
            this.viewReservation.Name = "viewReservation";
            this.viewReservation.OptionsView.ShowAutoFilterRow = true;
            this.viewReservation.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1082, 462);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridReservation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1062, 442);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // otelDataSet11
            // 
            this.otelDataSet11.DataSetName = "OTELDataSet1";
            this.otelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_OTEL_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "Select musteriid as \"Müşteri No\" ,isim  as \"Ad Soyad\",tc as \"TC\", telno AS \"Telef" +
    "onu\",odaid as \"Oda Numarası\" ,gtarihi as \"Giriş tarihi\",ctarihi as \"Çıkış tarihi" +
    "\" from musteri where gtarihi>=GETDATE()";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // popupReservation
            // 
            this.popupReservation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteReservation),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRezervasyonOnayla),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupReservation.Manager = this.barManager1;
            this.popupReservation.Name = "popupReservation";
            // 
            // musteriTableAdapter1
            // 
            this.musteriTableAdapter1.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Rezervasyonu Güncelle";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRevGuncelle);
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 486);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formReservation";
            this.Text = "Rezervasyonlar";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupReservation)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAddReservation;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridReservation;
        private DevExpress.XtraGrid.Views.Grid.GridView viewReservation;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnDeleteReservation;
        private DevExpress.XtraBars.BarButtonItem btnRezervasyonOnayla;
        private DevExpress.XtraBars.PopupMenu popupReservation;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private OTELDataSet1 otelDataSet11;
        private OTELDataSet1TableAdapters.musteriTableAdapter musteriTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}