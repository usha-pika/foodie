using Org.BouncyCastle.Utilities;
using SAM.form;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodieSystem.usercontrols
{
    public partial class AddOrder : UserControl
    {
        private SqlConnection connection;
        private orderDetails OrderDetails;
        public AddOrder()
        {
            InitializeComponent();
            connection = new SqlConnection(dbConnect.strConnString);
            // Populate the ComboBox with data from the database when the form loads.
            string query = "SELECT Itemname FROM Menus";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string columnNameValue = reader["Itemname"].ToString();
                    comboBox1.Items.Add(columnNameValue);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            string query1 = "SELECT CustomerName FROM Customers";// Replace YourColumnName and YourTableName with actual column and table names.

            try
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    string columnNameValue1 = reader1["CustomerName"].ToString();
                    comboBox2.Items.Add(columnNameValue1);
                }

                reader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Price,Itemname FROM Menus";// Replace YourColumnName and YourTableName with actual column and table names.

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (comboBox1.Text == reader["Itemname"].ToString())
                    {
                        int columnNameValue = Int32.Parse(reader["Price"].ToString());
                        int pieces = Int32.Parse(textBox3.Text);
                        label9.Text = (columnNameValue * pieces).ToString();
                        break;
                    }
                    label9.Text = "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Prepare your SQL INSERT statement with placeholders for parameters
                string insertQuery = "INSERT INTO Orders (CustomerName,ItemName, Quantity, Total,Date) VALUES (@Value1, @Value2,@Value3,@Value4,@Value5)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);

                // Set parameter values from your input controls (e.g., textboxes)
                cmd.Parameters.AddWithValue("@Value1", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Value2", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Value3", textBox3.Text);
                cmd.Parameters.AddWithValue("@Value4", label9.Text);
                cmd.Parameters.AddWithValue("Value5", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                // Execute the INSERT statement
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully!");

                // Optionally, update the DataGridView or ListBox to show the newly inserted data
                // RefreshDataGrid(); // Implement a method to refresh your data grid or list box

                // Clear input controls if needed

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                OrderDetails = new orderDetails();
            }
        }
    }
    
}
