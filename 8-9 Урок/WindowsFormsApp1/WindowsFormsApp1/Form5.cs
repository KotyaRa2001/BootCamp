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
    public partial class Form5 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 File| *.mp3";
                if ( ofd.ShowDialog() == DialogResult.OK )
                {
                    mp3Player.open(ofd.FileName);
                    label1.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.SafeFileName);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3Player.stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

