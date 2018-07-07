using System;
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
    public partial class frmDangNhap : Form
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmDangNhap()
        {
            InitializeComponent();
            
          
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_PhanManh.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PhanManh.V_DS_PHANMANH);
            cmbTenCN.SelectedIndex = 1;
            cmbTenCN.SelectedIndex = 0;// để chọn ít nhất 1 lần chi nhánh
           // txtUser.SelectedText = "Khoa";
            //txtPassword.SelectedText = "123450";
        }

        private void cmbTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenCN.SelectedValue != null)
            Program.servername = cmbTenCN.SelectedValue.ToString();
            if (Program.tenChiNhanh == "Chi Nhánh Hồ Chí Minh")
            {
                Program.maCN = "CN1";
            }
            else
            {
                if (Program.tenChiNhanh == "Chi Nhánh Hà Nội")
                {
                    Program.maCN = "CN2";
                }
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Bao loi dang nhap", MessageBoxButtons.OK);
                txtPassword.Focus();
                return ;
            }
            Program.mlogin = txtUser.Text;
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cmbTenCN.SelectedIndex; // xd chi nhanh
            Program.tenChiNhanh = cmbTenCN.Text;
            


           // Program.mChinhanh = cmbTenCN.SelectedIndex;
            Program.bds_dspm = this.bdsDSPM;
            Program.mloginDN = Program.mlogin; // giu lai tai khoan dang nhap
            Program.passwordDN = Program.password; 

            // MessageBox.Show("Dang nhap loi", "", MessageBoxButtons.OK);

            SqlDataReader myReader;

            String strLenh = "exec SP_DangNhap '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();// doc 1 dong true:doc thanh cong;false: tra ve false-->while(Reader.Read==true){}


            Program.username = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            Program.frmChinh.HienThiMenu();
           // MessageBox.Show($"{Program.mHoten}{Program.mGroup}{Program.username}");
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã nhân viên : " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên : " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
            MessageBox.Show("" + Program.tenChiNhanh);
            Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
