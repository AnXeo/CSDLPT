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
    public partial class formCTPX : Form
    {
        int vitri = 0;
        int luachon = 0, flag = 0;
        String mapx, mavt;
        int soluong;
        float dongia;
        private SqlDataReader myreader;
        String str_Lenh;
        public formCTPX()
        {
            InitializeComponent();
        }

        private void formCTPX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            qLPN.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLPN.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLPN.CTPX);
            // TODO: This line of code loads data into the 'qLPN.V_MAVT' table. You can move, or remove it, as needed.
            this.v_MAVTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_MAVTTableAdapter.Fill(this.qLPN.V_MAVT);

           
            // TODO: This line of code loads data into the 'qLPN.SP_DSPX' table. You can move, or remove it, as needed.
           // this.sP_DSPXTableAdapter.Fill(this.qLPN.SP_DSPX);
           


            groupBox1.Enabled = false;
            cmbChiNhanh.DataSource = vbdspm;

            if (Program.mGroup == "CONGTY")
            {
                this.cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
                this.btnGhi.Enabled = this.btnUndo.Enabled = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnThem.Enabled = this.btnReload.Enabled = false;

                groupBox1.Enabled = false;

            }
            else
            {
                this.cmbChiNhanh.Enabled = false;
                groupBox1.Enabled = false;

                this.btnGhi.Enabled = false;
                this.btnUndo.Enabled = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnThem.Enabled = this.btnReload.Enabled = true;

            }


        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            luachon = 1;
            vitri = bdsCTPX.Position;
            groupBox1.Enabled = true;
            bdsCTPX.AddNew();

            phanQuyen(false, false, true, false, true, false);
            gcCTPX.Enabled = false;

            // GAN LAI BDS CHO CMB DE SHOW NHUNG VALUE CAN THIET
            cmbMAPX.Enabled = true;
            String sql = "exec SP_DSPX";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Columns.Count > 0)
            {
                cmbMAPX.DataSource = dt;
                cmbMAPX.DisplayMember = "MAPX";
                cmbMAPX.ValueMember = "MAPX";
            }
            MessageBox.Show(cmbMAPX.SelectedValue.ToString());
            cmbMAVT.Enabled = true;
            cmbMAVT.DataSource = v_bdsVT;
            cmbMAVT.DisplayMember = "MAVT";
            cmbMAVT.ValueMember = "MAVT";
            MessageBox.Show(cmbMAVT.SelectedValue.ToString());
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Fix loi lay so tu textBox
            cmbMAPX.Focus();
            // Fix loi lay so tu textBox
            if (cmbMAPX.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu xuất không được thiếu!", "", MessageBoxButtons.OK);
                cmbMAPX.Focus();
                return;
            }

            if (cmbMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);

                return;
            }

            if (txtSOLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (txtDONGIA.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }

            if (txtDONGIA.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá ko được thiếu!", "", MessageBoxButtons.OK);

                return;
            }
            if (float.Parse(txtDONGIA.Text.Trim()) <= 0)
            {
                MessageBox.Show("Đơn giá không  phải > 0 !", "", MessageBoxButtons.OK);
                txtDONGIA.Focus();
                return;
            }
            if (luachon == 1)//Thêm chi tiết phiếu nhập
            {
                try
                {
                    mapx = cmbMAPX.SelectedValue.ToString().Trim();
                    mavt = cmbMAVT.SelectedValue.ToString().Trim();
                    soluong = Convert.ToInt32(txtSOLUONG.Text.Trim());
                    dongia = float.Parse(txtDONGIA.Text.Trim());
                    string dongia1 = Convert.ToString(dongia);

                    str_Lenh = "EXEC SP_THEMCTPX '" + mapx + "','" + mavt + "','" + soluong + "','" + dongia1 + "'";

                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    if (myreader == null) return;

                    myreader.Read();
                    int a = myreader.GetInt32(0);
                    myreader.Close();


                    if (a == 0)
                    {
                        MessageBox.Show("Số lượng quá lớn hoặc Mã phiếu xuất mã vật tư đã tồn tại hoặc lỗi mạng, xin mời nhập lại."); // do co 2 khoa chinh // xem trong sp
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

            if (luachon == 2)//Sửa chi tiết phiếu nhập
            {

            }
            this.cTPXTableAdapter.Fill(this.qLPN.CTPX);
            phanQuyen(true, false, true, true, true, true);
            gcCTPX.Enabled = true;
            groupBox1.Enabled = false;
            //Sau khi ghi, gan lai Bds
            cmbMAPX.DataSource = this.bdsCTPX;
            cmbMAPX.DisplayMember = "MAPX";
            cmbMAPX.ValueMember = "MAPX";
            cmbMAVT.DataSource = this.bdsCTPX;
            cmbMAVT.DisplayMember = "MAVT";
            cmbMAVT.ValueMember = "MAVT";
            luachon = 0;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Hàm xóa bị lỗi object .. not set gì đó không vào được cả dòng MessageBox.Show(mapn);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                try
                {
                    mapx = cmbMAPX.SelectedValue.ToString();
                    mavt = cmbMAVT.SelectedValue.ToString();

                    str_Lenh = "SP_XoaCTPX '" + mapx + "','" + mavt + "'";   //  từ day xuong duoi la chay sp lấy ra return, biêt bai nay r khỏi cần dùng select vì dùng select phát triển rất hạn chế

                    myreader = Program.ExecSqlDataReader(str_Lenh);
                    this.cTPXTableAdapter.Fill(this.qLPN.CTPX);
                    if (myreader == null) return;
                    myreader.Read();
                    myreader.Close();
                    MessageBox.Show("Đã xóa thành công.");
                    // GAN LAI BDS CHO 2 CMB DE HIEN THI VALUE KHI CHON TRONG GRIDVIEW
                    cmbMAPX.DataSource = bdsCTPX;
                    cmbMAPX.DisplayMember = "MaPX";
                    cmbMAPX.ValueMember = "MaPX";

                    cmbMAVT.Enabled = true;
                    cmbMAVT.DataSource = bdsCTPX;
                    cmbMAVT.DisplayMember = "MAVT";
                    cmbMAVT.ValueMember = "MAVT";

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPX.CancelEdit();
            this.cTPXTableAdapter.Fill(this.qLPN.CTPX);
            if (btnThem.Enabled == false) bdsCTPX.Position = vitri;
            gcCTPX.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnSua.Enabled = btnUndo.Enabled = false;

            // gan lai gia  tri cho no đồng bộ tt voi bds
            cmbMAPX.Enabled = true;
            cmbMAPX.DataSource = bdsCTPX;
            cmbMAPX.DisplayMember = "MAPX";
            cmbMAPX.ValueMember = "MAPX";

            cmbMAVT.Enabled = true;
            cmbMAVT.DataSource = bdsCTPX;
            cmbMAVT.DisplayMember = "MAVT";
            cmbMAVT.ValueMember = "MAVT";
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
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.qLPN.CTPX);
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

        private void txtSOLUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
