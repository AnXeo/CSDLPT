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
    public partial class frmKho : Form
    {
        int vitri = 0;
        public int lc;
        string macn = "";
        public String TenKhoC;
        public String MaKhoC;
        public String DiaChiC;
       
        
        public frmKho()
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

        private void kHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dATHANGTableAdapter.Fill(this.dS.DATHANG);
            // TODO: This line of code loads data into the 'dS.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUNHAPTableAdapter.Fill(this.dS.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dS.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.pHIEUXUATTableAdapter.Connection.ConnectionString = Program.connstr;
            this.pHIEUXUATTableAdapter.Fill(this.dS.PHIEUXUAT);

            // TODO: This line of code loads data into the 'dS.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOTableAdapter.Fill(this.dS.KHO);
           
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
           
           
           
            macn = ((DataRowView)bdsKHO[0])["MACN"].ToString();//xuất 1 field tại dòng 0 của BindingSource bdsKHO:
            //cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            //cmbChiNhanh.DisplayMember = "TENCN";//DisplayMember là tên của cột của DataSource mà combobox đang sở hửu, nó là cột mà combobox muốn thể hiện ra.
            //cmbChiNhanh.ValueMember = "TENSERVER";//ValueMember là tên của cột trong DataSource, nó là giá trị tương ứng với DisplayMember mà người dùng sẽ chọn.
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            //string hoten = cmbChinhanh.Text;//Tương ứng với DisplayMember
            //int ma = int.Parse(cmb.SelectedValue.ToString());//Tương ứng với ValueMember
            btnQuayLai.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = btnThoat.Enabled = false;
                btnReload.Enabled = btnUndo.Enabled = btnQuayLai.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = false;
                cmbChiNhanh.Enabled = false;
                btnQuayLai.Enabled = btnUndo.Enabled = btnLuu.Enabled = false;

            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMAKHO.Focus();
            groupBox1.Enabled = true;
            bdsKHO.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnUndo.Enabled= false;
            btnLuu.Enabled =  btnThoat.Enabled = btnQuayLai.Enabled = true;
            gcKho.Enabled = false;               
            lc = 1;
            txtMACN.Enabled = false;
        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc == 1)//thêm
            {
                dS.EnforceConstraints = false;
                if (txtMAKHO.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã KHO !", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
                SqlDataReader myReader;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KiemTraKhoTonTai";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAKHO", SqlDbType.Int).Value = txtMAKHO.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                try
                {
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã  Kho đã tồn tại !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                        txtMAKHO.Focus();
                        return;
                    }
                    if (txtMAKHO.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã kho !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtMAKHO.Focus();
                        return;

                    }
                    if (txtTEN.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên kho !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtTEN.Focus();
                        return;
                    }
                    if (txtDIACHI.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ: !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtDIACHI.Focus();

                        return;
                    }
                }catch(Exception ex)
                { }
               

                try
                {
                    bdsKHO.EndEdit();
                    bdsKHO.ResetCurrentItem();
                    this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOTableAdapter.Update(this.dS.KHO);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thêm Kho Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                gcKho.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnLuu.Enabled = false;
                btnUndo.Enabled = true;
                groupBox1.Enabled = false;

                int type = 1; // Them
                String lenh = "exec SP_UndoThemKho '" + txtMAKHO.Text + "'";
                Undo ud = new Undo(type, lenh);
                st.Push(ud);
                return;
            }
            else
                if (lc == 2)// sua
                {
               
                    MaKhoC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKHO").ToString();
                    btnUndo.Enabled = btnReload.Enabled = btnThem.Enabled =btnXoa.Enabled=btnSua.Enabled= true;
                    gcKho.Enabled = true;
                    groupBox1.Enabled = btnLuu.Enabled = btnQuayLai.Enabled=false;
                    int type = 2; // xoa
                    String lenh = "exec SP_UndoSuaKho '" + TenKhoC + "','" + DiaChiC + "','"+ MaKhoC + "'";
                    Undo ud = new Undo(type, lenh);
                    st.Push(ud);
                    this.Validate();// xác nhận điều khiển btn(dk: enable_ true)
                    this.bdsKHO.EndEdit();//Áp dụng các thay đổi đang chờ giải quyết cho nguồn dữ liệu bên dưới
                    this.tableAdapterManager.UpdateAll(this.dS);//Lưu tất cả dữ liệu từ tất cả các bảng dữ liệu
                    MessageBox.Show("Chỉnh Sửa Kho Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKHO.Position;
            TenKhoC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENKHO").ToString();           
            DiaChiC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled  = btnUndo.Enabled = false;
            btnQuayLai.Enabled =  btnLuu.Enabled= true;
            gcKho.Enabled = btnThoat.Enabled = false;
            txtMAKHO.Enabled = false;
            txtMACN.Enabled = false;
            groupBox1.Enabled = true;
            lc = 2;// SỬa
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOTableAdapter.Fill(this.dS.KHO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
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
                this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOTableAdapter.Fill(this.dS.KHO);
                this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                //macn = ((DataRowView)bdsKHO[0])["MACN"].ToString();
            }
        }

        private void btnPHIEUNHAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDATHANG.Count > 0 || bdsPHIEUNHAP.Count > 0 || bdsPHIEUXUAT.Count > 0)
                MessageBox.Show("KHO da tao phieu nen khong the xoa");
            else
            {
                int delMaKHO = 0;
                if (MessageBox.Show("Bạn có thật sự muốn xóa KHO này ? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaKHO = int.Parse(((DataRowView)bdsKHO[bdsKHO.Position])["MAKHO"].ToString());
                        bdsKHO.RemoveCurrent();
                        this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOTableAdapter.Update(this.dS.KHO);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.kHOTableAdapter.Fill(this.dS.KHO);
                        bdsKHO.Position = bdsKHO.Find("MAKHO", delMaKHO);
                    }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn lưu tất cả các thay đổi trước khi thoát!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }

        }
    

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Undo ud = (Undo)st.Pop();
            if (ud.getType() == 2)
            {
                MessageBox.Show("Khôi phục sau khi sửa " + ud.getLenh());
                Program.ExecSqlDataReader(ud.getLenh());
                this.kHOTableAdapter.Fill(this.dS.KHO);
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                btnLuu.Enabled = btnUndo.Enabled = btnQuayLai.Enabled = false;
                return;
            }
        }

        private void btnQuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKHO.CancelEdit();
            bdsKHO.Position = vitri;
            gcKho.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnLuu.Enabled = btnUndo.Enabled = false;
            btnReload.PerformClick();
            bdsKHO.Position = vitri;
        }
    }
}
