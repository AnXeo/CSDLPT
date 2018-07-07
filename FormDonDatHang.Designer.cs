namespace QLVATTU
{
    partial class frmDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label nGAYLabel1;
            System.Windows.Forms.Label mANVLabel;
            this.bdsDATHANG = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVATTU.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayLaiCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnQuayLaiChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoCTPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PhanManh = new QLVATTU.DS_PhanManh();
            this.v_DS_PHANMANHTableAdapter = new QLVATTU.DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVATTU.DS_PhanManhTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new QLVATTU.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVATTU.DSTableAdapters.CTDDHTableAdapter();
            this.dATHANGTableAdapter = new QLVATTU.DSTableAdapters.DATHANGTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grCTDDH = new System.Windows.Forms.GroupBox();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grDDH = new System.Windows.Forms.GroupBox();
            this.gcDATHANG = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grNLCTDDH = new System.Windows.Forms.GroupBox();
            this.cmbMaVatTu2 = new System.Windows.Forms.ComboBox();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSOLUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDDH2 = new DevExpress.XtraEditors.TextEdit();
            this.txtDONGIA = new DevExpress.XtraEditors.TextEdit();
            this.grNLDDH = new System.Windows.Forms.GroupBox();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.cmbMANV1 = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dptNgay = new DevExpress.XtraEditors.DateEdit();
            this.cmbMaKho2 = new System.Windows.Forms.ComboBox();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDDH1 = new DevExpress.XtraEditors.TextEdit();
            this.vATTUTableAdapter = new QLVATTU.DSTableAdapters.VATTUTableAdapter();
            this.nHANVIENTableAdapter = new QLVATTU.DSTableAdapters.NHANVIENTableAdapter();
            this.kHOTableAdapter = new QLVATTU.DSTableAdapters.KHOTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            nGAYLabel1 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.grDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDATHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grNLCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).BeginInit();
            this.grNLDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(21, 34);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(52, 13);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã DDH:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(229, 30);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(47, 13);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà CC:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(21, 115);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Location = new System.Drawing.Point(10, 37);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Maso DDH:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(7, 88);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(56, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã Vật tư:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(11, 62);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(52, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(220, 33);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(47, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // nGAYLabel1
            // 
            nGAYLabel1.AutoSize = true;
            nGAYLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDATHANG, "MANV", true));
            nGAYLabel1.Location = new System.Drawing.Point(28, 57);
            nGAYLabel1.Name = "nGAYLabel1";
            nGAYLabel1.Size = new System.Drawing.Size(35, 13);
            nGAYLabel1.TabIndex = 11;
            nGAYLabel1.Text = "Ngày:";
            // 
            // bdsDATHANG
            // 
            this.bdsDATHANG.DataMember = "DATHANG";
            this.bdsDATHANG.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(21, 93);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(43, 13);
            mANVLabel.TabIndex = 14;
            mANVLabel.Text = "Mã NV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemPhieu,
            this.btnXoaPhieu,
            this.btnSua,
            this.btnLuu,
            this.btnQuayLai,
            this.btnReload,
            this.btnXoaChiTiet,
            this.btnQuayLaiCT,
            this.btnQuayLaiChiTiet,
            this.btnThemChiTiet,
            this.btnLuuCT,
            this.barButtonItem1,
            this.btnUndoPhieu,
            this.btnUndoCTPhieu,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPhieu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaPhieu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQuayLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaChiTiet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQuayLaiCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemChiTiet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Caption = "ThêmPhiếu";
            this.btnThemPhieu.Glyph = global::QLVATTU.Properties.Resources.Button_Add_24_icon2;
            this.btnThemPhieu.Id = 0;
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPhieu_ItemClick);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Caption = "XóaPhiếu";
            this.btnXoaPhieu.Glyph = global::QLVATTU.Properties.Resources.Delete_2_icon_24;
            this.btnXoaPhieu.Id = 1;
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "SửaPhiếu";
            this.btnSua.Glyph = global::QLVATTU.Properties.Resources.Text_Edit_icon_242;
            this.btnSua.Id = 2;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "LưuPhiếu";
            this.btnLuu.Glyph = global::QLVATTU.Properties.Resources.Save_icon_241;
            this.btnLuu.Id = 3;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Caption = "QuayLại";
            this.btnQuayLai.Glyph = global::QLVATTU.Properties.Resources.if___Left_19046582;
            this.btnQuayLai.Id = 4;
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuayLai_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tảilại";
            this.btnReload.Glyph = global::QLVATTU.Properties.Resources.Button_Refresh_icon_242;
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Caption = "XóaChiTiết";
            this.btnXoaChiTiet.Glyph = global::QLVATTU.Properties.Resources.if_6___Cross_1815573;
            this.btnXoaChiTiet.Id = 6;
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemChiTiet_ItemClick);
            // 
            // btnQuayLaiCT
            // 
            this.btnQuayLaiCT.Caption = "QuayLạiChiTiết";
            this.btnQuayLaiCT.Glyph = global::QLVATTU.Properties.Resources.if_arrow_back_326518;
            this.btnQuayLaiCT.Id = 7;
            this.btnQuayLaiCT.Name = "btnQuayLaiCT";
            this.btnQuayLaiCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuChiTiet_ItemClick);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Caption = "ThêmChiTiết";
            this.btnThemChiTiet.Glyph = global::QLVATTU.Properties.Resources.if_document_sans_add_1034991;
            this.btnThemChiTiet.Id = 9;
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCHiTiet_ItemClick);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.Caption = "Lưu Chi Tiết";
            this.btnLuuCT.Glyph = global::QLVATTU.Properties.Resources.if_flat_style_circle_save_1312549;
            this.btnLuuCT.Id = 10;
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuCT_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = global::QLVATTU.Properties.Resources.Exit_24_icon1;
            this.btnThoat.Id = 14;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(961, 64);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 595);
            this.barDockControlBottom.Size = new System.Drawing.Size(961, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 64);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(961, 64);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // btnQuayLaiChiTiet
            // 
            this.btnQuayLaiChiTiet.Caption = "QuayLạiChiTiết";
            this.btnQuayLaiChiTiet.Id = 8;
            this.btnQuayLaiChiTiet.Name = "btnQuayLaiChiTiet";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnUndoPhieu
            // 
            this.btnUndoPhieu.Caption = "PhụcHồiPhiếu";
            this.btnUndoPhieu.Id = 12;
            this.btnUndoPhieu.Name = "btnUndoPhieu";
            // 
            // btnUndoCTPhieu
            // 
            this.btnUndoCTPhieu.Caption = "PhụcHồiCHiTiết";
            this.btnUndoCTPhieu.Id = 13;
            this.btnUndoCTPhieu.Name = "btnUndoCTPhieu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 35);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(324, 6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(352, 21);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_PhanManh;
            // 
            // dS_PhanManh
            // 
            this.dS_PhanManh.DataSetName = "DS_PhanManh";
            this.dS_PhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVATTU.DS_PhanManhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CHINHANHTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DATHANGTableAdapter = this.dATHANGTableAdapter;
            this.tableAdapterManager1.KHOTableAdapter = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = null;
            this.tableAdapterManager1.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager1.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVATTU.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VATTUTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // dATHANGTableAdapter
            // 
            this.dATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grCTDDH);
            this.groupBox1.Controls.Add(this.grDDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 496);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // grCTDDH
            // 
            this.grCTDDH.Controls.Add(this.gcCTDDH);
            this.grCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCTDDH.Location = new System.Drawing.Point(3, 187);
            this.grCTDDH.Name = "grCTDDH";
            this.grCTDDH.Size = new System.Drawing.Size(505, 306);
            this.grCTDDH.TabIndex = 1;
            this.grCTDDH.TabStop = false;
            this.grCTDDH.Text = "Chi tiết đơn đặt hàng:";
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.bdsCTDDH;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDDH.Location = new System.Drawing.Point(3, 16);
            this.gcCTDDH.MainView = this.gridView2;
            this.gcCTDDH.MenuManager = this.barManager1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(499, 287);
            this.gcCTDDH.TabIndex = 0;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DATHANG";
            this.bdsCTDDH.DataSource = this.bdsDATHANG;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcCTDDH;
            this.gridView2.Name = "gridView2";
            // 
            // grDDH
            // 
            this.grDDH.Controls.Add(this.gcDATHANG);
            this.grDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDDH.Location = new System.Drawing.Point(3, 16);
            this.grDDH.Name = "grDDH";
            this.grDDH.Size = new System.Drawing.Size(505, 171);
            this.grDDH.TabIndex = 0;
            this.grDDH.TabStop = false;
            this.grDDH.Text = "Đơn đặt hàng:";
            // 
            // gcDATHANG
            // 
            this.gcDATHANG.DataSource = this.bdsDATHANG;
            this.gcDATHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDATHANG.Location = new System.Drawing.Point(3, 16);
            this.gcDATHANG.MainView = this.gridView1;
            this.gcDATHANG.MenuManager = this.barManager1;
            this.gcDATHANG.Name = "gcDATHANG";
            this.gcDATHANG.Size = new System.Drawing.Size(499, 152);
            this.gcDATHANG.TabIndex = 0;
            this.gcDATHANG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDATHANG;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grNLCTDDH);
            this.groupBox2.Controls.Add(this.grNLDDH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(511, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 496);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // grNLCTDDH
            // 
            this.grNLCTDDH.Controls.Add(this.cmbMaVatTu2);
            this.grNLCTDDH.Controls.Add(dONGIALabel);
            this.grNLCTDDH.Controls.Add(sOLUONGLabel);
            this.grNLCTDDH.Controls.Add(this.txtSOLUONG);
            this.grNLCTDDH.Controls.Add(mAVTLabel);
            this.grNLCTDDH.Controls.Add(this.txtMAVT);
            this.grNLCTDDH.Controls.Add(masoDDHLabel1);
            this.grNLCTDDH.Controls.Add(this.txtMaDDH2);
            this.grNLCTDDH.Controls.Add(this.txtDONGIA);
            this.grNLCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grNLCTDDH.Location = new System.Drawing.Point(3, 187);
            this.grNLCTDDH.Name = "grNLCTDDH";
            this.grNLCTDDH.Size = new System.Drawing.Size(444, 306);
            this.grNLCTDDH.TabIndex = 1;
            this.grNLCTDDH.TabStop = false;
            this.grNLCTDDH.Text = "Nhập liệu chi tiết:";
            // 
            // cmbMaVatTu2
            // 
            this.cmbMaVatTu2.DataSource = this.vATTUBindingSource;
            this.cmbMaVatTu2.DisplayMember = "TENVT";
            this.cmbMaVatTu2.FormattingEnabled = true;
            this.cmbMaVatTu2.Location = new System.Drawing.Point(201, 84);
            this.cmbMaVatTu2.Name = "cmbMaVatTu2";
            this.cmbMaVatTu2.Size = new System.Drawing.Size(181, 21);
            this.cmbMaVatTu2.TabIndex = 8;
            this.cmbMaVatTu2.ValueMember = "MAVT";
            this.cmbMaVatTu2.SelectedIndexChanged += new System.EventHandler(this.cmbMaVatTu2_SelectedIndexChanged);
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.dS;
            // 
            // txtSOLUONG
            // 
            this.txtSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "SOLUONG", true));
            this.txtSOLUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSOLUONG.Location = new System.Drawing.Point(85, 55);
            this.txtSOLUONG.MenuManager = this.barManager1;
            this.txtSOLUONG.Name = "txtSOLUONG";
            this.txtSOLUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOLUONG.Size = new System.Drawing.Size(100, 20);
            this.txtSOLUONG.TabIndex = 5;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(85, 85);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(100, 20);
            this.txtMAVT.TabIndex = 3;
            // 
            // txtMaDDH2
            // 
            this.txtMaDDH2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MasoDDH", true));
            this.txtMaDDH2.Location = new System.Drawing.Point(85, 30);
            this.txtMaDDH2.MenuManager = this.barManager1;
            this.txtMaDDH2.Name = "txtMaDDH2";
            this.txtMaDDH2.Size = new System.Drawing.Size(100, 20);
            this.txtMaDDH2.TabIndex = 1;
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDONGIA.EditValue = "";
            this.txtDONGIA.Location = new System.Drawing.Point(282, 30);
            this.txtDONGIA.MenuManager = this.barManager1;
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtDONGIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDONGIA.Size = new System.Drawing.Size(100, 20);
            this.txtDONGIA.TabIndex = 7;
            // 
            // grNLDDH
            // 
            this.grNLDDH.Controls.Add(mANVLabel);
            this.grNLDDH.Controls.Add(this.txtMANV);
            this.grNLDDH.Controls.Add(this.cmbMANV1);
            this.grNLDDH.Controls.Add(nGAYLabel1);
            this.grNLDDH.Controls.Add(this.dptNgay);
            this.grNLDDH.Controls.Add(this.cmbMaKho2);
            this.grNLDDH.Controls.Add(mAKHOLabel);
            this.grNLDDH.Controls.Add(this.txtMAKHO);
            this.grNLDDH.Controls.Add(nhaCCLabel);
            this.grNLDDH.Controls.Add(this.txtNhaCC);
            this.grNLDDH.Controls.Add(masoDDHLabel);
            this.grNLDDH.Controls.Add(this.txtMaDDH1);
            this.grNLDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grNLDDH.Location = new System.Drawing.Point(3, 16);
            this.grNLDDH.Name = "grNLDDH";
            this.grNLDDH.Size = new System.Drawing.Size(444, 171);
            this.grNLDDH.TabIndex = 0;
            this.grNLDDH.TabStop = false;
            this.grNLDDH.Text = "Nhập liệu đơn đặt hàng:";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDATHANG, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(99, 86);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 15;
            // 
            // cmbMANV1
            // 
            this.cmbMANV1.DataSource = this.nHANVIENBindingSource;
            this.cmbMANV1.DisplayMember = "MANV";
            this.cmbMANV1.FormattingEnabled = true;
            this.cmbMANV1.Location = new System.Drawing.Point(282, 80);
            this.cmbMANV1.Name = "cmbMANV1";
            this.cmbMANV1.Size = new System.Drawing.Size(100, 21);
            this.cmbMANV1.TabIndex = 14;
            this.cmbMANV1.ValueMember = "MANV";
            this.cmbMANV1.SelectedIndexChanged += new System.EventHandler(this.cmbMANV1_SelectedIndexChanged);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dS;
            // 
            // dptNgay
            // 
            this.dptNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDATHANG, "NGAY", true));
            this.dptNgay.EditValue = "";
            this.dptNgay.Location = new System.Drawing.Point(99, 53);
            this.dptNgay.MenuManager = this.barManager1;
            this.dptNgay.Name = "dptNgay";
            this.dptNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgay.Size = new System.Drawing.Size(100, 20);
            this.dptNgay.TabIndex = 12;
            // 
            // cmbMaKho2
            // 
            this.cmbMaKho2.DataSource = this.kHOBindingSource;
            this.cmbMaKho2.DisplayMember = "TENKHO";
            this.cmbMaKho2.FormattingEnabled = true;
            this.cmbMaKho2.Location = new System.Drawing.Point(282, 107);
            this.cmbMaKho2.Name = "cmbMaKho2";
            this.cmbMaKho2.Size = new System.Drawing.Size(100, 21);
            this.cmbMaKho2.TabIndex = 11;
            this.cmbMaKho2.ValueMember = "MAKHO";
            this.cmbMaKho2.SelectedIndexChanged += new System.EventHandler(this.cmbMaKho2_SelectedIndexChanged);
            // 
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.dS;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDATHANG, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(99, 112);
            this.txtMAKHO.MenuManager = this.barManager1;
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(100, 20);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDATHANG, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(282, 27);
            this.txtNhaCC.MenuManager = this.barManager1;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(100, 20);
            this.txtNhaCC.TabIndex = 5;
            // 
            // txtMaDDH1
            // 
            this.txtMaDDH1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDATHANG, "MasoDDH", true));
            this.txtMaDDH1.Location = new System.Drawing.Point(99, 27);
            this.txtMaDDH1.MenuManager = this.barManager1;
            this.txtMaDDH1.Name = "txtMaDDH1";
            this.txtMaDDH1.Size = new System.Drawing.Size(100, 20);
            this.txtMaDDH1.TabIndex = 1;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDatHang";
            this.Text = "FormDonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grCTDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.grDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDATHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grNLCTDDH.ResumeLayout(false);
            this.grNLCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).EndInit();
            this.grNLDDH.ResumeLayout(false);
            this.grNLDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemPhieu;
        private DevExpress.XtraBars.BarButtonItem btnXoaPhieu;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnQuayLai;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnXoaChiTiet;
        private DevExpress.XtraBars.BarButtonItem btnQuayLaiCT;
        private DevExpress.XtraBars.BarButtonItem btnQuayLaiChiTiet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_PhanManh dS_PhanManh;
        private System.Windows.Forms.Panel panel1;
        private DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_PhanManhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grCTDDH;
        private System.Windows.Forms.GroupBox grDDH;
        private System.Windows.Forms.GroupBox grNLDDH;
        private System.Windows.Forms.GroupBox grNLCTDDH;
        private DSTableAdapters.DATHANGTableAdapter dATHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsDATHANG;
        private DevExpress.XtraGrid.GridControl gcDATHANG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private DevExpress.XtraEditors.TextEdit txtMaDDH1;
        private DevExpress.XtraEditors.SpinEdit txtSOLUONG;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMaDDH2;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTiet;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private DSTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaVatTu2;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private DSTableAdapters.KHOTableAdapter kHOTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaKho2;
        private DevExpress.XtraBars.BarButtonItem btnLuuCT;
        private DevExpress.XtraEditors.TextEdit txtDONGIA;
        private DevExpress.XtraBars.BarButtonItem btnUndoPhieu;
        private DevExpress.XtraBars.BarButtonItem btnUndoCTPhieu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.DateEdit dptNgay;
        private System.Windows.Forms.ComboBox cmbMANV1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
    }
}