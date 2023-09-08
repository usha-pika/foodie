using Org.BouncyCastle.Bcpg.OpenPgp;
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
using ZstdSharp.Unsafe;

namespace FoodieSystem.usercontrols
{
    public partial class orderDetails : UserControl
    {
        private SqlConnection connection;
        private AddOrder addorder;
        private EditOrder editorder;
        public orderDetails()
        {
            InitializeComponent();
            Load_Data();    
        }
        private void Load_Data()
        {
            connection = new SqlConnection(dbConnect.strConnString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM Orders"; // Replace YourTableName with the actual table name.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView.
                dataGridView1.DataSource = dataTable;
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
        private void addUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addorder = new AddOrder();
            addUserControl(addorder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editorder = new EditOrder();    
            string id = "";
            string name = "";
            string order = "";
            string quantity = "";
            string total = "";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["Id"].Value.ToString();
                name = selectedRow.Cells["CustomerName"].Value.ToString();
                order = selectedRow.Cells["Itemname"].Value.ToString();
                quantity = selectedRow.Cells["Quantity"].Value.ToString();
                total = selectedRow.Cells["Total"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Rows selected");
            }
            editorder.label4.Text = id;
            editorder.comboBox2.Text = name;
            editorder.comboBox1.Text = order;
            editorder.textBox3.Text =quantity;
            editorder.label9.Text = total; 
            addUserControl(editorder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a row is selected.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's unique identifier (e.g., primary key) from the DataGridView.
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Delete the data from the database based on the unique identifier.
                string deleteQuery = "DELETE FROM Orders WHERE Id = @Id";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@Id", selectedRowId);

                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Data deleted successfully!");



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
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
