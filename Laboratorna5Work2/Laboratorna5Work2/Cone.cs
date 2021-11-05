using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratorna5Work2
{
    class Cone
    {
        public static Point point = new Point();
        public static double S, V, h, r, R, PI = 3.14;
        public static int input = 0;
        public Cone()
        {
            if (input == 1)
            {
                SquareCone();
                VCone();
            }
        }
        private void SquareCone()
        {
            S = PI * point.X * point.X;
            Console.WriteLine("Площадь: " + S);
        }
        private void VCone()
        {
            V = S * point.Y / 3;
            Console.WriteLine("Обьем: " + V);
        }
        public static void Input()
        {
            Console.WriteLine("Введите радиус основы конуса: ");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту конуса: ");
            point.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Радиус конуса: " + point.X);
            Console.WriteLine("Высота конуса: " + point.Y);
        }
    }
}
