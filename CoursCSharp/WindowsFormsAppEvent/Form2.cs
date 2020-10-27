using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEvent
{
    public partial class Form2 : Form
    {
        public class ShowInfo
        {
            public string Infos { get; set; }
        }

        public EventHandler<ShowInfo> ClickButton;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClickButton != null)
                ClickButton(this, new ShowInfo { Infos = "Button 1" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClickButton != null)
                ClickButton(this, new ShowInfo { Infos = "Button 2" });
        }
    }
}
