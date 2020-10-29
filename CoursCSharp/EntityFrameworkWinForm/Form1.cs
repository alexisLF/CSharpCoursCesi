using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkWinForm
{
    public partial class Form1 : Form
    {
        MyContext _context { get; set; }
        public Form1()
        {
            InitializeComponent();
            _context = new MyContext();
            articleBindingSource.DataSource = _context.article.ToList();
        }

        private void articleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }
    }
}
