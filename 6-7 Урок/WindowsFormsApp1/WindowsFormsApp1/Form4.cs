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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String FullName, Number;
            FullName = textBox1.Text;
            Number = textBox2.Text;
            listBox1.Items.Add(FullName + " " + Number);
        }

        private bool isNumber = false;


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if ((letter < 'А' || letter > 'Я') && (letter < 'а' || letter > 'я') && letter != '\b' && letter != ' ' && letter != '.')
            {
                e.Handled = true;
            }

        }



        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 // keyboard - основная клавиатура
            || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 //keypad - дополнительная клавиатура
            || e.KeyCode == Keys.Back;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;// Явное преобразование типов

            switch (e.KeyChar) // Переключатель
            {
                case '+': // Разрешаем минус, если он первый
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '1': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '2': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '3': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '4': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '5': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '6': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '7': // Разрешаем 7, если она вторая
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '8': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '9': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
                case '0': // Запрет на 1, если она первый
                    if (box.Text.Length == 0)
                        isNumber = false;
                    break;
            }
            // Запрещаем в текстовом поле лишние символы
            if (!isNumber)
                e.Handled = true;

            if (box.Text.Length == 12)
            {
                this.textBox2.ReadOnly = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
