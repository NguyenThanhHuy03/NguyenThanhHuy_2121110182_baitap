using System;
using System.Collections;
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
        ArrayList lstEmp;
        BindingSource bs = new BindingSource();
       
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> lst;
        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dataGridView1.Rows.Add(em.Id, em.Name, em.Age);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Employee em = new Employee();
            em.Id = textBox1.Text;
            em.Name = textBox2.Text;
            em.Age = int.Parse(textBox3.Text);
            em.Gender = checkBox1.Checked;
            lst.Add(em);
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, checkBox1.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            checkBox1.Checked = bool.Parse( dataGridView1.Rows[idx].Cells[3].Value.ToString());
        }
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Tran Tien";
            em.Age = 20;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyen Cuong";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyen Hao";
            em.Age = 23;
            lst.Add(em);
            return lst;
        }
        public List<Employee> lstGetData()
        {
            List<Employee> lst = new List<Employee>();
            return lst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}