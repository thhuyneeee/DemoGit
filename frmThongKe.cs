using DevExpress.XtraEditors;
using QuanLyChuoiBanXoi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace QuanLyChuoiBanXoi
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            cmbDanhSach.SelectedIndex = 0;
            cmbDanhSach.SelectedIndexChanged += cmbDanhSach_SelectedIndexChanged;
        }

        private void cmbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbDanhSach.SelectedItem.ToString();
            string maDBFilter = "";
            switch (selectedValue)
            {
                case "Điểm bán 1":
                    maDBFilter = "DB01";
                    break;
                case "Điểm bán 2":
                    maDBFilter = "DB02";
                    break;
                case "Tất cả":
                    LoadThongKe();
                    break;
            }
            using (var dbContext = new QLBXDBcontext())
            {
                var hds = dbContext.HoaDon.Where(x => x.MaDB == maDBFilter).ToList();

                if (hds.Any())
                {
                    dgvThongKe.Rows.Clear();
                    decimal totalAmount = 0;
                    foreach (var hd in hds)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = hd.MaHD;
                        dgvThongKe.Rows[index].Cells[1].Value = hd.MaDB;
                        dgvThongKe.Rows[index].Cells[2].Value = hd.MaNV;
                        dgvThongKe.Rows[index].Cells[3].Value = hd.MaKH;
                        dgvThongKe.Rows[index].Cells[4].Value = hd.NgayLap;
                        dgvThongKe.Rows[index].Cells[5].Value = hd.ThanhTien;
                        totalAmount += hd.ThanhTien;
                    }
                    txtTongTien.Text = totalAmount.ToString();
                }
                else
                {                  
                    txtTongTien.Text = string.Empty;
                }
            }
        }
    

        private void LoadThongKe()
        {

            dgvThongKe.Rows.Clear();
            using (var dbContext = new QLBXDBcontext())
            {
                foreach (HoaDon hd in dbContext.HoaDon)
                {
                    int index = dgvThongKe.Rows.Add();
                    dgvThongKe.Rows[index].Cells[0].Value = hd.MaHD;
                    dgvThongKe.Rows[index].Cells[1].Value = hd.MaDB;
                    dgvThongKe.Rows[index].Cells[2].Value = hd.MaNV;
                    dgvThongKe.Rows[index].Cells[3].Value = hd.MaKH;
                    dgvThongKe.Rows[index].Cells[4].Value = hd.NgayLap;
                    dgvThongKe.Rows[index].Cells[5].Value = hd.ThanhTien;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            daNhanTimKiem = true;
            string keyword = dtpNgayLap.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime searchDate;
            if (!DateTime.TryParse(keyword, out searchDate))
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập ngày đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime nextDate = searchDate.AddDays(1);
            using (var dbContext = new QLBXDBcontext())
            {
                var hds = dbContext.HoaDon.Where(x => x.NgayLap >= searchDate && x.NgayLap < nextDate).ToList();
                if (hds.Any())
                {
                    dgvThongKe.Rows.Clear();
                    foreach (var hd in hds)
                    {
                        int index = dgvThongKe.Rows.Add();
                        dgvThongKe.Rows[index].Cells[0].Value = hd.MaHD;
                        dgvThongKe.Rows[index].Cells[1].Value = hd.MaDB;
                        dgvThongKe.Rows[index].Cells[2].Value = hd.MaNV;
                        dgvThongKe.Rows[index].Cells[3].Value = hd.MaKH;
                        dgvThongKe.Rows[index].Cells[4].Value = hd.NgayLap;
                        dgvThongKe.Rows[index].Cells[5].Value = hd.ThanhTien;
                        btnTongTien.Enabled = true;
                    }
                  
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào trong ngày " + searchDate.ToString("dd/MM/yyyy"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTongTien.Enabled = false;
                    txtTongTien.Text = string.Empty;
                }
            }
        }

        private bool daNhanTimKiem = false;

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;

            using (var dbContext = new QLBXDBcontext())
            {
                if (!daNhanTimKiem)
                {
                    tongTien = dbContext.HoaDon.Sum(hd => hd.ThanhTien);
                }
                else
                {
                    string keyword = dtpNgayLap.Text.Trim();
                    if (string.IsNullOrWhiteSpace(keyword))
                    {
                        MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DateTime searchDate;
                    if (!DateTime.TryParse(keyword, out searchDate))
                    {
                        MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập ngày đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DateTime nextDate = searchDate.AddDays(1);
                    tongTien = dbContext.HoaDon
                                       .Where(x => x.NgayLap >= searchDate && x.NgayLap < nextDate)
                                       .Sum(x => x.ThanhTien);
                }
            }
                txtTongTien.Text = tongTien.ToString();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}