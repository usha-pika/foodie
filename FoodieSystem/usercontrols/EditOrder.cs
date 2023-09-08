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
    public partial class EditOrder : UserControl
    {
        private SqlConnection connection;
        public EditOrder()
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

        private void EditOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) { 
 
            string query = "SELECT Price FROM Menus";// Replace YourColumnName and YourTableName with actual column and table names.

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int columnNameValue = Int32.Parse(reader["Price"].ToString());
                    int pieces = Int32.Parse(textBox3.Text);
                    label9.Text = (columnNameValue * pieces).ToString();
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

        private void add_Click(object sender, EventArgs e) {


            // Get the updated values from input controls.
            string selectedRowId = label4.Text;
                string updatedValue1 = comboBox1.Text;
                string updatedValue2 = comboBox2.Text;
            string updatedValue3 = textBox3.Text;
            string updatedValue4 = label9.Text;

                // Update the data in the database.
                string updateQuery = "UPDATE Orders SET CustomerName = @Value1,Itemname = @Value2,Quantity=@Value3,Total=@Value4 WHERE Id = @Id";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Value2", updatedValue1);
                updateCommand.Parameters.AddWithValue("@Value1", updatedValue2);
            updateCommand.Parameters.AddWithValue("@Value3", updatedValue3);
            updateCommand.Parameters.AddWithValue("@Value4", updatedValue4);
            updateCommand.Parameters.AddWithValue("@Id", selectedRowId);

                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
            
                        MessageBox.Show("Data updated successfully!");


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
           
    }
}
    

