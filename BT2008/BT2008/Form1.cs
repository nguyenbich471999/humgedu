using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2008
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNhapso.Text);
            txtDayvuanhap.Text += x.ToString() + " ";
            if (x % 2 == 0)
            {
                tongchan += x;
                txtTongChan.Text = tongchan.ToString();
            }
            else
            {
                tongle += x;
                txtTongLe.Text = tongle.ToString();
            }

            tongdayso += x;
            txtTongCacPT.Text = tongdayso.ToString();

            txtNhapso.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDayvuanhap.Text = "";
            txtTongCacPT.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            tongchan = 0;
            tongle = 0;
            tongdayso = 0;
        }
        int tongchan = 0, tongle = 0, tongdayso = 0;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
