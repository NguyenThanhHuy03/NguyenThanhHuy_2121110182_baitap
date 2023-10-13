using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            int disc = 0;
            if (ckDiscount.Checked == true)
            {
                if (int.TryParse(tbDiscount.Text, out disc))
                {
                    msg += tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
                }
                else
                {
                    msg += tbName.Text + " giảm giá không hợp lệ. Vui lòng nhập giảm giá" + "\r\n";
                }
            }
            else
            {
                msg += tbName.Text + " không được giảm giá" + "\r\n";
            }

            tbResult.Text = msg;
        }
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }
    }
}
