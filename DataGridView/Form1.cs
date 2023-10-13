using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Import the 'System.Drawing' namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) //thêm
        {
            Employee em = new Employee();
            em.Id = textBox1.Text;
            em.Name = textBox2.Text;
            em.Age = int.Parse(textBox3.Text);

            // Kiểm tra giới tính từ checkBox1 và checkBox2
            if (checkBox1.Checked)
            {
                em.Gender = "Nam";
            }
            else if (checkBox2.Checked)
            {
                em.Gender = "Nữ";
            }

            // Tạo một hàng mới cho dataGridView1
            DataGridViewRow row = new DataGridViewRow();

            // Tạo một ô hình ảnh
            DataGridViewImageCell imgCell = new DataGridViewImageCell();
            imgCell.Value = pbImage.Image;

            // Thêm các ô dữ liệu khác vào hàng
            row.Cells.Add(imgCell);
            row.Cells.Add(new DataGridViewTextBoxCell { Value = em.Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = em.Name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = em.Age });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = em.Gender });

            // Thêm hàng vào dataGridView1
            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)//xoá
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            pbImage.Image = dataGridView1.Rows[idx].Cells[0].Value as System.Drawing.Image;
            textBox1.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[idx].Cells[4].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)//thoát
        {
            this.Close();
        }

        private bool isEditing = false;

        private void btSua_Click(object sender, EventArgs e)//sửa
        {
            if (!isEditing)
            {
                isEditing = true;
                btSua.Text = "Lưu";

                // Bật sửa trên dòng hiện tại
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[idx].ReadOnly = false;

                // Hiển thị giới tính của dòng hiện tại dựa trên giá trị của cột thứ 3 (index 2) trong DataGridView
                if (dataGridView1.Rows[idx].Cells[3].Value != null && dataGridView1.Rows[idx].Cells[3].Value.ToString() == "Nam")
                {
                    checkBox1.Checked = true;
                }
                else if (dataGridView1.Rows[idx].Cells[3].Value != null && dataGridView1.Rows[idx].Cells[3].Value.ToString() == "Nữ")
                {
                    checkBox2.Checked = true;
                }
            }
            else
            {
                isEditing = false;
                btSua.Text = "Sửa";

                // Lưu các thay đổi
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[idx].ReadOnly = true;

                // Cập nhật dữ liệu trong dataGridView1
                dataGridView1.Rows[idx].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[idx].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[idx].Cells[3].Value = textBox3.Text;

                // Cập nhật giới tính dựa trên giá trị của checkBoxNam và checkBoxNu
                if (checkBox1.Checked)
                {
                    dataGridView1.Rows[idx].Cells[4].Value = "Nam";
                }
                else if (checkBox2.Checked)
                {
                    dataGridView1.Rows[idx].Cells[4].Value = "Nữ";
                }
                // Cập nhật hình ảnh vào cột hình ảnh (Column5)
                dataGridView1.Rows[idx].Cells[0].Value = pbImage.Image;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog1.Title = "Chọn hình ảnh";
            openFileDialog1.Filter = "Tất cả các tệp hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tất cả các tệp|*.*";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tệp hình ảnh đã chọn
                string imagePath = openFileDialog1.FileName;

                // Hiển thị hình ảnh trong PictureBox
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.ImageLocation = imagePath;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
