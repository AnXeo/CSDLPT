using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Data.SqlClient;

namespace QLVATTU
{
    public partial class frmVatTu : Form
    {
        public static String maVTC = "";
        public static String tenVTC = "";
        public int sltC;
        public String dvtC = "";


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

        int vitri = 0;
        int lc;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
                                                            
            // TODO: This line of code loads data into the 'dS.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vATTUTableAdapter.Fill(this.dS.VATTU);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMAVT.Focus();
            vitri = bdsVT.Position;
            groupBox1.Enabled = true;
            bdsVT.AddNew();          
            gcVatTu.Enabled = false;
            lc = 1;// Thêm            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRelo.Enabled = btnUndo.Enabled = false;
            btnLuu.Enabled = btnThoat.Enabled = btnQuayLai.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUndo.Enabled = false;
            if (bdsCTDDH.Count > 0 || bdsCTPN.Count > 0 || bdsCTPX.Count > 0)
                MessageBox.Show("Vật tư  đã tạo phiếu nên không thể xóa ", "Lỗi xóa vật tư", MessageBoxButtons.OK);
            else
            {
                string delMaVT = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        delMaVT = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();
                        bdsVT.RemoveCurrent();
                        this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vATTUTableAdapter.Update(this.dS.VATTU);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Xóa vật tư không thành công :3 {exception.Message}", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.vATTUTableAdapter.Fill(this.dS.VATTU);
                        bdsVT.Position = bdsVT.Find("MAVT", delMaVT);
                    }
            }
            if (bdsVT.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            maVTC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAVT").ToString();
            tenVTC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENVT").ToString();
            dvtC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DVT").ToString();
            sltC = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOLUONGTON").ToString());
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRelo.Enabled = btnUndo.Enabled = false;
            btnQuayLai.Enabled = btnLuu.Enabled = true;
            btnThoat.Enabled = false;
            txtMAVT.Enabled = false;           
            groupBox1.Enabled = true;
            gcVatTu.Enabled = false;
           
            lc = 2;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc == 1)//thêm
            {
                try
                {
                    if (txtMAVT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã vật tư !", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.SP_KiemTraVatTuTonTai";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@MAVT", SqlDbType.NChar).Value = txtMAVT.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();

                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                        
                        return;
                    }                  
                    if (txtDVT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đơn vị tính !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtDVT.Focus();
                        return;
                    }
                    if (txtSLT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập số lượng tồn !", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtSLT.Focus();
                        return;
                    }
                    else
                    {
                        int slt = Int32.Parse(txtSLT.Text);
                        if(slt<0)
                        {
                            MessageBox.Show("Số lượng tồn phải >=0", "THÔNG BÁO", MessageBoxButtons.OK);
                            txtSLT.Focus();
                            return;
                        }
                    }

                    this.Validate();
                    this.bdsVT.EndEdit();
                    this.vATTUTableAdapter.Update(this.dS.VATTU);

                    MessageBox.Show("Thêm Vật Tư thành công", "THÔNG BÁO", MessageBoxButtons.OK);                                    

                    return;
                }
                catch (Exception r)
                {
                    return;
                }
            
                MessageBox.Show("Thêm Vật Tư Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                gcVatTu.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRelo.Enabled = btnThoat.Enabled =btnQuayLai.Enabled= true;
                btnLuu.Enabled = false;
                btnUndo.Enabled = false;
                groupBox1.Enabled = false;               
                return;
            }

            else if (lc == 2)//sửa
            {
                groupBox1.Enabled =btnUndo.Enabled= true;
                //chọn một hàng cụ thể trong gridView ~~ GridView.FocusedRowHandle
                //GetRowCellValue: lấy gtri hàng đc tập trung
                //Char maVTC =Convert.ToChar(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAVT").ToString());
                //Chuyển đổi một giá trị được chỉ định sang một số nguyên
                if (txtDVT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đơn vị tính !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtDVT.Focus();
                    return;
                }
                if (txtSLT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng tồn !", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtSLT.Focus();
                    return;
                }
                else
                {
                    int slt = Int32.Parse(txtSLT.Text);
                    if (slt < 0)
                    {
                        MessageBox.Show("Số lượng tồn phải >=0", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtSLT.Focus();
                        return;
                    }
                }
                int type = 2; // sửa
                String lenh = "exec SP_UndoSuaVatTu '" + tenVTC + "','" + dvtC + "','" + sltC + "','" + maVTC + "'";
                Undo ud = new Undo(type, lenh);
                st.Push(ud);
                this.Validate();// xác nhận điều khiển btn(dk: enable_ true)
                this.bdsVT.EndEdit();//Áp dụng các thay đổi đang chờ giải quyết cho nguồn dữ liệu bên dưới
                this.tableAdapterManager.UpdateAll(this.dS);//Lưu tất cả dữ liệu từ tất cả các bảng dữ liệu
                MessageBox.Show("Chỉnh Sửa Vật Tư Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRelo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vATTUTableAdapter.Fill(this.dS.VATTU);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn lưu tất cả các thay đổi trước khi thoát!", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }

        }

        private void btnQuayLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVT.CancelEdit();
            bdsVT.Position = vitri;
            gcVatTu.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRelo.Enabled = true;
            btnLuu.Enabled = btnUndo.Enabled = false;
            btnRelo.PerformClick();
            bdsVT.Position = vitri;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Undo ud = (Undo)st.Pop();
            if (ud.getType() == 2)
            {
                MessageBox.Show("Khôi phục sau khi sửa " + ud.getLenh());
                Program.ExecSqlDataReader(ud.getLenh());
                this.vATTUTableAdapter.Fill(this.dS.VATTU);
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnQuayLai.Enabled=btnRelo.Enabled= true;
                btnLuu.Enabled = btnUndo.Enabled  = false;
                return;
            }
        }
    }
}
