using System;
namespace lab8
{
    public class Operations
    {
        /// <summary>
        /// метод суммирования
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double plus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// метод вычитания
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double minus(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// метод деления
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double div(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// метод умножения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double mul(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// метод вычиследния корня квадратного
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double root(double a)
        {
            return Math.Sqrt(a);
        }
        /// <summary>
        /// метод вычисления квадрата числа
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double square(double a)
        {
            return a * a;
        }
        /// <summary>
        /// метод вычисления синуса
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double sin(double a)
        {
            return Math.Sin((a * Math.PI) / 180); ;
        }
        /// <summary>
        /// метод вычисления синуса
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double cos(double a)
        {
            return Math.Cos((a * Math.PI) / 180);
        }
        /// <summary>
        /// метод вычисления частного еденицы и икса
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double one_div_x(double a)
        {
            return 1 / a;
        }
        /// <summary>
        /// метод вычисления факториала
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double fact(double a)
        {
            if (a == 0) return 1;
            else
            {
                if (a < 0) return a * fact(a + 1);
                else return a * fact(a - 1);
            }
        }
    }
}
