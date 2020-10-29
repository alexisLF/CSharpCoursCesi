using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation
{
    public partial class FuelPrice : Form
    {
        public string Price { get; set; }
        public string UnitPrice { get; set; }
        public string FuelLitre { get; set; }
        public FuelPrice()
        {
            InitializeComponent();
        }

       
    }
}
