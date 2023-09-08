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
    public partial class EditItem : UserControl
    {
        private SqlConnection connection;
        public EditItem()
        {
            InitializeComponent();
            connection = new SqlConnection(dbConnect.strConnString);
        }

        private void EditItem_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

            // Get the updated values from input controls.
                //string id = label4.Text;
                //string name = textBox1.Text;
                //string price = textBox3.Text;
                //string category = comboBox1.Text;
                // ... Repeat for other input controls as needed.

                // Update the data in the database based on the unique identifier.
                string updateQuery = "UPDATE Menus SET Itemname = @Value1, Price = @Value2, Category = @Value3 WHERE Id = @Id";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Value1", textBox1.Text);
                updateCommand.Parameters.AddWithValue("@Value2", textBox3.Text);
                updateCommand.Parameters.AddWithValue("@Value3", comboBox1.Text);
                updateCommand.Parameters.AddWithValue("@Id", label6.Text);

                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Item Sucessfully");
   
                    
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

