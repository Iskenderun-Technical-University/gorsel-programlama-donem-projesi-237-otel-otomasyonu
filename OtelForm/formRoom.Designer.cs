namespace OtelForm
{
    partial class formRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRoom));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnShowList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddRoom = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRoomDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRevBitir = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridRoom = new DevExpress.XtraGrid.GridControl();
            this.viewRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fKmusteriodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTELDataSet = new OtelForm.OTELDataSet();
            this.popupRoom = new DevExpress.XtraBars.PopupMenu(this.components);
            this.odaTableAdapter = new OtelForm.OTELDataSetTableAdapters.odaTableAdapter();
            this.musteriTableAdapter = new OtelForm.OTELDataSetTableAdapters.musteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmusteriodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupRoom)).BeginInit();
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
            this.btnAddRoom,
            this.btnClose,
            this.btnRoomDelete,
            this.barButtonRevBitir});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddRoom),
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
            // btnAddRoom
            // 
            this.btnAddRoom.Caption = "Oda Ekle";
            this.btnAddRoom.Id = 1;
            this.btnAddRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.ImageOptions.Image")));
            this.btnAddRoom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.ImageOptions.LargeImage")));
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddRoom_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Kapat";
            this.btnClose.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1131, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 422);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1131, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1131, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Caption = "Silme";
            this.btnRoomDelete.Id = 4;
            this.btnRoomDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomDelete.ImageOptions.Image")));
            this.btnRoomDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoomDelete.ImageOptions.LargeImage")));
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoomDelete_ItemClick);
            // 
            // barButtonRevBitir
            // 
            this.barButtonRevBitir.Caption = "Rezervasyonu bitir";
            this.barButtonRevBitir.Id = 6;
            this.barButtonRevBitir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonRevBitir.ImageOptions.Image")));
            this.barButtonRevBitir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonRevBitir.ImageOptions.LargeImage")));
            this.barButtonRevBitir.Name = "barButtonRevBitir";
            this.barButtonRevBitir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRevBitir);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridRoom);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1131, 398);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridRoom
            // 
            this.gridRoom.Location = new System.Drawing.Point(12, 12);
            this.gridRoom.MainView = this.viewRoom;
            this.gridRoom.MenuManager = this.barManager1;
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.Size = new System.Drawing.Size(1107, 374);
            this.gridRoom.TabIndex = 4;
            this.gridRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewRoom});
            // 
            // viewRoom
            // 
            this.viewRoom.GridControl = this.gridRoom;
            this.viewRoom.Name = "viewRoom";
            this.viewRoom.OptionsView.ShowAutoFilterRow = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1131, 398);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridRoom;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1111, 378);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // fKmusteriodaBindingSource
            // 
            this.fKmusteriodaBindingSource.DataMember = "FK_musteri_oda";
            this.fKmusteriodaBindingSource.DataSource = this.odaBindingSource;
            // 
            // odaBindingSource
            // 
            this.odaBindingSource.DataMember = "oda";
            this.odaBindingSource.DataSource = this.oTELDataSet;
            // 
            // oTELDataSet
            // 
            this.oTELDataSet.DataSetName = "OTELDataSet";
            this.oTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popupRoom
            // 
            this.popupRoom.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRoomDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonRevBitir)});
            this.popupRoom.Manager = this.barManager1;
            this.popupRoom.Name = "popupRoom";
            // 
            // odaTableAdapter
            // 
            this.odaTableAdapter.ClearBeforeFill = true;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // formRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 422);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formRoom";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.formRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmusteriodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupRoom)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAddRoom;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView viewRoom;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnRoomDelete;
        private DevExpress.XtraBars.PopupMenu popupRoom;
        private OTELDataSet oTELDataSet;
        private System.Windows.Forms.BindingSource odaBindingSource;
        private OTELDataSetTableAdapters.odaTableAdapter odaTableAdapter;
        private System.Windows.Forms.BindingSource fKmusteriodaBindingSource;
        private OTELDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonRevBitir;
    }
}