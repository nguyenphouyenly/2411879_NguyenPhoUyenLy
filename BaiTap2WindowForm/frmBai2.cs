using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2WindowForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

            var form = new frmBai2();
            form.ShowDialog();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {

            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double ketqua = 0;

            if (rdCong.Checked)
            {
                ketqua = a + b;
            }
            else if (rdTru.Checked)
            {
                ketqua = a - b;
            }
            else if (rdNhan.Checked)
            {
                ketqua = a * b;
            }
            else if (rdChia.Checked)
            {
                ketqua = a / b;
            }

            lblKetQua.Text = "Kết quả là: " + ketqua;
        }
    }
}
