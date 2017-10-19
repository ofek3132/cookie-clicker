using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookie_clicker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var.cookies += var.g;
            cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var.cookies += var.cps;
            cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
            cpsLabel.Text = var.cps + " cps";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.price)
            {
                var.cu++;
                var.g += var.cuUpgrades;
                var.cookies -= var.price;
                var.price = var.price * 1.20;
                cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
                cursorPrice.Text = "" + Math.Ceiling(var.price);
                cursorAmount.Text = "" + var.cu;
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.price1)
            {
                var.gr++;
                var.cps += var.grUpgrades;
                var.cookies -= var.price1;
                var.price1 = var.price1 * 1.20;
                cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
                grandmaPrice.Text = "" + Math.Ceiling(var.price1);
                grandmaAmount.Text = "" + var.gr;
                cpsLabel.Text = var.cps + " cps";
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.price2)
            {
                var.fa++;
                var.cps += var.faUpgrades;
                var.cookies -= var.price2;
                var.price2 = var.price2 * 1.20;
                cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
                farmPrice.Text = "" + Math.Ceiling(var.price2);
                farmAmount.Text = "" + var.fa;
                cpsLabel.Text = var.cps + " cps";
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.price3)
            {
                var.mi++;
                var.cps += var.miUpgrades;
                var.cookies -= var.price3;
                var.price3 = var.price3 * 1.20;
                cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
                minePrice.Text = "" + Math.Ceiling(var.price3);
                mineAmount.Text = "" + var.mi;
                cpsLabel.Text = var.cps + " cps";
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Save();
        }

        public static void Save()
        {
            TextWriter tw = new StreamWriter("SavedGame.txt");

            tw.WriteLine(var.cookies);
            tw.WriteLine(var.cps);
            tw.WriteLine(var.cu);
            tw.WriteLine(var.gr);
            tw.WriteLine(var.fa);
            tw.WriteLine(var.mi);
            tw.WriteLine(var.cuUpgrades);
            tw.WriteLine(var.grUpgrades);
            tw.WriteLine(var.faUpgrades);
            tw.WriteLine(var.miUpgrades);
            tw.WriteLine(var.price);
            tw.WriteLine(var.price1);
            tw.WriteLine(var.price2);
            tw.WriteLine(var.price3);
            tw.WriteLine(var.priceU);
            tw.WriteLine(var.priceU1);
            tw.WriteLine(var.priceU2);
            tw.WriteLine(var.priceU3);

            tw.Close();
        }

        public void label13_Click(object sender, EventArgs e)
        {
            LoadForm1();
            this.cookiesLabel.Text = Math.Floor(var.cookies) + " cookies";
            this.cpsLabel.Text = var.cps + " cps";
            this.grandmaPrice.Text = "" + Math.Ceiling(var.price1);
            this.grandmaAmount.Text = "" + var.gr;
            this.farmPrice.Text = "" + Math.Ceiling(var.price2);
            this.farmAmount.Text = "" + var.fa;
            this.minePrice.Text = "" + Math.Ceiling(var.price3);
            this.mineAmount.Text = "" + var.mi;
            this.cursorPrice.Text = "" + Math.Ceiling(var.price);
            this.cursorAmount.Text = "" + var.cu;
            var.g = 1 + var.cu * var.cuUpgrades;
        }

        public void LoadForm1()
        {
            TextReader tr = new StreamReader("SavedGame.txt");

            var.cookies = Convert.ToDouble(tr.ReadLine());
            var.cps = Convert.ToDouble(tr.ReadLine());
            var.cu = Convert.ToInt32(tr.ReadLine());
            var.gr = Convert.ToInt32(tr.ReadLine());
            var.fa = Convert.ToInt32(tr.ReadLine());
            var.mi = Convert.ToInt32(tr.ReadLine());
            var.cuUpgrades = Convert.ToDouble(tr.ReadLine());
            var.grUpgrades = Convert.ToDouble(tr.ReadLine());
            var.faUpgrades = Convert.ToInt32(tr.ReadLine());
            var.miUpgrades = Convert.ToInt32(tr.ReadLine());
            var.price = Convert.ToDouble(tr.ReadLine());
            var.price1 = Convert.ToDouble(tr.ReadLine());
            var.price2 = Convert.ToDouble(tr.ReadLine());
            var.price3 = Convert.ToDouble(tr.ReadLine());
            var.priceU = Convert.ToDouble(tr.ReadLine());
            var.priceU1 = Convert.ToDouble(tr.ReadLine());
            var.priceU2 = Convert.ToDouble(tr.ReadLine());
            var.priceU3 = Convert.ToDouble(tr.ReadLine());


            tr.Close();
        }
    }
}
