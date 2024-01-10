namespace QuanLyChuoiBanXoi
{
    partial class frmDiemBan2
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
            this.dgvDiem2 = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpDB2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDB = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem2)).BeginInit();
            this.grpDB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem2
            // 
            this.dgvDiem2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaDB,
            this.colMaNV,
            this.colMaKH,
            this.colNgayLap,
            this.colThanhTien});
            this.dgvDiem2.Location = new System.Drawing.Point(484, 37);
            this.dgvDiem2.Name = "dgvDiem2";
            this.dgvDiem2.RowHeadersWidth = 51;
            this.dgvDiem2.RowTemplate.Height = 24;
            this.dgvDiem2.Size = new System.Drawing.Size(1087, 525);
            this.dgvDiem2.TabIndex = 1;
            this.dgvDiem2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem2_CellClick);
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
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSua.Location = new System.Drawing.Point(255, 585);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 46);
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXoa.Location = new System.Drawing.Point(115, 586);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 45);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpDB2
            // 
            this.grpDB2.Controls.Add(this.dtpNgayLap);
            this.grpDB2.Controls.Add(this.label2);
            this.grpDB2.Controls.Add(this.txtMaKhachHang);
            this.grpDB2.Controls.Add(this.label1);
            this.grpDB2.Controls.Add(this.txtThanhTien);
            this.grpDB2.Controls.Add(this.lblDiaChi);
            this.grpDB2.Controls.Add(this.txtMaNV);
            this.grpDB2.Controls.Add(this.txtMaDB);
            this.grpDB2.Controls.Add(this.lblSDT);
            this.grpDB2.Controls.Add(this.lblTenKH);
            this.grpDB2.Controls.Add(this.txtMaHD);
            this.grpDB2.Controls.Add(this.lblMaKH);
            this.grpDB2.Location = new System.Drawing.Point(12, 37);
            this.grpDB2.Name = "grpDB2";
            this.grpDB2.Size = new System.Drawing.Size(451, 525);
            this.grpDB2.TabIndex = 60;
            this.grpDB2.TabStop = false;
            this.grpDB2.Text = "Thông tin Điểm Bán 2";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(199, 393);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(188, 23);
            this.dtpNgayLap.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 467);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Thành Tiền";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhachHang.Location = new System.Drawing.Point(199, 314);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(188, 23);
            this.txtMaKhachHang.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Location = new System.Drawing.Point(199, 460);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(188, 23);
            this.txtThanhTien.TabIndex = 41;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(76, 398);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(59, 16);
            this.lblDiaChi.TabIndex = 40;
            this.lblDiaChi.Text = "Ngày Lập";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Location = new System.Drawing.Point(199, 223);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(188, 23);
            this.txtMaNV.TabIndex = 38;
            // 
            // txtMaDB
            // 
            this.txtMaDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDB.Location = new System.Drawing.Point(199, 147);
            this.txtMaDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDB.Name = "txtMaDB";
            this.txtMaDB.Size = new System.Drawing.Size(188, 23);
            this.txtMaDB.TabIndex = 37;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(76, 226);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(86, 16);
            this.lblSDT.TabIndex = 33;
            this.lblSDT.Text = "Mã Nhân Viên";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(76, 154);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(83, 16);
            this.lblTenKH.TabIndex = 32;
            this.lblTenKH.Text = "Mã Điểm Bán";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Location = new System.Drawing.Point(199, 73);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(188, 23);
            this.txtMaHD.TabIndex = 31;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(76, 80);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(77, 16);
            this.lblMaKH.TabIndex = 30;
            this.lblMaKH.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1043, 604);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tìm kiếm theo mã hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(1251, 585);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(190, 37);
            this.txtTimKiem.TabIndex = 65;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimKiem.Location = new System.Drawing.Point(1458, 585);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 37);
            this.btnTimKiem.TabIndex = 64;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnQL.Location = new System.Drawing.Point(484, 585);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(116, 37);
            this.btnQL.TabIndex = 74;
            this.btnQL.Text = "Quay Lại";
            this.btnQL.UseVisualStyleBackColor = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // frmDiemBan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 674);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpDB2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvDiem2);
            this.Name = "frmDiemBan2";
            this.Text = "Điểm Bán 2";
            this.Load += new System.EventHandler(this.frmDiemBan2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem2)).EndInit();
            this.grpDB2.ResumeLayout(false);
            this.grpDB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grpDB2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaDB;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQL;
    }
}