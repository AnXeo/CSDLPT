namespace QLVATTU
{
    partial class frmPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDS = new DevExpress.XtraBars.BarButtonItem();
            this.btnPHIEUNHAP = new DevExpress.XtraBars.BarButtonItem();
            this.btnPHIEUXUAT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDATHANG = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayLai = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.vbdspm = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PhanManh = new QLVATTU.DS_PhanManh();
            this.label1 = new System.Windows.Forms.Label();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.qLPN = new QLVATTU.QLPN();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.VbdsMaNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPX = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtHoTenKH = new DevExpress.XtraEditors.TextEdit();
            this.cmbMaKho = new System.Windows.Forms.ComboBox();
            this.pHIEUXUATTableAdapter = new QLVATTU.QLPNTableAdapters.PHIEUXUATTableAdapter();
            this.tableAdapterManager = new QLVATTU.QLPNTableAdapters.TableAdapterManager();
            this.VbdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.v_KHOTableAdapter = new QLVATTU.QLPNTableAdapters.V_KHOTableAdapter();
            this.v_MANVTableAdapter = new QLVATTU.QLPNTableAdapters.V_MANVTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLVATTU.DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbdspm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VbdsMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VbdsKho)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(30, 47);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(42, 13);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã PX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(30, 73);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(35, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(30, 99);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(57, 13);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Họ tên KH";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(30, 125);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(43, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(30, 154);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho:";
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
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnDS,
            this.btnThoat,
            this.btnPHIEUNHAP,
            this.btnPHIEUXUAT,
            this.btnDATHANG,
            this.btnQuayLai});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::QLVATTU.Properties.Resources.Button_Add_24_icon1;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = global::QLVATTU.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Id = 1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = global::QLVATTU.Properties.Resources.Text_Edit_icon_241;
            this.btnSua.Id = 2;
            this.btnSua.Name = "btnSua";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Lưu";
            this.btnGhi.Glyph = global::QLVATTU.Properties.Resources.Save_icon_24;
            this.btnGhi.Id = 3;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Glyph = global::QLVATTU.Properties.Resources.Undo_icon_24;
            this.btnUndo.Id = 4;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = global::QLVATTU.Properties.Resources.Button_Refresh_icon_24;
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = global::QLVATTU.Properties.Resources.Exit_24_icon;
            this.btnThoat.Id = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(983, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Size = new System.Drawing.Size(983, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 358);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(983, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 358);
            // 
            // btnDS
            // 
            this.btnDS.Caption = "InDSKho";
            this.btnDS.Glyph = global::QLVATTU.Properties.Resources.Business_Department_24_icon1;
            this.btnDS.Id = 6;
            this.btnDS.Name = "btnDS";
            // 
            // btnPHIEUNHAP
            // 
            this.btnPHIEUNHAP.Caption = "Phiếu Nhập";
            this.btnPHIEUNHAP.Glyph = global::QLVATTU.Properties.Resources.form_32_icon;
            this.btnPHIEUNHAP.Id = 8;
            this.btnPHIEUNHAP.Name = "btnPHIEUNHAP";
            // 
            // btnPHIEUXUAT
            // 
            this.btnPHIEUXUAT.Caption = "Phiếu Xuất";
            this.btnPHIEUXUAT.Glyph = global::QLVATTU.Properties.Resources.folder_flower_blue_CVDI_icon;
            this.btnPHIEUXUAT.Id = 9;
            this.btnPHIEUXUAT.Name = "btnPHIEUXUAT";
            // 
            // btnDATHANG
            // 
            this.btnDATHANG.Caption = "Đặt Hàng";
            this.btnDATHANG.Glyph = global::QLVATTU.Properties.Resources.report_48_icon;
            this.btnDATHANG.Id = 10;
            this.btnDATHANG.Name = "btnDATHANG";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Caption = "Quay Lại";
            this.btnQuayLai.Glyph = global::QLVATTU.Properties.Resources.if___Left_1904658;
            this.btnQuayLai.Id = 11;
            this.btnQuayLai.Name = "btnQuayLai";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 36);
            this.panel1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.vbdspm;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(350, 6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(343, 21);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            // 
            // vbdspm
            // 
            this.vbdspm.DataMember = "V_DS_PHANMANH";
            this.vbdspm.DataSource = this.dS_PhanManh;
            // 
            // dS_PhanManh
            // 
            this.dS_PhanManh.DataSetName = "DS_PhanManh";
            this.dS_PhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcPX.Location = new System.Drawing.Point(0, 68);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(615, 322);
            this.gcPX.TabIndex = 6;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PHIEUXUAT";
            this.bdsPX.DataSource = this.qLPN;
            // 
            // qLPN
            // 
            this.qLPN.DataSetName = "QLPN";
            this.qLPN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO,
            this.colrowguid});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên KH";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(mAPXLabel);
            this.groupBox1.Controls.Add(this.txtMaPX);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(hOTENKHLabel);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(mAKHOLabel);
            this.groupBox1.Controls.Add(this.cmbMaKho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(615, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.cmbMaNV.DataSource = this.bdsPX;
            this.cmbMaNV.DisplayMember = "MANV";
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(99, 125);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaNV.TabIndex = 10;
            this.cmbMaNV.ValueMember = "MANV";
            // 
            // VbdsMaNV
            // 
            this.VbdsMaNV.DataMember = "V_MANV";
            this.VbdsMaNV.DataSource = this.qLPN;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(99, 44);
            this.txtMaPX.MenuManager = this.barManager1;
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(121, 20);
            this.txtMaPX.TabIndex = 1;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(99, 70);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(121, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.txtHoTenKH.Location = new System.Drawing.Point(99, 96);
            this.txtHoTenKH.MenuManager = this.barManager1;
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(121, 20);
            this.txtHoTenKH.TabIndex = 5;
            // 
            // cmbMaKho
            // 
            this.cmbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.cmbMaKho.DataSource = this.bdsPX;
            this.cmbMaKho.DisplayMember = "MAKHO";
            this.cmbMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKho.FormattingEnabled = true;
            this.cmbMaKho.Location = new System.Drawing.Point(99, 151);
            this.cmbMaKho.Name = "cmbMaKho";
            this.cmbMaKho.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKho.TabIndex = 9;
            this.cmbMaKho.ValueMember = "MAKHO";
            // 
            // pHIEUXUATTableAdapter
            // 
            this.pHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = this.pHIEUXUATTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVATTU.QLPNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // VbdsKho
            // 
            this.VbdsKho.DataMember = "V_KHO";
            this.VbdsKho.DataSource = this.qLPN;
            // 
            // v_KHOTableAdapter
            // 
            this.v_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // v_MANVTableAdapter
            // 
            this.v_MANVTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbdspm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VbdsMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VbdsKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnDS;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPHIEUNHAP;
        private DevExpress.XtraBars.BarButtonItem btnPHIEUXUAT;
        private DevExpress.XtraBars.BarButtonItem btnDATHANG;
        private DevExpress.XtraBars.BarButtonItem btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private QLPN qLPN;
        private System.Windows.Forms.BindingSource bdsPX;
        private QLPNTableAdapters.PHIEUXUATTableAdapter pHIEUXUATTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.TextEdit txtMaPX;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtHoTenKH;
        private System.Windows.Forms.ComboBox cmbMaKho;
        private QLPNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource VbdsKho;
        private QLPNTableAdapters.V_KHOTableAdapter v_KHOTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.BindingSource VbdsMaNV;
        private QLPNTableAdapters.V_MANVTableAdapter v_MANVTableAdapter;
        private DS_PhanManh dS_PhanManh;
        private System.Windows.Forms.BindingSource vbdspm;
        private DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}