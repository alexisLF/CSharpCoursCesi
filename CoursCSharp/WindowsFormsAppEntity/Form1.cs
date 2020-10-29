using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntity
{
    public partial class Form1 : Form
    {
        cesidbEntities ent;

        public Form1()
        {
            InitializeComponent();
            ent = new cesidbEntities();
            articleBindingSource.DataSource = ent.article.ToList();
        }

        private void articleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ent.SaveChanges();
        }

        private void articleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
