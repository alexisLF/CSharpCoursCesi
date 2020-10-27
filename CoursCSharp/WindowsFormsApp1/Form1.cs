using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string Label { get; set; }

        public Form1()
        {
            InitializeComponent();
            Label = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Label;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        public void ChangeTextBox1Text(string text)
        {
            this.textBox1.Text = text;
        }
    }
}
