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
    public partial class frmPhieuXuat : Form
    {
        int vitri = 0;
        int flag = 0;
        String maPX, ngay, tenKH, maNV, maKho;

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaPX.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu xuất không được thiếu!", "", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return;
            }
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên KH không được thiếu!", "", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return;
            }

            if (cmbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã NV ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (cmbMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã Kho ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (flag == 1)
            {
                try
                {
                    maPX = txtMaPX.Text.Trim();
                    ngay = txtNgay.Text.Trim();
                    tenKH = txtHoTenKH.Text.Trim();
                    maNV = cmbMaNV.SelectedValue.ToString();
                    maKho = cmbMaKho.SelectedValue.ToString();

                    str_Lenh = "EXEC SP_THEMPX '" + maPX + "','" + tenKH + "','" + maNV + "','" + maKho + "'";
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

            this.pHIEUXUATTableAdapter.Fill(this.qLPN.PHIEUXUAT);
            phanQuyen(true, false, false, true, false, false);
            gcPX.Enabled = true;
            groupBox1.Enabled = false;

            // GAN LAI BDS CHO 3 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW


            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = bdsPX;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = bdsPX;
            cmbMaKho.DisplayMember = "MAKHO";
            cmbMaKho.ValueMember = "MAKHO";
            flag = 0;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPX.CancelEdit();
            this.pHIEUXUATTableAdapter.Fill(this.qLPN.PHIEUXUAT);
            if (btnThem.Enabled == false) bdsPX.Position = vitri;
            gcPX.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnSua.Enabled = btnUndo.Enabled = false;

            // gan lai gia  tri cho no đồng bộ tt voi bds
            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = bdsPX;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = bdsPX;
            cmbMaKho.DisplayMember = "MAKHO";
            cmbMaKho.ValueMember = "MAKHO";
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.pHIEUXUATTableAdapter.Fill(this.qLPN.PHIEUXUAT);
                // GAN LAI BDS CHO  CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW

                cmbMaNV.Enabled = true;
                cmbMaNV.DataSource = bdsPX;
                cmbMaNV.DisplayMember = "MANV";
                cmbMaNV.ValueMember = "MANV";

                cmbMaKho.Enabled = true;
                cmbMaKho.DataSource = bdsPX;
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
                    maPX = txtMaPX.Text.Trim();
                    str_Lenh = "EXEC SP_XOAPX '" + maPX + "'";
                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    this.pHIEUXUATTableAdapter.Fill(this.qLPN.PHIEUXUAT);
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
                        // GAN LAI BDS CHO CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW


                        cmbMaNV.Enabled = true;
                        cmbMaNV.DataSource = bdsPX;
                        cmbMaNV.DisplayMember = "MANV";
                        cmbMaNV.ValueMember = "MANV";

                        cmbMaKho.Enabled = true;
                        cmbMaKho.DataSource = bdsPX;
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
            phanQuyen(true, false, false, true, false, false);
            gcPX.Enabled = true;
            groupBox1.Enabled = false;
            //btnReload.Enabled = true;
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
            vitri = bdsPX.Position;
            bdsPX.AddNew();
            groupBox1.Enabled = true;
            txtMaPX.Text = "";
            txtHoTenKH.Text = "";
            phanQuyen(false, false, true, false, true, false);
            gcPX.Enabled = false;
            flag = 1;
            // GAN LAI BDS CHO CMB DE SHOW NHUNG VALUE CAN THIET

            cmbMaNV.Enabled = true;
            cmbMaNV.DataSource = VbdsMaNV;
            cmbMaNV.DisplayMember = "MANV";
            cmbMaNV.ValueMember = "MANV";

            cmbMaKho.Enabled = true;
            cmbMaKho.DataSource = VbdsKho;
            cmbMaKho.DisplayMember = "TENKHO";
            cmbMaKho.ValueMember = "MAKHO";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private SqlDataReader myreader;
        String str_Lenh;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            qLPN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLPN.V_MANV' table. You can move, or remove it, as needed.
            this.v_MANVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MANVTableAdapter.Fill(this.qLPN.V_MANV);
            // TODO: This line of code loads data into the 'qLPN.V_KHO' table. You can move, or remove it, as needed.
            this.v_KHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_KHOTableAdapter.Fill(this.qLPN.V_KHO);
          
            this.pHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr; // lay ConnectionString
            this.pHIEUXUATTableAdapter.Fill(this.qLPN.PHIEUXUAT); // fill len gv
            groupBox1.Enabled = false;
            cmbChiNhanh.DataSource = vbdspm;
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

    }
}
