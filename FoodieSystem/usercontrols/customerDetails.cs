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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}