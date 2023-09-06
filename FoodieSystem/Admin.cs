using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodieSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            customer1.Visible = true;
            additem1.Visible = false;
            updateitem1.Visible = false;
            removeitem1.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            customer1.Visible = false;
            additem1.Visible = true;
            updateitem1.Visible = false;
            removeitem1.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            customer1.Visible = false;
            additem1.Visible = false;
            updateitem1.Visible = false;
            removeitem1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            customer1.Visible = false;
            additem1.Visible = false;
            updateitem1.Visible = true;
            removeitem1.Visible = false;
        }

        private void updateitem1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            customer1.Visible = false;
            additem1.Visible = false;
            updateitem1.Visible = false;
            removeitem1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
