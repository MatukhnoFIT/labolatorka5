using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class Matrix
    {
        public static int n = 1, OneCount = 0, ZeroCount = 0, StringsCount = 0, input = 0, det1 = 0, det2 = 0, det = 0, number1 = 0, number2 = 0, ZeroCount2 = 0;
        public static int[] matrix = new int[9];
        public static void InputMatrix()
        {
            Console.WriteLine("Введите поэлементно матрицу: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Введите елемент № " + n);
                matrix[i] = Convert.ToInt32(Console.ReadLine());
                if (matrix[i] == 0)
                {
                    ZeroCount2++;
                }
                if (n == 1 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 5 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 9 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 4 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                if (n == 7 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                if (n == 8 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                n++;
            }
        }
        public static void Input()
        {
            Console.WriteLine("Выберите способ просчёта определителя матрицы: ");
            Console.WriteLine("Введите '1', если методом 'треугольника', введите '2' - если методом Саррюса");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public static void Operation()
        {
            number1 = OneCount;
            number2 = ZeroCount;
            if (number1 == 3 && ZeroCount2 == 6)
            {
                Console.WriteLine("Вы ввели одиничную матрицу");
                number1 = 10;
            }
            if (number2 == 3)
            {
                Console.WriteLine("Вы ввели верхнюю треугольную матрицу");
                number2 = 10;
            }
            else if (number1 != 3 && number2 != 3)
            {
                if (number1 == 10 || number2 == 10)
                {
                    number1 = 10;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Вы ввели стандартную матрицу");
                    Console.WriteLine("");
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                StringsCount++;
                if (StringsCount == 3)
                {
                    Console.Write(" " + matrix[i] + " ");
                    Console.WriteLine("");
                    StringsCount = 0;
                }
                else
                {
                    Console.Write(" " + matrix[i] + " ");
                }
            }
        }
    }
}
