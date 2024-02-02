using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        string name;
        long registrationNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox2.Text, out registrationNo)) {
                MessageBox.Show("Enter only numbers");
                textBox2.ResetText();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string regno = textBox2.Text;
            string date = dateTimePicker1.Text;
            bool gender = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;
            string department = comboBox1.Text;
            string courses = checkedListBox1.Text;
            if (name!="" &&  regno != "" && date != "" && gender && department != "" && courses != "")
            {
                MessageBox.Show("Confirmed registration");
            }
            else
            {
                MessageBox.Show("Something is incorrect");
            }
        }

        
    }
}
