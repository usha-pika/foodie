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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodieSystem.usercontrols
{
    public partial class editCustomer : UserControl
    {
        private SqlConnection connection;
        string customerIdOrders = "";
        public editCustomer()
        {
            InitializeComponent();
            connection = new SqlConnection(dbConnect.strConnString);
            try
            {

                using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Id FROM Orders WHERE CustomerName = @CustomerName", connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", textBox1.Text);
                        customerIdOrders = command.ExecuteScalar().ToString();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Remember to edit order section after editing customer");
            }
        }

        private void editCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the updated values from input controls.
            string selectedRowId = label6.Text;
            string updatedValue1 = textBox1.Text;
            string updatedValue2 = textBox2.Text;
            string updatedValue3 = textBox3.Text;
           
          
        

        // Update the data in the database.
        string updateQuery = "UPDATE Customers SET CustomerName = @Value1,Address=@Value2,Contact = @Value3 WHERE Id = @Id";
            string updateQuery1 = "UPDATE Orders SET CustomerName = @Value1 WHERE Id = @Id";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            SqlCommand updateCommand1 = new SqlCommand(@updateQuery1, connection);  
            updateCommand.Parameters.AddWithValue("@Value2", updatedValue2);
            updateCommand.Parameters.AddWithValue("@Value1", updatedValue1);
            updateCommand.Parameters.AddWithValue("@Value3", updatedValue3);
            updateCommand.Parameters.AddWithValue("@Id", selectedRowId);
            updateCommand1.Parameters.AddWithValue("@Value1",updatedValue2);
            updateCommand1.Parameters.AddWithValue("@Id", customerIdOrders);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
                updateCommand1.ExecuteNonQuery();

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

