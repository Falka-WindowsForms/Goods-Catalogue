using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Goods_Catalog.Models;
namespace Goods_Catalog
{
    public partial class CategoriesEditor : Form
    {
        public List<Category> Categories { get; set; }
        public string operationTitle { get; set; }
        public string CategoryName { get; set; }
        public CategoriesEditor()
        {
            InitializeComponent();
        }

        private void CategoriesEditor_Load(object sender, EventArgs e)
        {
            title.Text = operationTitle;
            name_field.Text = CategoryName;
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            CategoryName = name_field.Text;
            var category = Categories.Where(c => c.Name == CategoryName).FirstOrDefault();
            if (String.IsNullOrWhiteSpace(CategoryName))
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (category != null && operationTitle != "Delete category")
            {
                MessageBox.Show("Category with this name is already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(category==null && operationTitle== "Delete category")
            {
                MessageBox.Show("Category isn`t exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
