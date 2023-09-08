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
    public partial class orderpage : UserControl
    {
        private payment pay;
        public orderpage()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
         
        }
        private void addUserControl2(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
            
        }
        private void orderpage_Load(object sender, EventArgs e)
        {

        }

        private void payment_Click(object sender, EventArgs e)
        {
            pay = new payment();
             addUserControl2(pay);
        }
    }
}
