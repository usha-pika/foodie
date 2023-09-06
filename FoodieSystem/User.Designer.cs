namespace FoodieSystem
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.Mennu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ourMenu1 = new FoodieSystem.usercontrols.OurMenu();
            this.home1 = new FoodieSystem.usercontrols.Home();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.searchbox);
            this.panel2.Controls.Add(this.loginbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.order);
            this.panel2.Controls.Add(this.Mennu);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 92);
            this.panel2.TabIndex = 38;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(471, 11);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(176, 20);
            this.searchbox.TabIndex = 35;
            this.searchbox.Text = "search...";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(58)))));
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(717, 27);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(85, 27);
            this.loginbtn.TabIndex = 36;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodieSystem.Properties.Resources.foodie_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(397, 60);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(48, 16);
            this.home.TabIndex = 31;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(601, 60);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(46, 16);
            this.order.TabIndex = 33;
            this.order.Text = "Order";
            // 
            // Mennu
            // 
            this.Mennu.AutoSize = true;
            this.Mennu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mennu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mennu.ForeColor = System.Drawing.Color.White;
            this.Mennu.Location = new System.Drawing.Point(501, 60);
            this.Mennu.Name = "Mennu";
            this.Mennu.Size = new System.Drawing.Size(44, 16);
            this.Mennu.TabIndex = 32;
            this.Mennu.Text = "Menu";
            this.Mennu.Click += new System.EventHandler(this.Mennu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-7, -31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 567);
            this.panel1.TabIndex = 41;
            // 
            // ourMenu1
            // 
            this.ourMenu1.Location = new System.Drawing.Point(0, 0);
            this.ourMenu1.Name = "ourMenu1";
            this.ourMenu1.Size = new System.Drawing.Size(815, 433);
            this.ourMenu1.TabIndex = 40;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(9, 16);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(803, 417);
            this.home1.TabIndex = 39;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.home1);
            this.panel3.Controls.Add(this.ourMenu1);
            this.panel3.Location = new System.Drawing.Point(7, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 436);
            this.panel3.TabIndex = 41;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label Mennu;
        private usercontrols.Home home1;
        private usercontrols.OurMenu ourMenu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}