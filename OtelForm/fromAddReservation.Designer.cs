namespace OtelForm
{
    partial class fromAddReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromAddReservation));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.cbRoom = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dtCinDate = new DevExpress.XtraEditors.DateEdit();
            this.dtCoutDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.oTELDataSet = new OtelForm.OTELDataSet();
            this.odaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odaTableAdapter = new OtelForm.OTELDataSetTableAdapters.odaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCinDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCinDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCoutDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCoutDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).BeginInit();
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
            this.btnSave,
            this.btnClose});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Kaydet";
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Kapat";
            this.btnClose.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(373, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 270);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(373, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 246);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(373, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 246);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtTC);
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.cbRoom);
            this.layoutControl1.Controls.Add(this.dtCinDate);
            this.layoutControl1.Controls.Add(this.dtCoutDate);
            this.layoutControl1.Controls.Add(this.txtAmount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(373, 246);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 12);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(91, 36);
            this.txtTC.MenuManager = this.barManager1;
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTC.Properties.MaskSettings.Set("mask", "d");
            this.txtTC.Size = new System.Drawing.Size(270, 20);
            this.txtTC.StyleController = this.layoutControl1;
            this.txtTC.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 60);
            this.txtPhone.MenuManager = this.barManager1;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtPhone.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtPhone.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtPhone.Size = new System.Drawing.Size(270, 20);
            this.txtPhone.StyleController = this.layoutControl1;
            this.txtPhone.TabIndex = 6;
            // 
            // cbRoom
            // 
            this.cbRoom.Location = new System.Drawing.Point(91, 84);
            this.cbRoom.MenuManager = this.barManager1;
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoom.Properties.DataSource = this.queryBindingSource;
            this.cbRoom.Properties.DisplayMember = "odano";
            this.cbRoom.Properties.NullText = "";
            this.cbRoom.Properties.PopupSizeable = false;
            this.cbRoom.Properties.ValueMember = "odano";
            this.cbRoom.Size = new System.Drawing.Size(270, 20);
            this.cbRoom.StyleController = this.layoutControl1;
            this.cbRoom.TabIndex = 7;
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_OTEL_Connection 2";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = "select odano from oda where odadurum != 1";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0ib2Rhbm8iIFR5cGU9IkludDMyIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // dtCinDate
            // 
            this.dtCinDate.EditValue = null;
            this.dtCinDate.Location = new System.Drawing.Point(91, 132);
            this.dtCinDate.MenuManager = this.barManager1;
            this.dtCinDate.Name = "dtCinDate";
            this.dtCinDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCinDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCinDate.Size = new System.Drawing.Size(270, 20);
            this.dtCinDate.StyleController = this.layoutControl1;
            this.dtCinDate.TabIndex = 8;
            // 
            // dtCoutDate
            // 
            this.dtCoutDate.EditValue = null;
            this.dtCoutDate.Location = new System.Drawing.Point(91, 156);
            this.dtCoutDate.MenuManager = this.barManager1;
            this.dtCoutDate.Name = "dtCoutDate";
            this.dtCoutDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCoutDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCoutDate.Size = new System.Drawing.Size(270, 20);
            this.dtCoutDate.StyleController = this.layoutControl1;
            this.dtCoutDate.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(91, 108);
            this.txtAmount.MenuManager = this.barManager1;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAmount.Properties.MaskSettings.Set("mask", "n");
            this.txtAmount.Size = new System.Drawing.Size(270, 20);
            this.txtAmount.StyleController = this.layoutControl1;
            this.txtAmount.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(373, 246);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem1.Text = "İsim";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTC;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem2.Text = "TC";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPhone;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem3.Text = "Telefon";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbRoom;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem4.Text = "Oda Numarası";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtCinDate;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem5.Text = "Griş Tarihi";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dtCoutDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(353, 82);
            this.layoutControlItem6.Text = "Çıkış Tarihi";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtAmount;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(353, 24);
            this.layoutControlItem7.Text = "Fiyat";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(67, 13);
            // 
            // oTELDataSet
            // 
            this.oTELDataSet.DataSetName = "OTELDataSet";
            this.oTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaBindingSource
            // 
            this.odaBindingSource.DataMember = "oda";
            this.odaBindingSource.DataSource = this.oTELDataSet;
            // 
            // odaTableAdapter
            // 
            this.odaTableAdapter.ClearBeforeFill = true;
            // 
            // fromAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 270);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fromAddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Ekle";
            this.Load += new System.EventHandler(this.fromAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCinDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCinDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCoutDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCoutDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LookUpEdit cbRoom;
        private DevExpress.XtraEditors.DateEdit dtCinDate;
        private DevExpress.XtraEditors.DateEdit dtCoutDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private OTELDataSet oTELDataSet;
        private System.Windows.Forms.BindingSource odaBindingSource;
        private OTELDataSetTableAdapters.odaTableAdapter odaTableAdapter;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}