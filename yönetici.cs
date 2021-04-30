using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıProje
{
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            yöneticisifre yöneticisifre = new yöneticisifre();
            yöneticisifre.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            {
                // Maximize Butonu
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;

                else
                    this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            {
                // Minimize Butonu
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Silver;
            üstpanel.BackColor = Color.Silver;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            solpanel.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.DarkGray;
            üstpanel.BackColor = Color.DarkGray;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.DarkGray;
            üstpanel.BackColor = Color.DarkGray;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button25_Click(object sender, EventArgs e)
        {

            solpanel.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.DimGray;
            üstpanel.BackColor = Color.DimGray;
        }

        private void yönetici_Load(object sender, EventArgs e)
        {

        }
    }
}
