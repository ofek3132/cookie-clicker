namespace cookie_clicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cookiesLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cursorPrice = new System.Windows.Forms.Label();
            this.grandmaPrice = new System.Windows.Forms.Label();
            this.farmPrice = new System.Windows.Forms.Label();
            this.minePrice = new System.Windows.Forms.Label();
            this.cursorAmount = new System.Windows.Forms.Label();
            this.grandmaAmount = new System.Windows.Forms.Label();
            this.farmAmount = new System.Windows.Forms.Label();
            this.mineAmount = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cookiesLabel
            // 
            this.cookiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cookiesLabel.Location = new System.Drawing.Point(51, 37);
            this.cookiesLabel.Name = "cookiesLabel";
            this.cookiesLabel.Size = new System.Drawing.Size(241, 75);
            this.cookiesLabel.TabIndex = 0;
            this.cookiesLabel.Text = "0 cookies";
            this.cookiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpsLabel
            // 
            this.cpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cpsLabel.Location = new System.Drawing.Point(87, 410);
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Size = new System.Drawing.Size(150, 36);
            this.cpsLabel.TabIndex = 16;
            this.cpsLabel.Text = "0 cps";
            this.cpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cookie_clicker.Properties.Resources.yay;
            this.pictureBox1.Location = new System.Drawing.Point(51, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(354, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 516);
            this.panel1.TabIndex = 18;
            // 
            // shopLabel
            // 
            this.shopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shopLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.shopLabel.Location = new System.Drawing.Point(155, 23);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(150, 50);
            this.shopLabel.TabIndex = 2;
            this.shopLabel.Text = "Shop";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cookie_clicker.Properties.Resources.cursor;
            this.pictureBox2.Location = new System.Drawing.Point(73, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::cookie_clicker.Properties.Resources.grandma;
            this.pictureBox3.Location = new System.Drawing.Point(71, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(337, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::cookie_clicker.Properties.Resources.farm;
            this.pictureBox4.Location = new System.Drawing.Point(71, 260);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(339, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::cookie_clicker.Properties.Resources.mine;
            this.pictureBox5.Location = new System.Drawing.Point(69, 338);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(339, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // cursorPrice
            // 
            this.cursorPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cursorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cursorPrice.ForeColor = System.Drawing.Color.Green;
            this.cursorPrice.Location = new System.Drawing.Point(177, 150);
            this.cursorPrice.Name = "cursorPrice";
            this.cursorPrice.Size = new System.Drawing.Size(50, 12);
            this.cursorPrice.TabIndex = 8;
            this.cursorPrice.Text = "20";
            this.cursorPrice.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grandmaPrice
            // 
            this.grandmaPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grandmaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grandmaPrice.ForeColor = System.Drawing.Color.Green;
            this.grandmaPrice.Location = new System.Drawing.Point(177, 230);
            this.grandmaPrice.Name = "grandmaPrice";
            this.grandmaPrice.Size = new System.Drawing.Size(50, 12);
            this.grandmaPrice.TabIndex = 9;
            this.grandmaPrice.Text = "15";
            this.grandmaPrice.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // farmPrice
            // 
            this.farmPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.farmPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.farmPrice.ForeColor = System.Drawing.Color.Green;
            this.farmPrice.Location = new System.Drawing.Point(177, 309);
            this.farmPrice.Name = "farmPrice";
            this.farmPrice.Size = new System.Drawing.Size(50, 12);
            this.farmPrice.TabIndex = 10;
            this.farmPrice.Text = "100";
            this.farmPrice.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // minePrice
            // 
            this.minePrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minePrice.ForeColor = System.Drawing.Color.Green;
            this.minePrice.Location = new System.Drawing.Point(177, 384);
            this.minePrice.Name = "minePrice";
            this.minePrice.Size = new System.Drawing.Size(50, 12);
            this.minePrice.TabIndex = 11;
            this.minePrice.Text = "500";
            this.minePrice.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // cursorAmount
            // 
            this.cursorAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cursorAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cursorAmount.Location = new System.Drawing.Point(347, 128);
            this.cursorAmount.Name = "cursorAmount";
            this.cursorAmount.Size = new System.Drawing.Size(46, 34);
            this.cursorAmount.TabIndex = 12;
            this.cursorAmount.Text = "0";
            this.cursorAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cursorAmount.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grandmaAmount
            // 
            this.grandmaAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grandmaAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grandmaAmount.Location = new System.Drawing.Point(347, 208);
            this.grandmaAmount.Name = "grandmaAmount";
            this.grandmaAmount.Size = new System.Drawing.Size(46, 34);
            this.grandmaAmount.TabIndex = 13;
            this.grandmaAmount.Text = "0";
            this.grandmaAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grandmaAmount.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // farmAmount
            // 
            this.farmAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.farmAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.farmAmount.Location = new System.Drawing.Point(347, 287);
            this.farmAmount.Name = "farmAmount";
            this.farmAmount.Size = new System.Drawing.Size(46, 34);
            this.farmAmount.TabIndex = 14;
            this.farmAmount.Text = "0";
            this.farmAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.farmAmount.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // mineAmount
            // 
            this.mineAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mineAmount.Location = new System.Drawing.Point(347, 362);
            this.mineAmount.Name = "mineAmount";
            this.mineAmount.Size = new System.Drawing.Size(46, 34);
            this.mineAmount.TabIndex = 15;
            this.mineAmount.Text = "0";
            this.mineAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mineAmount.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::cookie_clicker.Properties.Resources.image;
            this.pictureBox6.Location = new System.Drawing.Point(169, 438);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(136, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.mineAmount);
            this.panel2.Controls.Add(this.farmAmount);
            this.panel2.Controls.Add(this.grandmaAmount);
            this.panel2.Controls.Add(this.cursorAmount);
            this.panel2.Controls.Add(this.minePrice);
            this.panel2.Controls.Add(this.farmPrice);
            this.panel2.Controls.Add(this.grandmaPrice);
            this.panel2.Controls.Add(this.cursorPrice);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.shopLabel);
            this.panel2.Location = new System.Drawing.Point(388, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 515);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.loadLabel);
            this.panel3.Controls.Add(this.saveLabel);
            this.panel3.Controls.Add(this.cpsLabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.cookiesLabel);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 514);
            this.panel3.TabIndex = 20;
            // 
            // loadLabel
            // 
            this.loadLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loadLabel.Location = new System.Drawing.Point(184, 470);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(150, 36);
            this.loadLabel.TabIndex = 18;
            this.loadLabel.Text = "load";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // saveLabel
            // 
            this.saveLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveLabel.Location = new System.Drawing.Point(12, 470);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(150, 36);
            this.saveLabel.TabIndex = 17;
            this.saveLabel.Text = "save";
            this.saveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cookie Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cookiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cpsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label cursorPrice;
        private System.Windows.Forms.Label grandmaPrice;
        private System.Windows.Forms.Label farmPrice;
        private System.Windows.Forms.Label minePrice;
        private System.Windows.Forms.Label cursorAmount;
        private System.Windows.Forms.Label grandmaAmount;
        private System.Windows.Forms.Label farmAmount;
        private System.Windows.Forms.Label mineAmount;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label saveLabel;
    }
}

