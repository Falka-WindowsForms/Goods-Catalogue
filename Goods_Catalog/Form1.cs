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
namespace Goods_Catalog
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void exit_item_Click(object sender, EventArgs e)
        {

        }

        private string GetHash(string data)
        {
            MD5 md5 = MD5.Create();
            byte[] data_byte = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder sBuilder = new StringBuilder();
            for(int i = 0; i < data_byte.Length; i++)
            {
                sBuilder.Append(data_byte[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            if (lw.ShowDialog() == DialogResult.OK)
            {
                string login = lw.Login;
                string password = lw.Password;
                password = GetHash(password);
                string sqlQuery = $"select Login, Password from Users where Login = {login} and Password = {password}";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                var res = reader.Read();
                connection.Close();
            }
            

        }
    }
}
