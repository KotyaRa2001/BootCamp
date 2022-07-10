using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
            label2.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хм, а зачем ты нажал на меня то?",
                "А ЗАЧЕМ?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            this.Close();
        }
    }
}
