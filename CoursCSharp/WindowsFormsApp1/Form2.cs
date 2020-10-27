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
    public partial class Form2 : Form
    {
        public static string s = "";
        Form1 F1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            F1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            F1.ChangeTextBox1Text("Button 1 clicked");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            F1.ChangeTextBox1Text("Button 2 clicked");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            F1.ChangeTextBox1Text("Button 3 clicked");

        }
    }
}
