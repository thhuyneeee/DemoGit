using DevExpress.XtraEditors;
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
    public partial class frmHoTro : Form
    {
        public frmHoTro()
        {
            InitializeComponent();
        }
        private void frmHoTro_Load(object sender, EventArgs e)
        {
            lblChuoichu.Text = "Đây là dự án nhỏ của nhóm mình:\r\n\n\n\nNếu có gì thiếu sót mong các bạn góp ý trực tiếp hoặc qua Mail: nhuthuy7122003@gmail.com\r\n\n\n\nCảm ơn các bạn đã xem.\r\n\r\n\n";
            tmChuChay.Enabled = true;
        }

        private void tmChuChay_Tick_1(object sender, EventArgs e)
        {

            lblChuoichu.Location = new Point(lblChuoichu.Location.X, lblChuoichu.Location.Y - 2);
            if (lblChuoichu.Location.Y + lblChuoichu.Height < 0)
            {
                lblChuoichu.Location = new Point(lblChuoichu.Location.X, pnlChuChay.Height);
            }

        }


    }
}