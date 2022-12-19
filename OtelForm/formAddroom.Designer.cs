namespace OtelForm
{
    partial class formAddroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddroom));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtRoomNumber = new DevExpress.XtraEditors.TextEdit();
            this.cbRoomType = new DevExpress.XtraEditors.LookUpEdit();
            this.odatypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTELDataSet = new OtelForm.OTELDataSet();
            this.spRoomCapa = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spRoomCapacity = new DevExpress.XtraLayout.LayoutControlItem();
            this.odatypeTableAdapter = new OtelForm.OTELDataSetTableAdapters.odatypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odatypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRoomCapa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRoomCapacity)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(404, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 142);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(404, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 118);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(404, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 118);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtRoomNumber);
            this.layoutControl1.Controls.Add(this.cbRoomType);
            this.layoutControl1.Controls.Add(this.spRoomCapa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(801, 163, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(404, 118);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(95, 12);
            this.txtRoomNumber.MenuManager = this.barManager1;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(297, 20);
            this.txtRoomNumber.StyleController = this.layoutControl1;
            this.txtRoomNumber.TabIndex = 5;
            // 
            // cbRoomType
            // 
            this.cbRoomType.Location = new System.Drawing.Point(95, 36);
            this.cbRoomType.MenuManager = this.barManager1;
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoomType.Properties.DataSource = this.odatypeBindingSource;
            this.cbRoomType.Properties.DisplayMember = "odatipi";
            this.cbRoomType.Properties.NullText = "";
            this.cbRoomType.Properties.PopupSizeable = false;
            this.cbRoomType.Properties.ValueMember = "odaid";
            this.cbRoomType.Size = new System.Drawing.Size(297, 20);
            this.cbRoomType.StyleController = this.layoutControl1;
            this.cbRoomType.TabIndex = 6;
            // 
            // odatypeBindingSource
            // 
            this.odatypeBindingSource.DataMember = "odatype";
            this.odatypeBindingSource.DataSource = this.oTELDataSet;
            // 
            // oTELDataSet
            // 
            this.oTELDataSet.DataSetName = "OTELDataSet";
            this.oTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRoomCapa
            // 
            this.spRoomCapa.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spRoomCapa.Location = new System.Drawing.Point(95, 60);
            this.spRoomCapa.MenuManager = this.barManager1;
            this.spRoomCapa.Name = "spRoomCapa";
            this.spRoomCapa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spRoomCapa.Properties.MaskSettings.Set("mask", "d");
            this.spRoomCapa.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spRoomCapa.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spRoomCapa.Size = new System.Drawing.Size(297, 20);
            this.spRoomCapa.StyleController = this.layoutControl1;
            this.spRoomCapa.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.spRoomCapacity});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(404, 118);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtRoomNumber;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(384, 24);
            this.layoutControlItem2.Text = "Oda Numarası";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbRoomType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(384, 24);
            this.layoutControlItem3.Text = "Oda Tipi";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // spRoomCapacity
            // 
            this.spRoomCapacity.Control = this.spRoomCapa;
            this.spRoomCapacity.Location = new System.Drawing.Point(0, 48);
            this.spRoomCapacity.Name = "spRoomCapacity";
            this.spRoomCapacity.Size = new System.Drawing.Size(384, 50);
            this.spRoomCapacity.Text = "Oda Kapasitesi";
            this.spRoomCapacity.TextSize = new System.Drawing.Size(71, 13);
            // 
            // odatypeTableAdapter
            // 
            this.odatypeTableAdapter.ClearBeforeFill = true;
            // 
            // formAddroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 142);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formAddroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Ekle";
            this.Load += new System.EventHandler(this.formAddroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odatypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRoomCapa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRoomCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtRoomNumber;
        private DevExpress.XtraEditors.LookUpEdit cbRoomType;
        private DevExpress.XtraEditors.SpinEdit spRoomCapa;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem spRoomCapacity;
        private OTELDataSet oTELDataSet;
        private System.Windows.Forms.BindingSource odatypeBindingSource;
        private OTELDataSetTableAdapters.odatypeTableAdapter odatypeTableAdapter;
    }
}