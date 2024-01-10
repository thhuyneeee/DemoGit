using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiBanXoi
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.ShowDialog();
        }

        private void linkLabel_QuenMk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();  
            quenMatKhau.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        Modify modify = new Modify();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Lỗi");
                txtTaiKhoan.Focus();
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi");
                txtMatKhau.Focus();
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "' ";
                if (modify.TaiKhoans(query).Count > 0)
                {
                    this.Hide();
                    frmGiaoDienChinh giaoDienChinh = new frmGiaoDienChinh();

                    // frmHome home = new frmHome();
                    giaoDienChinh.ShowDialog();

                    //MessageBox.Show("Dang nhap thanh cong!");
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Lỗi");
                    txtTaiKhoan.Focus(); // cho con trỏ chuột quay lại ô tk 
                }
            }          
        }
        private void chkHienThi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHienThi.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }

            
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
