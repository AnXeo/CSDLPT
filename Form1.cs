using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVATTU
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmMain()
        {
            InitializeComponent();
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void hienThi()
        {
            barNHANVIEN.Enabled = true;
            barVATTU.Enabled = true;
            barKHO.Enabled = true;
        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn lưu tất cả các thay đổi trước khi thoát!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }

        
        }
        public void HienThiMenu()
        {

           
            Program.frmChinh.MANV.Text = "Mã nhân viên : " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên : " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền

            if (Program.mGroup != "")
            {
                this.rbDanhMuc.Visible = true;
                btnDangNhap.Enabled = false;
                btnTaoTK.Enabled = false;
                btnDangxuat.Enabled = true;
            }
            else
            {
                rbDanhMuc.Visible = false;
                this.rbPageGroupNV.Visible = true;
                btnDangNhap.Enabled = true;
                btnTaoTK.Enabled = false;
                btnDangxuat.Enabled = false;
                //this.ribbonPageGroupTaoTaiKhoan.Visible = true;
            }
            if (Program.mGroup == "CONGTY")
                btnTaoTK.Enabled = true;

         // Tắt button Đăng nhập trên form chính
           

        }
        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất khỏi phiên làm việc ?", "Xác nhận đăng xuất...", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.frmChinh.MANV.Text = "";
                Program.username = "";
                Program.frmChinh.HOTEN.Text = "";
                Program.mHoten = "";
                Program.frmChinh.NHOM.Text = "";
                Program.mGroup = "";
                rbDanhMuc.Visible = false;
                btnDangNhap.Enabled = true;
                btnDangxuat.Enabled = false;
                Form frm = this.CheckExists(typeof(frmDangNhap));
                if (frm != null) frm.Activate();
                else
                {
                    frmDangNhap f = new frmDangNhap();
                    f.MdiParent = Program.frmChinh;
                    f.Show();
                }
            }

           

        }

        private void barVATTU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
            
        }

        private void barNHANVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barKHO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
        }

        private void barDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmDatHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDatHang f = new frmDatHang();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
           
            
        }

        private void btnVATTU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPHIEUNHAP));
            if (frm != null) frm.Activate();
            else
            {
                frmPHIEUNHAP f = new frmPHIEUNHAP();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCTPN));
            if (frm != null) frm.Activate();
            else
            {
                frmCTPN f = new frmCTPN();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formCTPX));
            if (frm != null) frm.Activate();
            else
            {
                formCTPX f = new formCTPX();
                f.MdiParent = Program.frmChinh;
                f.Show();
            }
        }
    }
}
