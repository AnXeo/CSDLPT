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
    public partial class frmCTPN : Form
    {
        int vitri = 0;
        int luachon = 0, flag = 0;
        String mapn, mavt;
        int soluong;
        float dongia;
        private SqlDataReader myreader;
        String str_Lenh;
        public frmCTPN()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            luachon = 1;
            vitri = bdsCTPN.Position;
            groupBox1.Enabled = true;
            bdsCTPN.AddNew();

            phanQuyen(false, false, true, false, true, false);
            gcCTPN.Enabled = false;

            // GAN LAI BDS CHO CMB DE SHOW NHUNG VALUE CAN THIET
            cmbMaPN.Enabled = true;
            String sql1 = "exec SP_LayMaPN";
            DataTable dt1 = Program.ExecSqlDataTable(sql1);
            if (dt1.Columns.Count > 0)
            {
                cmbMaPN.DataSource = dt1;
                cmbMaPN.DisplayMember = "MAPN";
                cmbMaPN.ValueMember = "MAPN";
            }

            cmbMaVT.Enabled = true;
            String sql = "exec SP_TIMVATTUCTPN N'" + cmbMaPN.SelectedValue.ToString() + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Columns.Count > 0)
            {
                cmbMaVT.DataSource = dt;
                cmbMaVT.DisplayMember = "MAVT";
                cmbMaVT.ValueMember = "MAVT";
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Hàm xóa bị lỗi object .. not set gì đó không vào được cả dòng MessageBox.Show(mapn);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                try
                {
                    mapn = cmbMaPN.SelectedValue.ToString();
                    mavt = cmbMaVT.SelectedValue.ToString();
                    MessageBox.Show(mapn);
                    MessageBox.Show(mavt);
                    str_Lenh = "SP_XoaCTPN '" + mapn + "','" + mavt + "'";   //  từ day xuong duoi la chay sp lấy ra return, biêt bai nay r khỏi cần dùng select vì dùng select phát triển rất hạn chế
                    MessageBox.Show(str_Lenh);
                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    this.cTPNTableAdapter.Fill(this.qLPN.CTPN);
                    if (myreader == null) return;
                    myreader.Read();
                    myreader.Close();
                    MessageBox.Show("Đã xóa thành công.");
                    // GAN LAI BDS CHO 3 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW
                    cmbMaPN.DataSource = bdsCTPN;
                    cmbMaPN.DisplayMember = "MaPN";
                    cmbMaPN.ValueMember = "MaPN";

                    cmbMaVT.Enabled = true;
                    cmbMaVT.DataSource = bdsCTPN;
                    cmbMaVT.DisplayMember = "MAVT";
                    cmbMaVT.ValueMember = "MAVT";

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            phanQuyen(true, false, false, true, false, false);
            gcCTPN.Enabled = true;
            groupBox1.Enabled = false;
            btnReload.Enabled = true;
            //Gán lại bds
            cmbMaPN.DataSource = this.bdsCTPN;
            cmbMaPN.DisplayMember = "MAPN";
            cmbMaPN.ValueMember = "MAPN";
            cmbMaVT.DataSource = this.bdsCTPN;
            cmbMaVT.DisplayMember = "MAVT";
            cmbMaVT.ValueMember = "MAVT";
        }

        private void cmbMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chỗ này không hiểu lắm
            if (luachon == 1 || luachon == 2)
            {
                String sql = "exec SP_TIMVATTUCTPN N'" + cmbMaPN.SelectedValue + "'";
                DataTable dt = Program.ExecSqlDataTable(sql);
                if (dt.Columns.Count > 0)
                {
                    cmbMaVT.DataSource = dt;
                    cmbMaVT.DisplayMember = "MAVT";
                    cmbMaVT.ValueMember = "MAVT";
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            luachon = 2;
            vitri = bdsCTPN.Position;
            groupBox1.Enabled = true;
            phanQuyen(false, false, true, false, true, false);
            gcCTPN.Enabled = false;
            cmbMaVT.Enabled = false;
            cmbMaPN.Enabled = false;

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPN.CancelEdit();
            this.cTPNTableAdapter.Fill(this.qLPN.CTPN);
            if (btnThem.Enabled == false) bdsCTPN.Position = vitri;
            gcCTPN.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnSua.Enabled = btnUndo.Enabled = false;

            // gan lai Bds
            cmbMaPN.DataSource = this.bdsCTPN;
            cmbMaPN.DisplayMember = "MAPN";
            cmbMaPN.ValueMember = "MAPN";
            cmbMaVT.DataSource = this.bdsCTPN;
            cmbMaVT.DisplayMember = "MAVT";
            cmbMaVT.ValueMember = "MAVT";
        }

        private void frmCTPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            qLPN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLVATTUDataSet3.V_MAPN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLPN.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLPN.CTPN);

            // TODO: This line of code loads data into the 'qLVATTUDataSet3.V_MAPN' table. You can move, or remove it, as needed.
            this.v_MAPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MAPNTableAdapter.Fill(this.qLVATTUDataSet3.V_MAPN);



            // TODO: This line of code loads data into the 'qLPN.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLPN.CTPN);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLPN.CTPN);
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

                btnGhi.Enabled = false;
                btnUndo.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnReload.Enabled = true;

            }

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
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.qLPN.CTPN);
            }
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

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Fix loi lay so tu textBox
            cmbMaPN.Focus();
            // Fix loi lay so tu textBox
            if (cmbMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                cmbMaPN.Focus();
                return;
            }

            if (cmbMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);

                return;
            }

            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            else
            {
                try
                {
                    soluong = int.Parse(txtSoLuong.Text.Trim());
                    MessageBox.Show(soluong + "_");
                    mapn = cmbMaPN.SelectedValue.ToString().Trim();
                    mavt = cmbMaVT.Text.ToString().Trim(); // hay dung .text dung dung selected value -- debug cho nay mất ca nua tieng :((
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "SP_KTraSoLuongVTCTPN";   //  từ day xuong duoi la chay sp lấy ra return, biêt bai nay r khỏi cần dùng select vì dùng select phát triển rất hạn chế
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("MAVT", SqlDbType.Text).Value = mavt;
                    Program.sqlcmd.Parameters.Add("SOLUONGNHAP", SqlDbType.Int).Value = soluong;
                    Program.sqlcmd.Parameters.Add("MAPN", SqlDbType.Text).Value = mapn;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret.Equals("1"))
                    {
                        MessageBox.Show("Bạm hãy chọn số lượng bé hơn");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đủ số lượng");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("ex" + er);
                }


            }

            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (float.Parse(txtDonGia.Text.Trim()) <= 0)
            {
                MessageBox.Show("Đơn giá không  phải > 0 !", "", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return;
            }
            if (luachon == 1)//Thêm chi tiết phiếu nhập
            {
                try
                {
                    mapn = cmbMaPN.SelectedValue.ToString().Trim();
                    mavt = cmbMaVT.SelectedValue.ToString().Trim();
                    soluong = Convert.ToInt32(txtSoLuong.Text.Trim());
                    dongia = float.Parse(txtDonGia.Text.Trim());
                    string dongia1 = Convert.ToString(dongia);

                    str_Lenh = "EXEC SP_THEMCTPN '" + mapn + "','" + mavt + "','" + soluong + "','" + dongia1 + "'";
                    MessageBox.Show(str_Lenh);
                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    if (myreader == null) return;

                    myreader.Read();
                    int a = myreader.GetInt32(0);
                    myreader.Close();
                    MessageBox.Show(a.ToString());

                    if (a == 0)
                    {
                        MessageBox.Show("Trùng MAPN, MaVT"); // do co 2 khoa chinh // xem trong sp
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu OK");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm\n " + ex.Message, "", MessageBoxButtons.OK);
                }

            }
            if (luachon == 2)
            {
                // Sua khong phu hop thuc te voi du lieu lon, thoi gian lau.
                //Day la em lam theo huong du lieu nho, thoi gian moi nhap xong. Nhan vien nham lan nhap xuat. 

                try
                {
                    mapn = cmbMaPN.SelectedValue.ToString().Trim();
                    mavt = cmbMaVT.SelectedValue.ToString().Trim();
                    soluong = Convert.ToInt32(txtSoLuong.Text.Trim());
                    dongia = float.Parse(txtDonGia.Text.Trim());
                    string dongia1 = Convert.ToString(dongia);

                    str_Lenh = "EXEC SP_SuaCTPN '" + mapn + "','" + mavt + "','" + soluong + "','" + dongia1 + "'";
                    MessageBox.Show(str_Lenh);
                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    if (myreader == null) return;
                    //myreader.Read();
                    myreader.Close();
                    MessageBox.Show("Sửa thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa\n " + ex.Message, "", MessageBoxButtons.OK);
                }

            }

            this.cTPNTableAdapter.Fill(this.qLPN.CTPN);
            phanQuyen(true, true, false, true, true, true);
            gcCTPN.Enabled = true;
            groupBox1.Enabled = false;
            //Sau khi ghi, gan lai Bds
            cmbMaPN.DataSource = this.bdsCTPN;
            cmbMaPN.DisplayMember = "MAPN";
            cmbMaPN.ValueMember = "MAPN";
            cmbMaVT.DataSource = this.bdsCTPN;
            cmbMaVT.DisplayMember = "MAVT";
            cmbMaVT.ValueMember = "MAVT";
            luachon = 0;
        }



        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}



