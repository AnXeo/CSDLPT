using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVATTU
{
    public partial class frmDatHang : Form
    {
        public int vitri1;
        public int vitri2;
        public int lc;
        public String masoddh = "";
        public String nhacc = "";
        public String makho = "";
        public int manv;
        public static DateTime ngay;
        public frmDatHang()
        {
            InitializeComponent();
        }
        public Stack st = new Stack();
        public class Undo
        {
            int type;
            String lenh;

            public Undo(int t, String l)
            {
                this.type = t;
                this.lenh = l;
            }

            public int getType()
            {
                return type;
            }
            public String getLenh()
            {
                return lenh;
            }
        }
        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dATHANGTableAdapter.Fill(this.dS.DATHANG);
            // TODO: This line of code loads data into the 'dS.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vATTUTableAdapter.Fill(this.dS.VATTU);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOTableAdapter.Fill(this.dS.KHO);
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
          

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThemPhieu.Enabled=btnLuu.Enabled = btnQuayLai.Enabled = btnThoat.Enabled = false;
                btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled = btnLuuCT.Enabled = btnQuayLaiChiTiet.Enabled = false;
                groupBox2.Enabled = groupBox1.Enabled = false;
                btnThemChiTiet.Enabled = btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnQuayLaiCT.Enabled = false;

            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnLuuCT.Enabled = false;
               

            }

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
                if (cmbChiNhanh.SelectedValue != null)
                    Program.servername = cmbChiNhanh.SelectedValue.ToString();
               
            }
            catch (Exception ex)
            {

            }

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;

            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dATHANGTableAdapter.Fill(this.dS.DATHANG);


                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            }
        }
        private void btnXemChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            string xCTDDH = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {
                    xCTDDH = ((DataRowView)bdsDATHANG[bdsDATHANG.Position])["MasoDDH"].ToString();
                    bdsCTDDH.RemoveCurrent();
                    this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dATHANGTableAdapter.Update(this.dS.DATHANG);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Xóa chi tiết đơn hàng không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dATHANGTableAdapter.Fill(this.dS.DATHANG);
                    bdsDATHANG.Position = bdsDATHANG.Find("MasoDDH", xCTDDH);
                }

            if (bdsCTDDH.Count == 0)
                btnXoaChiTiet.Enabled = false;
        }

        private void btnThemCHiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri2 = bdsCTDDH.Position;

            txtMAVT.Enabled = false;
            txtMaDDH2.Enabled = false;
            bdsCTDDH.AddNew();
            txtMaDDH2.Text = txtMaDDH1.Text;
            btnLuuCT.Enabled = btnQuayLaiCT.Enabled =btnThoat.Enabled= true;
            btnThemPhieu.Enabled=btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled  = false;
            gcDATHANG.Enabled = btnQuayLai.Enabled=btnLuu.Enabled=false;
            btnLuu.Enabled=gcCTDDH.Enabled = false;
            grNLCTDDH.Enabled = true;
            grNLDDH.Enabled = false;
            txtMAVT.Enabled = false;
            lc = 1;

        }

        private void cmbMaVatTu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAVT.Text = cmbMaVatTu2.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAVT.Text = cmbMANV1.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
                MessageBox.Show("KHO da tao phieu nen khong the xoa");
            else
            {
                String xMasoDDH = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu này ? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        xMasoDDH = ((DataRowView)bdsDATHANG[bdsDATHANG.Position])["MasoDDH"].ToString();
                        bdsDATHANG.RemoveCurrent();
                        this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dATHANGTableAdapter.Update(this.dS.DATHANG);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa phiếu không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dATHANGTableAdapter.Fill(this.dS.DATHANG);
                        bdsDATHANG.Position = bdsDATHANG.Find("MasoDDH", xMasoDDH);
                    }
            }
        }

        private void cmbMaKho2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKHO.Text = cmbMaKho2.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThemPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = bdsDATHANG.Position;
            bdsDATHANG.AddNew();
            btnLuu.Enabled = btnQuayLai.Enabled = btnThoat.Enabled=true;
            btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled = btnLuuCT.Enabled = btnQuayLaiChiTiet.Enabled = false;
            gcDATHANG.Enabled = false;
            gcCTDDH.Enabled = false;
            grNLCTDDH.Enabled = false;
            grNLDDH.Enabled = true;
            btnThemChiTiet.Enabled = btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnQuayLaiCT.Enabled=false;
            lc = 1;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (lc == 1)
            {
                dS.EnforceConstraints = false;
                if (txtMaDDH1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã đơn đặt hàng !", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                SqlDataReader myReader;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KiemTraDDHTonTai";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MasoDDH", SqlDbType.Int).Value = txtMaDDH1.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                try
                {


                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã đơn đặt hàng đã tồn tại !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                        txtMaDDH1.Focus();
                        return;
                    }
                    if (txtNhaCC.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập nhà cung cấp !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtNhaCC.Focus();
                        return;

                    }
                    if (dptNgay.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập ngày !", "THÔNG BÁO", MessageBoxButtons.OK);
                        dptNgay.Focus();
                        return;
                    }
                    if (cmbMANV1.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn mã nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                        cmbMANV1.Focus();

                        return;
                    }
                    if (cmbMaKho2.Text == "")
                    {
                        MessageBox.Show("Vui chọn tên kho !", "THÔNG BÁO", MessageBoxButtons.OK);
                        cmbMaKho2.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                { }

                try
                {
                    bdsDATHANG.EndEdit();
                    bdsDATHANG.ResetCurrentItem();
                    this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dATHANGTableAdapter.Update(this.dS.DATHANG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Đơn đặt h.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thêm Đơn đặt hàng Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                gcDATHANG.Enabled = true;
                grNLDDH.Enabled = gcCTDDH.Enabled = grNLCTDDH.Enabled = false;
                btnLuu.Enabled = btnQuayLai.Enabled = false;
                btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnSua.Enabled = btnXoaChiTiet.Enabled = btnThemChiTiet.Enabled = true;
                btnReload.Enabled = btnQuayLaiCT.Enabled = btnQuayLaiChiTiet.Enabled = false;
                return;
            }
            else
                if (lc == 2)
            {
                gcDATHANG.Enabled = gcCTDDH.Enabled = true;
                btnThemPhieu.Enabled = btnSua.Enabled = btnXoaPhieu.Enabled = btnReload.Enabled = false; ;
                btnQuayLai.Enabled = false;
                btnUndoPhieu.Enabled = true;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = bdsDATHANG.Position;          
            txtMaDDH1.Enabled = false;
            btnLuu.Enabled = btnQuayLai.Enabled = btnThoat.Enabled = true;
            btnThemPhieu.Enabled=btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled = btnLuuCT.Enabled = btnQuayLaiChiTiet.Enabled = false;
            gcDATHANG.Enabled = false;
            gcCTDDH.Enabled = false;
            grNLCTDDH.Enabled = false;
            grNLDDH.Enabled = true;
            lc = 2;//sửa
        }



        private void btnQuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDATHANG.Position = vitri1;
            bdsDATHANG.CancelEdit();
            gcDATHANG.Enabled = gcCTDDH.Enabled = true;
            btnReload.PerformClick();
            btnLuu.Enabled = btnQuayLai.Enabled = btnThoat.Enabled = btnThemPhieu.Enabled = btnThemChiTiet.Enabled = true;
            btnXoaPhieu.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled = btnLuuCT.Enabled = btnQuayLaiCT.Enabled = true;
            gcDATHANG.Enabled = true;
            gcCTDDH.Enabled = true;
            grNLCTDDH.Enabled =grNLDDH.Enabled= false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dATHANGTableAdapter.Fill(this.dS.DATHANG);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLuuCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {        
                dS.EnforceConstraints = false;
                if (txtMaDDH1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã đơn đặt hàng !", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                if (txtSOLUONG.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtSOLUONG.Focus();
                    return;
                }
                if (txtMAVT.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Tên Vật Tư !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtMAVT.Focus();
                    return;
                }
                if (txtDONGIA.Text == "")
                {
                    MessageBox.Show("Vui lòngnhập đơn giá !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtDONGIA.Focus();
                    return;
                }
                try
                {
                    bdsCTDDH.EndEdit();
                    bdsCTDDH.ResetCurrentItem();
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Update(this.dS.CTDDH);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết đơn h.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thêm chi tiết Đơn đặt hàng Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                gcDATHANG.Enabled = gcCTDDH.Enabled = true;
                grNLDDH.Enabled =  grNLCTDDH.Enabled = false;
                btnLuu.Enabled = btnQuayLai.Enabled = false;
                btnThemChiTiet.Enabled = btnXoaPhieu.Enabled = btnSua.Enabled = btnXoaChiTiet.Enabled = btnThemChiTiet.Enabled = true;
                btnReload.Enabled = btnQuayLaiCT.Enabled = btnQuayLaiChiTiet.Enabled = false;
                return;                     
        }

        private void cmbMANV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMANV.Text = cmbMANV1.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn lưu tất cả các thay đổi trước khi thoát!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
               
        }

        private void btnQuayLaiChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLuuChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTDDH.Position = vitri1;
            bdsCTDDH.CancelEdit();
            gcDATHANG.Enabled = gcCTDDH.Enabled = true;
            btnReload.PerformClick();
            btnLuu.Enabled = btnQuayLai.Enabled = btnThoat.Enabled = btnThemPhieu.Enabled = btnThemChiTiet.Enabled = true;
            btnXoaPhieu.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoaChiTiet.Enabled = btnLuuCT.Enabled = btnQuayLaiChiTiet.Enabled = true;
            gcDATHANG.Enabled = true;
            gcCTDDH.Enabled = true;
            grNLCTDDH.Enabled = grNLDDH.Enabled = false;
        }

       
    }
}
