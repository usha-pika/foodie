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

namespace FoodieSystem.usercontrols
{
    public partial class customerDetails : UserControl
    {
        private SqlConnection connection;
        private addCustomer AddCustomer;
        private editCustomer EditCustomer;
        public customerDetails()
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
                string query = "SELECT * FROM Customers"; // Replace YourTableName with the actual table name.
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
        public void addUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }

        private void customerDetails_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer = new addCustomer();
            addUserControl(AddCustomer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCustomer = new editCustomer();
            string id = "";
            string name = "";
            string address = "";
            string contact = "";
            string total = "";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["Id"].Value.ToString();
                name = selectedRow.Cells["CustomerName"].Value.ToString();
                address = selectedRow.Cells["Address"].Value.ToString();
                contact = selectedRow.Cells["Contact"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Rows selected");
            }
            EditCustomer.label6.Text = id;
            EditCustomer.textBox1.Text = name;
            EditCustomer.textBox2.Text = address;
            EditCustomer.textBox3.Text = contact;
            addUserControl(EditCustomer);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Check if a row is selected.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's unique identifier (e.g., primary key) from the DataGridView.
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Delete the data from the database based on the unique identifier.
                string deleteQuery = "DELETE FROM Customers WHERE Id = @Id";
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
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}