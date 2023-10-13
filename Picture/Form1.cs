using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            // Tạo một OpenFileDialog để chọn tệp hình ảnh
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico"; // Bộ lọc cho các tệp hình ảnh
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn tệp chưa
                {
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(100, 100);
                    pb.Location = new Point(x, y);
                    this.Controls.Add(pb);
                    pb.ImageLocation = openFileDialog.FileName; // Đặt hình ảnh của PictureBox từ tệp đã chọn
                }
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}
