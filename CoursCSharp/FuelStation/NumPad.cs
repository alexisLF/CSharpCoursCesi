using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class NumPad : UserControl
    {
        public string Value { get; set; }
        public event EventHandler<string> PressedValue;
        public NumPad()
        {
            InitializeComponent();
        }

        private void buttonPressed(object sender, EventArgs e)
        {
            if (PressedValue != null)
                PressedValue(this, ((Button)sender).Text);
           // Value = ((Button)sender).Text;
        }
    }
}
