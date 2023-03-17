using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
                textBox2.Text = textBox1.Text;
            else
                textBox2.Text = (int.Parse(textBox1.Text) *10).ToString();
            listBox1.Items.Add(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (int.TryParse(textBox.Text, out int result))
            {
                textBox.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                textBox.BackColor = Color.Red;
                button1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = (string)listBox1.Items[listBox1.SelectedIndex];
        }
    }
}
