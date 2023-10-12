using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebox
{
    public partial class Form1 : Form
    {

        PictureBox pb = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int x = 0;
        int y = 0;

        private void btFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, y);
            this.Controls.Add(pb);
            pb.ImageLocation = @"C:\Users\ADMIN\OneDrive\Hình ảnh\Saved Pictures\item1.jpg";
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
