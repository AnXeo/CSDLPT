using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVATTU
{
    public partial class frmNhanVien : Form
    {

        int vitri = 0;
       
        int MaNVC;
        string macn = "";
        public static String HoC;
        public static String TenC;
        public static String DiaChiC;
        public static DateTime NgaySinhC;
        public static float LuongC;


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public int lc = 0;
        //  lc=1:Them; lc=2: Sua ;
        public frmNhanVien()
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dATHANGTableAdapter.Fill(this.dS.DATHANG);
            // TODO: This line of code loads data into the 'dS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUNHAPTableAdapter.Fill(this.dS.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dS.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.pHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUXUATTableAdapter.Fill(this.dS.PHIEUXUAT);
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
            // MessageBox.Show(Program.connstr);
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();//xuất 1 field tại dòng 0 của BindingSource bdsNVV:
            /*cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";//DisplayMember là tên của cột của DataSource mà combobox đang sở hửu, nó là cột mà combobox muốn thể hiện ra.
            cmbChinhanh.ValueMember = "TENSERVER";//ValueMember là tên của cột trong DataSource, nó là giá trị tương ứng với DisplayMember mà người dùng sẽ chọn.*/
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            //string hoten = cmbChinhanh.Text;//Tương ứng với DisplayMember
            //int ma = int.Parse(cmb.SelectedValue.ToString());//Tương ứng với ValueMember
            barButtonItem1.Enabled = btnDSNhanvien.Enabled=false;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
                btnRefresh.Enabled = btnPhuchoi.Enabled = btnQuayLai.Enabled = false;
                btnExit.Enabled = true;
            }
            else
            {

                cmbChinhanh.Enabled = false;
                btnQuayLai.Enabled = btnPhuchoi.Enabled = btnGhi.Enabled = false;

            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMANV.Focus();
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnExit.Enabled = btnQuayLai.Enabled = true;
            gcNhanVien.Enabled = false;
            lc = 1;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (lc == 1)
            {
                dS.EnforceConstraints = false;
                if (txtMANV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                SqlDataReader myReader;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KiemTraNhanVienTonTai";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MANV", SqlDbType.Int).Value = txtMANV.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                if (Ret == "1")
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
                if (txtHO.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtHO.Focus();
                    return;

                }
                if (txtTEN.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtTEN.Focus();
                    return;
                }
                if (txtLUONG.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập lương nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtLUONG.Focus();

                    return;
                }
                else
                {
                    float luong = float.Parse(txtLUONG.Text);
                    if (luong < 4000000)
                    {
                        MessageBox.Show("Bạn phải nhập lương >= 4000000 ", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtLUONG.Focus();
                        return;
                    }
                }
                if (txtDIACHI.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ nhân viên  !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtDIACHI.Focus();
                    return;
                }
                if (dtpNGAYSINH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    dtpNGAYSINH.Focus();
                    return;
                }

                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.dS.NHANVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thêm Nhân Viên Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                gcNhanVien.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnQuayLai.Enabled = btnPhuchoi.Enabled = false;
                btnExit.Enabled = true;

                groupBox1.Enabled = false;

                int type = 1; // Them
                String lenh = "exec SP_UndoThemNhanVien '" + txtMANV.Text + "'";
                Undo ud = new Undo(type, lenh);
                st.Push(ud);
                return;
            }
            else
                if (lc == 2)// sua
            {
                gcNhanVien.Enabled =groupBox1.Enabled=btnRefresh.Enabled= true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled  = false; ;
                btnQuayLai.Enabled = false;
                btnPhuchoi.Enabled = btnExit.Enabled = true;

                groupBox1.Enabled = true;
                if (txtHO.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                   
                    txtHO.Focus();
                    return;

                }
                if (txtTEN.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtTEN.Focus();                   
                    return;
                }
                if (txtLUONG.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập lương nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtLUONG.Focus();
                   
                    return;
                }
                else
                {
                    float luong = float.Parse(txtLUONG.Text);
                    if (luong < 4000000)
                    {
                        MessageBox.Show("Bạn phải nhập lương >= 4000000 ", "THÔNG BÁO", MessageBoxButtons.OK);                     
                        txtLUONG.Focus();
                        return;
                    }
                }
                if (txtDIACHI.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ nhân viên  !", "THÔNG BÁO", MessageBoxButtons.OK);
                    
                    txtDIACHI.Focus();
                    return;
                }
                if (dtpNGAYSINH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ngày sinh nhân viên !", "THÔNG BÁO", MessageBoxButtons.OK);
                   
                    dtpNGAYSINH.Focus();
                    return;
                }

                btnQuayLai.Enabled = true;
                //chọn một hàng cụ thể trong gridView ~~ GridView.FocusedRowHandle
                //GetRowCellValue: lấy gtri hàng đc tập trung
                int MaNVC = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString());
                //Chuyển đổi một giá trị được chỉ định sang một số nguyên
                int type = 2; // xoa
                String lenh = "exec SP_UndoSuaNhanVien '" + HoC + "','" + TenC + "','" + DiaChiC + "','" + NgaySinhC + "','" + LuongC + "','" + MaNVC + "'";
                Undo ud = new Undo(type, lenh);
                st.Push(ud);
                this.Validate();// xác nhận điều khiển btn(dk: enable_ true)
                this.bdsNV.EndEdit();//Áp dụng các thay đổi đang chờ giải quyết cho nguồn dữ liệu bên dưới
                this.tableAdapterManager.UpdateAll(this.dS);//Lưu tất cả dữ liệu từ tất cả các bảng dữ liệu
                MessageBox.Show("Chỉnh Sửa Nhân Viên Thành công", "THÔNG BÁO", MessageBoxButtons.OK);

                return;

            }
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
                if (cmbChinhanh.SelectedValue != null)
                    Program.servername = cmbChinhanh.SelectedValue.ToString();
                //MessageBox.Show(Program.servername);
            }
            catch (Exception ex)
            {

            }

            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
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
                this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                try
                {
                    macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }
                catch (Exception ex)
                { }

            }
           


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            HoC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            TenC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
            DiaChiC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            LuongC = Convert.ToSingle(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LUONG").ToString());
            NgaySinhC = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH"));
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnExit.Enabled = btnQuayLai.Enabled = true;
            gcNhanVien.Enabled = false;
            txtMANV.Enabled = false;
            lc = 2;



        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            MaNVC = Convert.ToInt32(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());

            HoC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            TenC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
            DiaChiC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            LuongC = Convert.ToSingle(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LUONG").ToString());
            NgaySinhC = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString());


            //groupBox1.Enabled = true;
            if (bdsDATHANG.Count > 0 || bdsPHIEUNHAP.Count > 0 || bdsPHIEUXUAT.Count > 0)
                MessageBox.Show("Nhan vien da tao phieu nen khong the xoa");
            else
            {
                int delMaNV = 0;
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        MaNVC = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                        bdsNV.RemoveCurrent();
                        this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nHANVIENTableAdapter.Update(this.dS.NHANVIEN);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                        bdsNV.Position = bdsNV.Find("MANV", MaNVC);
                    }
                int type = 3; // xoa
                String lenh = "exec dbo.SP_UndoDeleteNhanVien '" + MaNVC + "','" + HoC + "','" + TenC + "'" + DiaChiC + "','" + NgaySinhC + "'" + LuongC + "','" + macn + "'";
                Undo ob = new Undo(type, lenh);
                st.Push(ob);
                btnPhuchoi.Enabled = false;
            }
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Undo ud = (Undo)st.Pop();

            if (ud.getType() == 1)
            {
                //MessageBox.Show("Khôi phục sau khi thêm " + ud.getLenh());
                //Program.ExecSqlDataReader(ud.getLenh());
                //this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                //return;
                bdsNV.CancelEdit();// loại bỏ các sửa đổi đối với dữ liệu kể từ lần thao tác lưu hoặc nạp cuối cùng(dk: chưa endedit tiếp)
                bdsNV.Position = vitri;
                gcNhanVien.Enabled = true;
                groupBox1.Enabled = false;
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                return;

            }
            if (ud.getType() == 2)
            {
                MessageBox.Show("Khôi phục sau khi sửa " + ud.getLenh());
                Program.ExecSqlDataReader(ud.getLenh());
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhuchoi.Enabled = btnQuayLai.Enabled = false;
                return;
            }
            if (ud.getType() == 3)
            {
                MessageBox.Show("Khôi phục sau khi xóa " + ud.getLenh());
                Program.ExecSqlDataReader(ud.getLenh());
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                return;
            }

            if (ud.getType() == 4)
            {
                MessageBox.Show("Khôi phục sau khi chuyển " + ud.getLenh());
                Program.ExecSqlDataReader(ud.getLenh());
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                return;
            }
            btnRefresh.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn lưu tất cả các thay đổi trước khi thoát!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }

        }
        private void btnQuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            bdsNV.Position = vitri;
            gcNhanVien.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
            btnRefresh.PerformClick();
            bdsNV.Position = vitri;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }


}
