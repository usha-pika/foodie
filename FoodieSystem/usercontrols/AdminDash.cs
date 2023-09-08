using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieSystem.usercontrols
{
    public partial class AdminDash : UserControl
    {
        private customerDetails CustomerDetails;
        private itemDetails ItemDetails;
        private orderDetails OrderDetails;
        public AdminDash()
        {
            InitializeComponent();
            CustomerDetails = new customerDetails();
            addUserControl(CustomerDetails);
        }
        private void addUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomerDetails = new customerDetails();    
            addUserControl(CustomerDetails);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void removeitem1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            ItemDetails = new itemDetails();
            addUserControl(ItemDetails);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        private void updateitem1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            OrderDetails = new orderDetails();
            addUserControl(OrderDetails);

        }
    }
}
