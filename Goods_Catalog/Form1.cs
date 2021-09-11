using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using Goods_Catalog.Models;
namespace Goods_Catalog
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        List<Category> Categories;
        List<Producer> Producers;
        List<Product> Products;
        public Form1()
        {
            InitializeComponent();
            Products = new List<Product>();
            Producers = new List<Producer>();
            Categories = new List<Category>();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //AuthUser();
            LoadCategories();
            LoadProducers();
            LoadProducts();
        }
        private void LoadCategories()
        {
            try
            {
                string sqlQuery = $"select * from Categories";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery,connection);
                SqlDataReader reader = cmd.ExecuteReader();
                Categories.Clear();
                category_comboBox.Items.Clear();
                
                while (reader.Read())
                {
                    Category category = new Category() { Id = (int)reader["Id"],Name = reader["Name"].ToString() };
                    category_comboBox.Items.Add(category);
                    Categories.Add(category);
                }
                category_comboBox.DisplayMember = "Name";
                category_comboBox.ValueMember = "Id";
                if (category_comboBox.Items.Count > 0)
                {
                    category_comboBox.SelectedIndex = 0;
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void LoadProducers()
        {
            try
            {
                string sqlQuery = $"select * from Producers";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                manufacturer_comboBox.Items.Clear();
                Producers.Clear();
                while (reader.Read())
                {
                    Producer producer = new Producer() { Id = (int)reader["Id"], Name = reader["Name"].ToString() };
                    manufacturer_comboBox.Items.Add(producer);
                    Producers.Add(producer);
                }
                manufacturer_comboBox.DisplayMember = "Name";
                manufacturer_comboBox.ValueMember = "Id";
                if (manufacturer_comboBox.Items.Count > 0)
                {
                    manufacturer_comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void LoadProducts()
        {
            try
            {
                string sqlQuery = $"select * from Products";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                

                while (reader.Read())
                {
                    Product product= new Product();
                    product.Id = (int)reader["Id"];
                    product.Name = reader["Name"].ToString();
                    product.CategoryId = (int)reader["CategoryId"];
                    product.ProducerId = (int)reader["ProducerId"];
                    product.Price = Double.Parse(reader["Price"].ToString());
                    product.Count = (int)reader["Count"];
                    product.Measure = reader["Measure"].ToString();
                    product.Expire = (DateTime)reader["Expire"];
                    product.Delivery = reader["Delivery"].ToString();
                    var item = Goods_list.Items.Add(product.Name);
                    item.SubItems.Add(product.Price.ToString("F"));
                    item.SubItems.Add(product.Count.ToString());
                    item.SubItems.Add(product.Measure);
                    item.SubItems.Add(product.Expire.ToShortDateString());
                    item.SubItems.Add(product.Delivery.ToString());
                    Products.Add(product);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        private void AuthUser()
        {
            LoginWindow lw = new LoginWindow();
            if (lw.ShowDialog() == DialogResult.OK)
            {
                string login = lw.Login;
                string password = lw.Password;
                password = GetHash(password);
                string sqlQuery = $"select Login, Password from Users where Login = \'{login}\' and Password = \'{password}\'";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var row = reader.Read();
                    if (row)
                        MessageBox.Show("Login successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Login failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Execution error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }
        private string GetHash(string data)
        {
            MD5 md5 = MD5.Create();
            byte[] data_byte = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data_byte.Length; i++)
            {
                sBuilder.Append(data_byte[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        private void exit_item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoryCreate_item_Click(object sender, EventArgs e)
        {
           
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.operationTitle = "Create category";
            categoriesEditor.Categories = Categories;
            
            if (categoriesEditor.ShowDialog()==DialogResult.OK) {
                string query = $"insert into Categories (Name) values (@p1)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                category_comboBox.Items.Clear();
                LoadCategories();
            }
        }

        private void updateCategory_item_Click(object sender, EventArgs e)
        {
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.operationTitle = "Change category";
            categoriesEditor.Categories = Categories;
            categoriesEditor.CategoryName = (category_comboBox.SelectedItem as Category).Name;
            int id = (category_comboBox.SelectedItem as Category).Id;
            if (categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                string query = $"update Categories set Name = @p1 where Id = @p2";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                cmd.Parameters.Add("@p2", SqlDbType.Int).Value = id;
                
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                category_comboBox.Items.Clear();
                LoadCategories();
            }
        }

        private void deleteCategory_item_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriesEditor categoriesEditor = new CategoriesEditor();
                categoriesEditor.operationTitle = "Delete category";
                categoriesEditor.Categories = Categories;
                categoriesEditor.CategoryName = (category_comboBox.SelectedItem as Category).Name;
                int id = (category_comboBox.SelectedItem as Category).Id;
                if (categoriesEditor.ShowDialog() == DialogResult.OK)
                {
                    string query = $"delete from Categories where Id = @p2";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@p2", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    category_comboBox.Items.Clear();
                    LoadCategories();
                }
            }
            catch
            {
                MessageBox.Show("Can not delete category. There is items that using this category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
