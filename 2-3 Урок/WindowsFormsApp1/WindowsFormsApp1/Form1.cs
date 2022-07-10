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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string password = Form2.Show(
                "Аутентификация пользователя",
                "Введите Ваш пароль:");
                if (password != "12345")// Плохой способ хранения пароля
                {
                    MessageBox.Show(
                    "Извините, но Вам не разрешено\n" // Сообщение
                    + "пользоваться этой суперпрограммой!!!",
                    "Неверный пароль", // Заголовок окна
                    MessageBoxButtons.OK, // Кнопка OK
                    MessageBoxIcon.Stop);// Критическая иконка
                    this.Close();
                }
            }


        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
