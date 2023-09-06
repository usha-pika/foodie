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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            ourMenu1.Visible = false;
            
        }

        private void Mennu_Click(object sender, EventArgs e)
        {

            home1.Visible = false;
            ourMenu1.Visible = true;
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            home1.Visible = false;
            ourMenu1.Visible = false;
        }
    }
}
