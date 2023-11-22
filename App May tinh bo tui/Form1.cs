using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_May_tinh_bo_tui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void num1_Click(object sender, EventArgs e)
        {
            if (Ketqua.Text == "0")
                Ketqua.Text = "1";
            else
                Ketqua.Text = Ketqua.Text + "1";
        }
        private void num2_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "2";
            else
                Ketqua.Text = Ketqua.Text + "2";
        }
        private void num3_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "3";
            else
                Ketqua.Text = Ketqua.Text + "3";
        }
        private void num4_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "4";
            else
                Ketqua.Text = Ketqua.Text + "4";
        }
        private void num5_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "5";
            else
                Ketqua.Text = Ketqua.Text + "5";
        }
        private void num6_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "6";
            else
                Ketqua.Text = Ketqua.Text + "6";
        }
        private void num7_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "7";
            else
                Ketqua.Text = Ketqua.Text + "7";
        }
        private void num8_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "0")
                Ketqua.Text = "8";
            else
                Ketqua.Text = Ketqua.Text + "8";
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (Ketqua.Text == "0")
                Ketqua.Text = "9";
            else
                Ketqua.Text = Ketqua.Text + "9";
        }
        private void num0_Click(object sender, EventArgs e)
        {

            if (Ketqua.Text == "")
                Ketqua.Text = "";
            else
                Ketqua.Text = Ketqua.Text + "0";
        }
        private void symCE_Click(object sender, EventArgs e)
        {
            Ketqua.Text = "0";
        }
        private void symC_Click(object sender, EventArgs e)
        {
            Ketqua.Text = "";
        }

        private void symXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
