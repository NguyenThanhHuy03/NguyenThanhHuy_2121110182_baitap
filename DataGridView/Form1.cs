using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, checkBox1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse( dataGridView1.Rows[idx].Cells[0].Value.ToString());
        }
    }
}