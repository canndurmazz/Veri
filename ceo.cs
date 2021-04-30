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
    public partial class ceo : Form
    {
        public ceo()
        {
            InitializeComponent();
        }

        private void ceo_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ceosifre ceosifre = new ceosifre();
            ceosifre.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Silver;
            üstpanel.BackColor = Color.Silver;
         }

        private void button17_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

      
      

        private void button1_Click(object sender, EventArgs e)
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

        private void button23_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.LightGray; 
            üstpanel.BackColor = Color.LightGray; 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.DimGray;
            üstpanel.BackColor = Color.DimGray;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solpanel.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kösepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            {
                // Minimize Butonu
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            {
                // Maximize Butonu
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;

                else
                    this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void üstpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
