using FoodieSystem.usercontrols;
using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieSystem
{
    public partial class Form1 : Form
    {

        private orderpage orderPage;
        private LoginPage login;
        private AdminDash adminDash;
        private dbConnect DBConnect;
        public Form1()
        {
            InitializeComponent();

        }

        private void addUserControl(UserControl userControl)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            login = new LoginPage();
            addUserControl(login);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            orderPage = new orderpage();
            addUserControl(orderPage);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login = new LoginPage();
            addUserControl(login);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();
            log.Show();
            this.Hide();
        }

        private void Mennu_Click(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            orderpage order = new orderpage();
            order.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            string Username = UserNaam.Text;
            string Password = password.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Empty input");
            }
            else
            {

                try
                {

                    using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SELECT * FROM admins WHERE Username = @Username AND Password = @Password", connection))
                        {
                            command.Parameters.AddWithValue("@Username", Username);
                            command.Parameters.AddWithValue("@Password", Password);
                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Login successful!");
                                adminDash = new AdminDash();
                                addUserControl(adminDash);
                                // Perform actions after successful login, such as opening the main application window.


                            }
                            else
                            {
                                MessageBox.Show("Login failed. Please check your credentials.");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Inavlid Credentials");
                }
            } 

        }
    }
}
 
    

            
