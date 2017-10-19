using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookie_clicker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cursorUPrice.Text = "" + Math.Ceiling(var.priceU);
            grandemaUPrice.Text = "" + Math.Ceiling(var.priceU1);
            farmUPrice.Text = "" + Math.Ceiling(var.priceU2);
            mineUPrice.Text = "" + Math.Ceiling(var.priceU3);
        }

        private void CursorUpgrade_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.priceU)
            {
                var.cuUpgrades += 0.5;
                var.cookies -= var.priceU;
                var.g = 1 + var.cu * var.cuUpgrades;
                var.priceU = var.priceU * 1.2;
                cursorUPrice.Text = "" + Math.Ceiling(var.priceU);
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.priceU1)
            {
                var.grUpgrades += 0.1;
                var.cookies -= var.priceU1;
                var.cps = var.gr * var.grUpgrades + var.fa * var.faUpgrades + var.mi * var.miUpgrades;
                var.priceU1 = var.priceU1 * 1.2;
                grandemaUPrice.Text = "" + Math.Ceiling(var.priceU1);
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.priceU2)
            {
                var.faUpgrades++;
                var.cookies -= var.priceU2;
                var.cps = var.gr * var.grUpgrades + var.fa * var.faUpgrades + var.mi * var.miUpgrades;
                var.priceU2 = var.priceU2 * 1.2;
                farmUPrice.Text = "" + Math.Ceiling(var.priceU2);
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (var.cookies >= var.priceU3)
            {
                var.miUpgrades += 5;
                var.cookies -= var.priceU3;
                var.cps = var.gr * var.grUpgrades + var.fa * var.faUpgrades + var.mi * var.miUpgrades;
                var.priceU3 = var.priceU3 * 1.2;
                mineUPrice.Text = "" + Math.Ceiling(var.priceU3);
            }
            else
            {
                MessageBox.Show("You dont have enough cookies");
            }
        }

        public void LoadForm2()
        {
            this.cursorUPrice.Text = "" + Math.Ceiling(var.priceU);
            this.grandemaUPrice.Text = "" + Math.Ceiling(var.priceU1);
            this.farmUPrice.Text = "" + Math.Ceiling(var.priceU2);
            this.mineUPrice.Text = "" + Math.Ceiling(var.priceU3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.LoadForm2();
        }
    }
}
