using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace lab8
{
    public partial class MainWindow : Window
    {
        private double a, b, c;
        string operation;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// обработчик события нажатия на цифру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_digit_Click(object sender, RoutedEventArgs e)
        {
            if (textbox_main.Text == "0")
            {
                textbox_main.Text = (string)(sender as Button).Content;
                return;
            }
            textbox_main.Text += (sender as Button).Content;
        }
        /// <summary>
        /// обработчик события нажатия очистку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textbox_main.Clear();
        }
        /// <summary>
        /// обработчик события изменения текста в textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_main_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox_main.Text == "") textbox_main.Text = "0";
            if ((Convert.ToDouble(textbox_main.Text) > 4000000) || (Convert.ToDouble(textbox_main.Text) < -2000000))
            {
                MessageBox.Show("Границы чисел - от -2000000 до 4000000", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                textbox_main.Text = textbox_main.Text.Substring(0, textbox_main.Text.Length - 1);
            }
            if(textbox_main.Text.Contains(','))
            {
                if ((textbox_main.Text.Length - textbox_main.Text.IndexOf(',')) > 4)
                {
                    textbox_main.Text = textbox_main.Text.Substring(0, textbox_main.Text.IndexOf(',') + 5);
                }
            }
        }
        /// <summary>
        /// обработчик события нажатия удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            textbox_main.Text = textbox_main.Text.Substring(0, textbox_main.Text.Length - 1);
        }
        /// <summary>
        /// обработчик события нажатия на ноль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(textbox_main.Text) != 0) textbox_main.Text += (sender as Button).Content;
            if (textbox_main.Text.Contains(',')) textbox_main.Text += (sender as Button).Content;
        }
        /// <summary>
        /// обработчик события нажатия разделитель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_point_Click(object sender, RoutedEventArgs e)
        {
            if (!textbox_main.Text.Contains(',')) textbox_main.Text += (sender as Button).Content;
        }
        /// <summary>
        /// обработчик события нажатия умножение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_mul_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox_main.Text);
            textbox_main.Clear();
            operation = "*";
        }
        /// <summary>
        /// обработчик события нажатия вычитания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_minus_Click(object sender, RoutedEventArgs e)
        { 
            a = Convert.ToDouble(textbox_main.Text);
            textbox_main.Clear();
            operation = "-";
        }
        /// <summary>
        /// обработчик события нажатия деления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox_main.Text);
            textbox_main.Clear();
            operation = "/";
        }
        /// <summary>
        /// обработчик события нажатия корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_root_Click(object sender, RoutedEventArgs e)
        {
            c = Operations.root(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия квадрата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_square_Click(object sender, RoutedEventArgs e)
        {
            c = Operations.square(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия синуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sin_Click(object sender, RoutedEventArgs e)
        {
            c = Operations.sin(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия косинуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_cos_Click(object sender, RoutedEventArgs e)
        {
            c = Operations.cos(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия еденицы деленной на икс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_1_div_x_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToDouble(textbox_main.Text) == 0)
            {
                MessageBox.Show("На ноль делить нельзя!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            c = Operations.one_div_x(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия факториала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fact_Click(object sender, RoutedEventArgs e)
        {
            if(textbox_main.Text.Contains(','))
            {
                MessageBox.Show("Введите целое число!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            c = Operations.fact(Convert.ToDouble(textbox_main.Text));
            textbox_main.Text = c.ToString("G5");
        }
        /// <summary>
        /// обработчик события нажатия равно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_equal_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(textbox_main.Text);
            switch(operation)
            {
                case "+":
                    c = Operations.plus(a, b);
                    textbox_main.Text = c.ToString("G5");
                    break;
                case "-":
                    c = Operations.minus(a, b);
                    textbox_main.Text = c.ToString("G5");
                    break;
                case "/":
                    if(b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    c = Operations.div(a, b);
                    textbox_main.Text = c.ToString("G5");
                    break;
                case "*":
                    c = Operations.mul(a, b);
                    textbox_main.Text = c.ToString("G5");
                    break;
            }
        }
        /// <summary>
        /// обработчик события нажатия обратного знака
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sign_Click(object sender, RoutedEventArgs e)
        {
            textbox_main.Text = Convert.ToString(Convert.ToDouble(textbox_main.Text) * -1);
        }
        /// <summary>
        /// обработчик события нажатия сложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textbox_main.Text);
            textbox_main.Clear();
            operation = "+";
        }
    }
}
