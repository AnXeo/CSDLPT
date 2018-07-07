namespace QLVATTU
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barNHANVIEN = new DevExpress.XtraBars.BarButtonItem();
            this.barKHO = new DevExpress.XtraBars.BarButtonItem();
            this.barVATTU = new DevExpress.XtraBars.BarButtonItem();
            this.barDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnVATTU = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.rbQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroupNV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroupNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroupVT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroupKHO = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroupPHIEU = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnThoat,
            this.btnDangxuat,
            this.btnTaoTK,
            this.barNHANVIEN,
            this.barKHO,
            this.barVATTU,
            this.barDDH,
            this.btnDSNV,
            this.btnVATTU,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbQuanTri,
            this.rbDanhMuc,
            this.rbBaoCao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1011, 162);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = global::QLVATTU.Properties.Resources.Apps_session_Exit_icon_48;
            this.btnThoat.Id = 2;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Đăng xuất";
            this.btnDangxuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Glyph")));
            this.btnDangxuat.Id = 3;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.Glyph")));
            this.btnTaoTK.Id = 4;
            this.btnTaoTK.Name = "btnTaoTK";
            // 
            // barNHANVIEN
            // 
            this.barNHANVIEN.Caption = "NHÂN VIÊN";
            this.barNHANVIEN.Glyph = ((System.Drawing.Image)(resources.GetObject("barNHANVIEN.Glyph")));
            this.barNHANVIEN.Id = 5;
            this.barNHANVIEN.LargeGlyph = global::QLVATTU.Properties.Resources.Teacher_male_icon_48;
            this.barNHANVIEN.Name = "barNHANVIEN";
            this.barNHANVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNHANVIEN_ItemClick);
            // 
            // barKHO
            // 
            this.barKHO.Caption = "KHO";
            this.barKHO.Glyph = ((System.Drawing.Image)(resources.GetObject("barKHO.Glyph")));
            this.barKHO.Id = 6;
            this.barKHO.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barKHO.LargeGlyph")));
            this.barKHO.Name = "barKHO";
            this.barKHO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKHO_ItemClick);
            // 
            // barVATTU
            // 
            this.barVATTU.Caption = "VẬT TƯ";
            this.barVATTU.Glyph = ((System.Drawing.Image)(resources.GetObject("barVATTU.Glyph")));
            this.barVATTU.Id = 7;
            this.barVATTU.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barVATTU.LargeGlyph")));
            this.barVATTU.Name = "barVATTU";
            this.barVATTU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVATTU_ItemClick);
            // 
            // barDDH
            // 
            this.barDDH.Caption = "ĐƠN ĐẶT HÀNG";
            this.barDDH.Glyph = ((System.Drawing.Image)(resources.GetObject("barDDH.Glyph")));
            this.barDDH.Id = 8;
            this.barDDH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barDDH.LargeGlyph")));
            this.barDDH.Name = "barDDH";
            this.barDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDDH_ItemClick);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Caption = "Danh Sách Nhân Viên";
            this.btnDSNV.Id = 9;
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNV_ItemClick);
            // 
            // btnVATTU
            // 
            this.btnVATTU.Caption = "Danh Sach Vat Tu";
            this.btnVATTU.Id = 10;
            this.btnVATTU.Name = "btnVATTU";
            this.btnVATTU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVATTU_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "PHIẾU NHẬP";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "CTPN";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "PHIEU XUAT";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "CTPX";
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // rbQuanTri
            // 
            this.rbQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroupNV,
            this.ribbonPageGroup1});
            this.rbQuanTri.Image = ((System.Drawing.Image)(resources.GetObject("rbQuanTri.Image")));
            this.rbQuanTri.Name = "rbQuanTri";
            this.rbQuanTri.Text = "Quản trị";
            // 
            // rbPageGroupNV
            // 
            this.rbPageGroupNV.ItemLinks.Add(this.btnDangNhap);
            this.rbPageGroupNV.ItemLinks.Add(this.btnThoat);
            this.rbPageGroupNV.ItemLinks.Add(this.btnDangxuat);
            this.rbPageGroupNV.Name = "rbPageGroupNV";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbDanhMuc
            // 
            this.rbDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroupNhanVien,
            this.rbPageGroupVT,
            this.rbPageGroupKHO,
            this.rbPageGroupPHIEU,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.rbDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("rbDanhMuc.Image")));
            this.rbDanhMuc.Name = "rbDanhMuc";
            this.rbDanhMuc.Text = "DANH MỤC";
            // 
            // rbPageGroupNhanVien
            // 
            this.rbPageGroupNhanVien.ItemLinks.Add(this.barNHANVIEN);
            this.rbPageGroupNhanVien.Name = "rbPageGroupNhanVien";
            // 
            // rbPageGroupVT
            // 
            this.rbPageGroupVT.ItemLinks.Add(this.barVATTU);
            this.rbPageGroupVT.Name = "rbPageGroupVT";
            // 
            // rbPageGroupKHO
            // 
            this.rbPageGroupKHO.ItemLinks.Add(this.barKHO);
            this.rbPageGroupKHO.Name = "rbPageGroupKHO";
            // 
            // rbPageGroupPHIEU
            // 
            this.rbPageGroupPHIEU.ItemLinks.Add(this.barDDH);
            this.rbPageGroupPHIEU.Name = "rbPageGroupPHIEU";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSNV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVATTU);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(43, 17);
            this.MANV.Text = "Mã NV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "Họ Tên";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(41, 17);
            this.NHOM.Text = "Nhóm";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 498);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ VẬT TƯ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupNV;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDanhMuc;
        private DevExpress.XtraBars.BarButtonItem barNHANVIEN;
        private DevExpress.XtraBars.BarButtonItem barKHO;
        private DevExpress.XtraBars.BarButtonItem barVATTU;
        private DevExpress.XtraBars.BarButtonItem barDDH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupKHO;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroupPHIEU;
        private DevExpress.XtraBars.BarButtonItem btnDSNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnVATTU;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}

