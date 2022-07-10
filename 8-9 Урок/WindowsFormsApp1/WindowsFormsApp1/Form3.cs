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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private bool isNumber = false;

        private void txtFirst_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            isNumber =
            e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 // keyboard - основная клавиатура
            || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 //keypad - дополнительная клавиатура
            || e.KeyCode == Keys.Back;
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;// Явное преобразование типов

            switch (e.KeyChar) // Переключатель
            {
                case '-': // Разрешаем минус, если он первый
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    // Точка не должна быть первой
                    if (box.Text.Length == 0)
                        break;
                    // Точка не должна следовать сразу за минусом
                    if (box.Text[0] == '-' && box.Text.Length == 1)
                        break;
                    // Точка должна быть одна
                    if (box.Text.IndexOf('.') == -1)
                        isNumber = true; // Еще не было точек
                    break;
            }
            // Запрещаем в текстовом поле лишние символы
            if (!isNumber)
                e.Handled = true;
        }

        // Объявляем числовые переменные как поля-члены класса
        // Их можно объявить как локальные и внутри обработчика btn_Click()
        // Но оставляем область видимости класс, вдруг где-нибудь еще пригодятся!
        private double numFirst, numSecond, numRes;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Один обработчик для всех кнопок-операций
        private void btn_Click(object sender, EventArgs e)
        {
            // Копируем текстовые поля в локальные переменные
            string strFirst = string.Copy(txtFirst.Text);
            string strSecond = string.Copy(txtSecond.Text);

            // Замена в строке точки символом запятой

            // для корректного преобразования в число
            int pos = strFirst.IndexOf('.');
            if (pos != -1)
            {
                strFirst = strFirst.Substring(0, pos)
                + ','
                + strFirst.Substring(pos + 1);
            }

            pos = strSecond.IndexOf('.');
            if (pos != -1)
            {
                strSecond = strSecond.Substring(0, pos)
                + ','
                + strSecond.Substring(pos + 1);
            }

            // Преобразуем текст в число для выполнения операций
            if (txtFirst.Text.Length > 0)
                numFirst = Convert.ToDouble(strFirst);
            else
                numFirst = 0.0D;
            if (txtSecond.Text.Length > 0)
                numSecond = Convert.ToDouble(strSecond);
            else
                numSecond = 0.0D;
            
            
            // Выполняем нужную операцию
            string btnText = "";// Создали строковую переменную
            bool divideFlag = false;// Флаг деления на ноль
            Button btn = (Button)sender;// Явное приведение типов для распознавания кнопок
            switch (btn.Name)// Переключатель
            {
                case "btnIncrement":// Операция сложения
                    btnText = "\"+\"";// Экраны кавычек
                    numRes = numFirst + numSecond;
                    lblShowResult.Text = numRes.ToString();
                    break;
                case "btnDecrement":// Операция вычитания
                    btnText = "\"-\"";// Экраны кавычек
                    numRes = numFirst - numSecond;
                    lblShowResult.Text = numRes.ToString();
                    break;
                case "btnIncrease":// Операция умножения
                    btnText = "\"*\"";// Экраны кавычек
                    numRes = numFirst * numSecond;
                    lblShowResult.Text = numRes.ToString();
                    break;
                case "btnDivide":// Операция деления
                    btnText = "\":\"";// Экраны кавычек
                                      // Проверяем корректность деления
                    if (Math.Abs(numSecond) < 1.0E-30)
                    {
                        MessageBox.Show(
                        "Делить на ноль нельзя!", // Сообщение
                        "Ошибка", // Заголовок окна
                        MessageBoxButtons.OK, // Кнопка OK
                        MessageBoxIcon.Stop);// Критическая иконка
                        divideFlag = true;
                    }
                    else
                        numRes = numFirst / numSecond;
                    lblShowResult.Text = numRes.ToString();
                    break;
            }
            // Для отображения в панели Output режима Debug
            System.Diagnostics.Debug.WriteLine("Нажата кнопка " + btnText);// Конкатенация
            // Отображение результата
            if (!divideFlag)
            {
                lblShowResult.Text = Convert.ToString(numRes);
                this.Validate(); // Обновить экран (можно убрать-излишне)
            }


        }
    }
}
