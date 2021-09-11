using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods_Catalog
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
            //InitializeComponent();
            InitializeComponent();
        }

        private void exit_item_Click(object sender, EventArgs e)
        {

        }
    }
}
