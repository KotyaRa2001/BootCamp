using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public Form2(string windowTitle, string message)
        {
            InitializeComponent();
            this.Text = windowTitle;
            lblMessage.Text = message;
        }

        public static string Show(string windowTitle, string message)
        {
            using (Form2 inputDlg =
            new Form2(windowTitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.txtInput.Text;
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
