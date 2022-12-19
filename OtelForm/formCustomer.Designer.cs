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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
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
            this.gridCustomer = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.viewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMüşteriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdaNumarası = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiriştarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colÇıkıştarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupCustomer = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomer)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.gridCustomer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1044, 394);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridCustomer
            // 
            this.gridCustomer.DataMember = "Query";
            this.gridCustomer.DataSource = this.sqlDataSource1;
            this.gridCustomer.Location = new System.Drawing.Point(12, 12);
            this.gridCustomer.MainView = this.viewCustomer;
            this.gridCustomer.MenuManager = this.barManager1;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.Size = new System.Drawing.Size(1020, 370);
            this.gridCustomer.TabIndex = 4;
            this.gridCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCustomer});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_OTEL_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "Select musteriid as \"Müşteri No\" ,isim  as \"Ad Soyad\",tc as \"TC\", telno AS \"Telef" +
    "onu\",odaid as \"Oda Numarası\" ,ctarihi as \"Giriş tarihi\",gtarihi as \"Çıkış tarihi" +
    "\" from musteri";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // viewCustomer
            // 
            this.viewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMüşteriNo,
            this.colAdSoyad,
            this.colTC,
            this.colTelefonu,
            this.colOdaNumarası,
            this.colGiriştarihi,
            this.colÇıkıştarihi});
            this.viewCustomer.GridControl = this.gridCustomer;
            this.viewCustomer.Name = "viewCustomer";
            this.viewCustomer.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMüşteriNo
            // 
            this.colMüşteriNo.FieldName = "Müşteri No";
            this.colMüşteriNo.Name = "colMüşteriNo";
            this.colMüşteriNo.Visible = true;
            this.colMüşteriNo.VisibleIndex = 0;
            this.colMüşteriNo.Width = 92;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "Ad Soyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            this.colAdSoyad.Width = 136;
            // 
            // colTC
            // 
            this.colTC.FieldName = "TC";
            this.colTC.Name = "colTC";
            this.colTC.Visible = true;
            this.colTC.VisibleIndex = 2;
            this.colTC.Width = 91;
            // 
            // colTelefonu
            // 
            this.colTelefonu.FieldName = "Telefonu";
            this.colTelefonu.Name = "colTelefonu";
            this.colTelefonu.Visible = true;
            this.colTelefonu.VisibleIndex = 3;
            this.colTelefonu.Width = 98;
            // 
            // colOdaNumarası
            // 
            this.colOdaNumarası.FieldName = "Oda Numarası";
            this.colOdaNumarası.Name = "colOdaNumarası";
            this.colOdaNumarası.Visible = true;
            this.colOdaNumarası.VisibleIndex = 4;
            this.colOdaNumarası.Width = 59;
            // 
            // colGiriştarihi
            // 
            this.colGiriştarihi.FieldName = "Giriş tarihi";
            this.colGiriştarihi.Name = "colGiriştarihi";
            this.colGiriştarihi.Visible = true;
            this.colGiriştarihi.VisibleIndex = 5;
            this.colGiriştarihi.Width = 121;
            // 
            // colÇıkıştarihi
            // 
            this.colÇıkıştarihi.FieldName = "Çıkış tarihi";
            this.colÇıkıştarihi.Name = "colÇıkıştarihi";
            this.colÇıkıştarihi.Visible = true;
            this.colÇıkıştarihi.VisibleIndex = 6;
            this.colÇıkıştarihi.Width = 287;
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
            this.layoutControlItem1.Control = this.gridCustomer;
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomer)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView viewCustomer;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCustomer;
        private DevExpress.XtraBars.BarButtonItem btnUpdateCustomer;
        private DevExpress.XtraBars.PopupMenu popupCustomer;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMüşteriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdaNumarası;
        private DevExpress.XtraGrid.Columns.GridColumn colGiriştarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colÇıkıştarihi;
    }
}