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
    public partial class Additem : UserControl
    {
        private SqlConnection connection;
        public Additem()
        {
            InitializeComponent();
            connection = new SqlConnection(dbConnect.strConnString);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Prepare your SQL INSERT statement with placeholders for parameters
                string insertQuery = "INSERT INTO Menus (ItemName, Price, Category) VALUES (@Value1, @Value2,@Value3)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);

                // Set parameter values from your input controls (e.g., textboxes)
                cmd.Parameters.AddWithValue("@Value1", textBox1.Text);
                cmd.Parameters.AddWithValue("@Value2", textBox3.Text);
                cmd.Parameters.AddWithValue("@Value3", comboBox1.Text);

                // Execute the INSERT statement
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully!");

                // Optionally, update the DataGridView or ListBox to show the newly inserted data
                // RefreshDataGrid(); // Implement a method to refresh your data grid or list box

                // Clear input controls if needed
                textBox1.Clear();
                textBox3.Clear();
  
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
    
