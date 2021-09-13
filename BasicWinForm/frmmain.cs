using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinForm
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncong_Click(object sender, EventArgs e)
        {
            try
            {
                var sothunhat = txtsothunhat.Text;
                double temp = 0, nsothunhat = 0, nsothuhai = 0;
                if (double.TryParse(sothunhat, out temp)) 
                    nsothunhat = Convert.ToDouble(sothunhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                     return;

                    //}
                }
                var sothuhai = txtsothuhai.Text;
                if (Double.TryParse(sothuhai, out temp)) 
                     nsothuhai = double.Parse(sothuhai);
                 else
                 {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;

                }
                var ketqua = nsothunhat + nsothuhai;
                lblketqua.Text = ketqua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng : Vui lòng nhập lại số . Chi tiết lỗi :{ex.Message} ",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                ) ;
            }

        }

        private void btntru_Click(object sender, EventArgs e)
        {
            try
            {
                var sothunhat = txtsothunhat.Text;
                double temp = 0, nsothunhat = 0, nsothuhai = 0;
                if (double.TryParse(sothunhat, out temp))
                    nsothunhat = Convert.ToDouble(sothunhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;
                }
                var sothuhai = txtsothuhai.Text;
                if (Double.TryParse(sothuhai, out temp))
                    nsothuhai = double.Parse(sothuhai);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;

                }
                var ketqua = nsothunhat - nsothuhai;
                lblketqua.Text = ketqua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng : Vui lòng nhập lại số . Chi tiết lỗi :{ex.Message} ",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                 $"Lỗi tràn số  : Vui lòng nhập lại số ngắn hơn . Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                 $"Lỗi, Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {

            try
            {
                var sothunhat = txtsothunhat.Text;
                double temp = 0, nsothunhat = 0, nsothuhai = 0;
                if (double.TryParse(sothunhat, out temp))
                    nsothunhat = Convert.ToDouble(sothunhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;
                }
                var sothuhai = txtsothuhai.Text;
                if (Double.TryParse(sothuhai, out temp))
                    nsothuhai = double.Parse(sothuhai);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;

                }
                var ketqua = nsothunhat * nsothuhai;
                lblketqua.Text = ketqua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng : Vui lòng nhập lại số . Chi tiết lỗi :{ex.Message} ",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                 $"Lỗi tràn số  : Vui lòng nhập lại số ngắn hơn . Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                 $"Lỗi, Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            try
            {
                var sothunhat = txtsothunhat.Text;
                double temp = 0, nsothunhat = 0, nsothuhai = 0;
                if (double.TryParse(sothunhat, out temp))
                    nsothunhat = Convert.ToDouble(sothunhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;
                }
                var sothuhai = txtsothuhai.Text;
                if (Double.TryParse(sothuhai, out temp))
                    nsothuhai = double.Parse(sothuhai);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return;

                }
                var ketqua = nsothunhat / nsothuhai;
                lblketqua.Text = ketqua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng : Vui lòng nhập lại số . Chi tiết lỗi :{ex.Message} ",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                 $"Lỗi tràn số  : Vui lòng nhập lại số ngắn hơn . Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                 $"Lỗi, Chi tiết lỗi :{ex.Message} ",
                 "Thông báo lỗi",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
}
