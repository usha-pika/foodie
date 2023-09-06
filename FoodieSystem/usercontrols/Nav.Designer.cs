namespace FoodieSystem.usercontrols
{
    partial class menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.home = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.Mennu = new System.Windows.Forms.Label();
            this.aboutus = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(243, 59);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(48, 16);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(443, 59);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(46, 16);
            this.order.TabIndex = 2;
            this.order.Text = "Order";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // Mennu
            // 
            this.Mennu.AutoSize = true;
            this.Mennu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mennu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mennu.ForeColor = System.Drawing.Color.White;
            this.Mennu.Location = new System.Drawing.Point(340, 59);
            this.Mennu.Name = "Mennu";
            this.Mennu.Size = new System.Drawing.Size(44, 16);
            this.Mennu.TabIndex = 2;
            this.Mennu.Text = "Menu";
            // 
            // aboutus
            // 
            this.aboutus.AutoSize = true;
            this.aboutus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutus.ForeColor = System.Drawing.Color.White;
            this.aboutus.Location = new System.Drawing.Point(554, 59);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(66, 16);
            this.aboutus.TabIndex = 3;
            this.aboutus.Text = "about us";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(446, 15);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(176, 20);
            this.searchbox.TabIndex = 4;
            this.searchbox.Text = "search...";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(58)))));
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(722, 25);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(85, 27);
            this.loginbtn.TabIndex = 29;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 92);
            this.panel1.TabIndex = 30;
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
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.aboutus);
            this.Controls.Add(this.Mennu);
            this.Controls.Add(this.order);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel1);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(819, 92);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label Mennu;
        private System.Windows.Forms.Label aboutus;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Panel panel1;
    }
}
