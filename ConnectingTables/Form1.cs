using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingTables
{
    public partial class Form1 : Form
    {
        string connstr = "server=10.6.0.127;port=3306;user=PC1;password=1111;database=trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            
            string insertSQL = "INSERT INTO trees_zaimov.rod" +
                "(`name`,name_bg)" + "VALUES (@name,@name_bg)";
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection is now opened!");
            MySqlCommand query = new MySqlCommand(insertSQL, connect);
            query.Parameters.AddWithValue("@name", txtName.Text);
            query.Parameters.AddWithValue("@name_bg",txtNameBG.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("Add ok ");
            connect.Close();



        }
    }
}
