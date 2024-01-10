namespace QuanLyChuoiBanXoi
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.txtEmailDK = new System.Windows.Forms.TextBox();
            this.btnLayLaiMK = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblEmailDK = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailDK
            // 
            this.txtEmailDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDK.Location = new System.Drawing.Point(200, 156);
            this.txtEmailDK.Multiline = true;
            this.txtEmailDK.Name = "txtEmailDK";
            this.txtEmailDK.Size = new System.Drawing.Size(357, 33);
            this.txtEmailDK.TabIndex = 29;
            // 
            // btnLayLaiMK
            // 
            this.btnLayLaiMK.AutoSize = true;
            this.btnLayLaiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLayLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMK.ForeColor = System.Drawing.Color.Black;
            this.btnLayLaiMK.Location = new System.Drawing.Point(260, 287);
            this.btnLayLaiMK.Name = "btnLayLaiMK";
            this.btnLayLaiMK.Size = new System.Drawing.Size(145, 46);
            this.btnLayLaiMK.TabIndex = 28;
            this.btnLayLaiMK.Text = "Lấy lại mật khẩu";
            this.btnLayLaiMK.UseVisualStyleBackColor = false;
            this.btnLayLaiMK.Click += new System.EventHandler(this.btnLayLaiMK_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(46, 216);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(141, 22);
            this.lblKetQua.TabIndex = 27;
            this.lblKetQua.Text = "Kết Quả Gửi Về:";
            // 
            // lblEmailDK
            // 
            this.lblEmailDK.AutoSize = true;
            this.lblEmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDK.Location = new System.Drawing.Point(46, 160);
            this.lblEmailDK.Name = "lblEmailDK";
            this.lblEmailDK.Size = new System.Drawing.Size(133, 22);
            this.lblEmailDK.TabIndex = 26;
            this.lblEmailDK.Text = "Email Đăng Ký:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(260, 15);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(175, 131);
            this.pictureEdit1.TabIndex = 38;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 398);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtEmailDK);
            this.Controls.Add(this.btnLayLaiMK);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblEmailDK);
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailDK;
        private System.Windows.Forms.Button btnLayLaiMK;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblEmailDK;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}