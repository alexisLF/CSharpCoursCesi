using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEntityFramework
{
    public partial class Form1 : Form
    {
        cesidbEntities we;
        public Form1()
        {
            InitializeComponent();
            we = new cesidbEntities();
            articleBindingSource.DataSource = we.article.ToList();
        }

        private void articleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
