namespace QuanLyChuoiBanXoi
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.btnQL = new System.Windows.Forms.Button();
            this.cmbDanhSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaDB,
            this.colMaNV,
            this.colMaKH,
            this.colNgayLap,
            this.colThanhTien});
            this.dgvThongKe.Location = new System.Drawing.Point(12, 98);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1571, 441);
            this.dgvThongKe.TabIndex = 1;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colMaDB
            // 
            this.colMaDB.HeaderText = "Mã Điểm Bán";
            this.colMaDB.MinimumWidth = 6;
            this.colMaDB.Name = "colMaDB";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã Nhân Viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(1211, 53);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(250, 23);
            this.dtpNgayLap.TabIndex = 69;
            this.dtpNgayLap.Value = new System.DateTime(2024, 1, 3, 15, 56, 45, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1065, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tìm kiếm theo ngày";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimKiem.Location = new System.Drawing.Point(1467, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 32);
            this.btnTimKiem.TabIndex = 67;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(1265, 568);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(190, 37);
            this.txtTongTien.TabIndex = 71;
            // 
            // btnTongTien
            // 
            this.btnTongTien.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTongTien.Location = new System.Drawing.Point(1472, 568);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(116, 37);
            this.btnTongTien.TabIndex = 70;
            this.btnTongTien.Text = "Tổng Tiền";
            this.btnTongTien.UseVisualStyleBackColor = false;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnQL.Location = new System.Drawing.Point(12, 37);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(116, 37);
            this.btnQL.TabIndex = 72;
            this.btnQL.Text = "Quay Lại";
            this.btnQL.UseVisualStyleBackColor = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // cmbDanhSach
            // 
            this.cmbDanhSach.DropDownWidth = 123;
            this.cmbDanhSach.FormattingEnabled = true;
            this.cmbDanhSach.ItemHeight = 16;
            this.cmbDanhSach.Items.AddRange(new object[] {
            "Tất cả",
            "Điểm bán 1",
            "Điểm bán 2"});
            this.cmbDanhSach.Location = new System.Drawing.Point(1106, 575);
            this.cmbDanhSach.Name = "cmbDanhSach";
            this.cmbDanhSach.Size = new System.Drawing.Size(105, 24);
            this.cmbDanhSach.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(948, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Danh sách điểm bán";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.cmbDanhSach);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.ComboBox cmbDanhSach;
        private System.Windows.Forms.Label label1;
    }
}