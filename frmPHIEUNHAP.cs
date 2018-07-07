using System;
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
    public partial class frmPHIEUNHAP : Form
    {
        int flag = 0;
        String maPN, ngay, masoDDH, maNV, maKho;
        private SqlDataReader myreader;
        String str_Lenh;
        public static string MaPN = "";
        public static string NGAY = "";
        public static string MasoDDH = "";
        public static string MaKHO = "";
        public static string MaNV = "";
        
        public frmPHIEUNHAP()
        {
            InitializeComponent();
        }
        public void phanQuyen(Boolean a, Boolean b, Boolean c, Boolean d, Boolean e, Boolean f)
        {
            btnThem.Enabled = a;
            btnSua.Enabled = b;
            btnGhi.Enabled = c;
            btnXoa.Enabled = d;
            btnUndo.Enabled = e;
            btnReload.Enabled = f;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPN.CancelEdit();
            this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            if (btnThem.Enabled == false) bdsPN.Position = vitri;
            gcPN.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnSua.Enabled = btnUndo.Enabled = false;

            cmbMaSoDDH.DataSource = bdsPN;
            cmbMaSoDDH.DisplayMember = "MasoDDH";
            cmbMaSoDDH.ValueMember = "MasoDDH";

            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = bdsPN;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = bdsPN;
            cmbMaKho.DisplayMember = "MAKHO";
            cmbMaKho.ValueMember = "MAKHO";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }

            if (cmbMaSoDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã Số DDH ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (cmbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã NV ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (cmbMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã Kho ko được thi!", "", MessageBoxButtons.OK);

                return;
            }
            if (flag == 1)
            {
                try
                {
                    maPN = txtMaPN.Text.Trim();
                    ngay = txtNgay.Text.Trim();
                    masoDDH = cmbMaSoDDH.SelectedValue.ToString();
                    maNV = cmbMaNV.SelectedValue.ToString();
                    maKho = cmbMaKho.SelectedValue.ToString();

                    str_Lenh = "EXEC SP_KiemTraPN '" + maPN + "','" + masoDDH + "','" + maNV + "','" + maKho + "'";

                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    if (myreader == null) return;

                    myreader.Read();
                    int a = myreader.GetInt32(0);
                    myreader.Close();

                    if (a == 0)
                    {
                        MessageBox.Show("Ma da trung");

                    }
                    else
                    {
                        MessageBox.Show("THEM  OK");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khi Them\n " + ex.Message, "", MessageBoxButtons.OK);
                }

            }
            if (flag == 2)
            {
                // KO CHO SUA

            }

            this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            phanQuyen(true, true, false, true, true, true);
            gcPN.Enabled = true;
            groupBox1.Enabled = false;
            cmbMaSoDDH.Enabled = true;
            // GAN LAI BDS CHO 3 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW
            cmbMaSoDDH.DataSource = bdsPN;
            cmbMaSoDDH.DisplayMember = "MasoDDH";
            cmbMaSoDDH.ValueMember = "MasoDDH";

            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = bdsPN;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = bdsPN;
            cmbMaKho.DisplayMember = "MAKHO";
            cmbMaKho.ValueMember = "MAKHO";
            flag = 0;

        }

        int vitri = 0;

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //flag = 2;
            //txtNgay.ReadOnly = true;
            //txtMaPN.ReadOnly = true;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
                if (cmbChiNhanh.SelectedValue != null)
                    Program.servername = cmbChiNhanh.SelectedValue.ToString();
                //MessageBox.Show(Program.servername);
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
                this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPN.Position;
            groupBox1.Enabled = true;
            bdsPN.AddNew();

            phanQuyen(false, false, true, false, true, false);
            gcPN.Enabled = false;
            flag = 1;
            // GAN LAI BDS CHO 3 CMB DE SHOW NHUNG VALUE CAN THIET
            cmbMaSoDDH.Enabled = true;
            cmbMaSoDDH.DataSource = VbdsDDH;
            cmbMaSoDDH.DisplayMember = "MasoDDH";
            cmbMaSoDDH.ValueMember = "MasoDDH";

            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = VbdsMaNV;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = VbdsKho;
            cmbMaKho.DisplayMember = "TENKHO";
            cmbMaKho.ValueMember = "MAKHO";
        }

        private void frmPHIEUNHAP_Load(object sender, EventArgs e)
        {
            qLPN.EnforceConstraints = false;
            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLPN.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            
            // TODO: This line of code loads data into the 'qLPN.V_MAVT' table. You can move, or remove it, as needed.
            this.v_MAVTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MAVTTableAdapter.Fill(this.qLPN.V_MAVT);
            // TODO: This line of code loads data into the 'qLPN.V_MaDDH' table. You can move, or remove it, as needed.
            this.v_MaDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MaDDHTableAdapter.Fill(this.qLPN.V_MaDDH);
            // TODO: This line of code loads data into the 'qLPN.V_MANV' table. You can move, or remove it, as needed.
            this.v_MANVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MANVTableAdapter.Fill(this.qLPN.V_MANV);
            // TODO: This line of code loads data into the 'qLPN.V_KHO' table. You can move, or remove it, as needed.
            this.v_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_KHOTableAdapter.Fill(this.qLPN.V_KHO);
            // TODO: This line of code loads data into the 'qLPN.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            // TODO: This line of code loads data into the 'qLPN.V_KHO' table. You can move, or remove it, as needed.
            this.v_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_KHOTableAdapter.Fill(this.qLPN.V_KHO);
            // TODO: This line of code loads data into the 'qLPN.V_MaDDH' table. You can move, or remove it, as needed.
            this.v_MaDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MaDDHTableAdapter.Fill(this.qLPN.V_MaDDH);

            // TODO: This line of code loads data into the 'nGANHANGDataSet1.NHANVIEN' table. You can move, or remove it, as needed.

            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            MessageBox.Show(Program.connstr);
            this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
            groupBox1.Enabled = false;

            cmbChiNhanh.DataSource = vbdspm;
            //cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm dă load ? form dang nh?p  qua
            try
            {
                cmbChiNhanh.DisplayMember = "TENCN";
                cmbChiNhanh.ValueMember = "TENSERVER";
                cmbChiNhanh.SelectedIndex = Program.mChinhanh;

                if (Program.mGroup == "CONGTY")
                {
                    cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
                    btnGhi.Enabled = btnUndo.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnReload.Enabled = false;

                    groupBox1.Enabled = false;

                }
                else
                {
                    cmbChiNhanh.Enabled = false;
                    groupBox1.Enabled = false;

                    btnGhi.Enabled = btnUndo.Enabled = btnUndo.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnReload.Enabled = true;

                }
            }catch(Exception ex)
            {

            }
           


        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
                // GAN LAI BDS CHO 3 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW
                cmbMaSoDDH.DataSource = bdsPN;
                cmbMaSoDDH.DisplayMember = "MasoDDH";
                cmbMaSoDDH.ValueMember = "MasoDDH";

                cmbMaNV.Enabled = true;
                cmbMaNV.DataSource = bdsPN;
                cmbMaNV.DisplayMember = "MANV";
                cmbMaNV.ValueMember = "MANV";

                cmbMaKho.Enabled = true;
                cmbMaKho.DataSource = bdsPN;
                cmbMaKho.DisplayMember = "MAKHO";
                cmbMaKho.ValueMember = "MAKHO";

                if (Program.mGroup == "CONGTY")
                {
                    cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
                    btnGhi.Enabled = btnUndo.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnReload.Enabled = false;

                    groupBox1.Enabled = false;

                }
                else
                {
                    cmbChiNhanh.Enabled = false;
                    groupBox1.Enabled = false;

                    btnGhi.Enabled = btnUndo.Enabled = btnUndo.Enabled = false;
                    btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnReload.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                try
                {
                    maPN = txtMaPN.Text.Trim();
                    str_Lenh = "EXEC SP_XOAPN '" + maPN + "'";
                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    this.pHIEUNHAPTableAdapter.Fill(this.qLPN.PHIEUNHAP);
                    if (myreader == null) return;
                    myreader.Read();
                    int a = myreader.GetInt32(0);
                    myreader.Close();
                    if (a == 0)
                    {
                        MessageBox.Show("Phiếu đã có chi tiết, Không thể xóa!");

                    }
                    else if (a == 1)
                    {
                        MessageBox.Show("Đã xóa thành công.");
                        // GAN LAI BDS CHO 3 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW
                        cmbMaSoDDH.DataSource = bdsPN;
                        cmbMaSoDDH.DisplayMember = "MasoDDH";
                        cmbMaSoDDH.ValueMember = "MasoDDH";

                        cmbMaNV.Enabled = true;
                        cmbMaNV.DataSource = bdsPN;
                        cmbMaNV.DisplayMember = "MANV";
                        cmbMaNV.ValueMember = "MANV";

                        cmbMaKho.Enabled = true;
                        cmbMaKho.DataSource = bdsPN;
                        cmbMaKho.DisplayMember = "MAKHO";
                        cmbMaKho.ValueMember = "MAKHO";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }


            }
            phanQuyen(true, true, false, true, true, true);
            gcPN.Enabled = true;
            groupBox1.Enabled = false;
            btnReload.Enabled = true;
        }
    }
}
