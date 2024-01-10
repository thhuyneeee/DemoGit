namespace QuanLyChuoiBanXoi
{
    partial class frmHoTro
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
            this.components = new System.ComponentModel.Container();
            this.pnlChuChay = new System.Windows.Forms.PictureBox();
            this.tmChuChay = new System.Windows.Forms.Timer(this.components);
            this.lblChuoichu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChuChay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChuChay
            // 
            this.pnlChuChay.Location = new System.Drawing.Point(-4, 2);
            this.pnlChuChay.Name = "pnlChuChay";
            this.pnlChuChay.Size = new System.Drawing.Size(1057, 577);
            this.pnlChuChay.TabIndex = 0;
            this.pnlChuChay.TabStop = false;
            // 
            // tmChuChay
            // 
            this.tmChuChay.Tick += new System.EventHandler(this.tmChuChay_Tick_1);
            // 
            // lblChuoichu
            // 
            this.lblChuoichu.AutoSize = true;
            this.lblChuoichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuoichu.Location = new System.Drawing.Point(404, 512);
            this.lblChuoichu.Name = "lblChuoichu";
            this.lblChuoichu.Size = new System.Drawing.Size(187, 38);
            this.lblChuoichu.TabIndex = 1;
            this.lblChuoichu.Text = "lblChuoichu";
            // 
            // frmHoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 582);
            this.Controls.Add(this.lblChuoichu);
            this.Controls.Add(this.pnlChuChay);
            this.Name = "frmHoTro";
            this.Text = "Hỗ Trợ";
            this.Load += new System.EventHandler(this.frmHoTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlChuChay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlChuChay;
        private System.Windows.Forms.Timer tmChuChay;
        private System.Windows.Forms.Label lblChuoichu;
    }
}