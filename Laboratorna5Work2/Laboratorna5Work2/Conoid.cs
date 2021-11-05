using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work2
{
    class Conoid : Cone
    {
        public Conoid()
        {
            VConoid();
        }
        private void VConoid()
        {
            V = PI * h * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2) / 3);
            Console.WriteLine("Обьем срезанного конуса: " + V);
        }
        public static void Input1()
        {
            Console.WriteLine("Введите высоту конуса: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус большей основы конуса: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус меньшей основы конуса: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Высота конуса: " + h);
            Console.WriteLine("Радиус большей основы: " + R);
            Console.WriteLine("Радиус меньшей основы: " + r);
        }
    }
}
