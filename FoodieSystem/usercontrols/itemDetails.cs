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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace FoodieSystem.usercontrols
{
    public partial class itemDetails : UserControl
    {
        private SqlConnection connection;
        private Additem additem;
        private EditItem edititem;
        public itemDetails()
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
                string query = "SELECT * FROM Menus"; // Replace YourTableName with the actual table name.
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
            additem = new Additem();
            addUserControl(additem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edititem = new EditItem();
            string id = "";
            string name = "";
            string price = "";
            string category = "";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["Id"].Value.ToString();
                name = selectedRow.Cells["Itemname"].Value.ToString();
                price = selectedRow.Cells["Price"].Value.ToString();
                category = selectedRow.Cells["Category"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Rows selected");
            }
            edititem.label6.Text = id;
            edititem.textBox1.Text = name;
            edititem.textBox3.Text = price;
            edititem.comboBox1.Text = category;
            addUserControl(edititem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a row is selected.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's unique identifier (e.g., primary key) from the DataGridView.
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Delete the data from the database based on the unique identifier.
                string deleteQuery = "DELETE FROM Menus WHERE Id = @Id";
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

        private void itemDetails_Load(object sender, EventArgs e)
        {

        }
    }
    
}

