namespace QLVATTU
{
    partial class formCTPX
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
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
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.qLPN = new QLVATTU.QLPN();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMAPX = new System.Windows.Forms.ComboBox();
            this.cmbMAVT = new System.Windows.Forms.ComboBox();
            this.txtDONGIA = new DevExpress.XtraEditors.SpinEdit();
            this.txtSOLUONG = new DevExpress.XtraEditors.TextEdit();
            this.v_bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.v_MAVTTableAdapter = new QLVATTU.QLPNTableAdapters.V_MAVTTableAdapter();
            this.tableAdapterManager = new QLVATTU.QLPNTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVATTU.QLPNTableAdapters.CTPXTableAdapter();
            this.v_DS_PHANMANHTableAdapter = new QLVATTU.DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbdspm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_bdsVT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(96, 86);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(42, 13);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã PX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(96, 113);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(42, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(96, 137);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(52, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(96, 163);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(47, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(918, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Size = new System.Drawing.Size(918, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(918, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
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
            this.panel1.Size = new System.Drawing.Size(918, 36);
            this.panel1.TabIndex = 6;
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
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
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
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcCTPX.Location = new System.Drawing.Point(0, 68);
            this.gcCTPX.MainView = this.gridView1;
            this.gcCTPX.MenuManager = this.barManager1;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(579, 391);
            this.gcCTPX.TabIndex = 7;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "CTPX";
            this.bdsCTPX.DataSource = this.qLPN;
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
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA,
            this.colrowguid});
            this.gridView1.GridControl = this.gcCTPX;
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
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mAPXLabel);
            this.groupBox1.Controls.Add(this.cmbMAPX);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.cmbMAVT);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.txtDONGIA);
            this.groupBox1.Controls.Add(this.txtSOLUONG);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(579, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 391);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cmbMAPX
            // 
            this.cmbMAPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAPX", true));
            this.cmbMAPX.DataSource = this.bdsCTPX;
            this.cmbMAPX.DisplayMember = "MAPX";
            this.cmbMAPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAPX.FormattingEnabled = true;
            this.cmbMAPX.Location = new System.Drawing.Point(165, 83);
            this.cmbMAPX.Name = "cmbMAPX";
            this.cmbMAPX.Size = new System.Drawing.Size(121, 21);
            this.cmbMAPX.TabIndex = 1;
            this.cmbMAPX.ValueMember = "MAPX";
            // 
            // cmbMAVT
            // 
            this.cmbMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.cmbMAVT.DataSource = this.bdsCTPX;
            this.cmbMAVT.DisplayMember = "MAVT";
            this.cmbMAVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAVT.FormattingEnabled = true;
            this.cmbMAVT.Location = new System.Drawing.Point(165, 110);
            this.cmbMAVT.Name = "cmbMAVT";
            this.cmbMAVT.Size = new System.Drawing.Size(121, 21);
            this.cmbMAVT.TabIndex = 3;
            this.cmbMAVT.ValueMember = "MAVT";
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "DONGIA", true));
            this.txtDONGIA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDONGIA.Location = new System.Drawing.Point(165, 160);
            this.txtDONGIA.MenuManager = this.barManager1;
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDONGIA.Size = new System.Drawing.Size(121, 20);
            this.txtDONGIA.TabIndex = 7;
            // 
            // txtSOLUONG
            // 
            this.txtSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "SOLUONG", true));
            this.txtSOLUONG.EditValue = "";
            this.txtSOLUONG.Location = new System.Drawing.Point(165, 134);
            this.txtSOLUONG.MenuManager = this.barManager1;
            this.txtSOLUONG.Name = "txtSOLUONG";
            this.txtSOLUONG.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtSOLUONG.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSOLUONG.Size = new System.Drawing.Size(121, 20);
            this.txtSOLUONG.TabIndex = 5;
            this.txtSOLUONG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSOLUONG_KeyPress);
            // 
            // v_bdsVT
            // 
            this.v_bdsVT.DataMember = "V_MAVT";
            this.v_bdsVT.DataSource = this.qLPN;
            // 
            // v_MAVTTableAdapter
            // 
            this.v_MAVTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVATTU.QLPNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // formCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formCTPX";
            this.Text = "formCTPX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbdspm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONGIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_bdsVT)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource v_bdsVT;
        private QLPN qLPN;
        private QLPNTableAdapters.V_MAVTTableAdapter v_MAVTTableAdapter;
        private QLPNTableAdapters.TableAdapterManager tableAdapterManager;
        private QLPNTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.ComboBox cmbMAPX;
        private System.Windows.Forms.ComboBox cmbMAVT;
        private DevExpress.XtraEditors.SpinEdit txtDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.TextEdit txtSOLUONG;
        private DS_PhanManh dS_PhanManh;
        private System.Windows.Forms.BindingSource vbdspm;
        private DS_PhanManhTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}