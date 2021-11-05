using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1, для расчёта обычного конуса, и 2 - для усеченного");
            Cone.input = Convert.ToInt32(Console.ReadLine());
            if (Cone.input == 1)
            {
                Cone.Input();
                Cone cone = new Cone();
            }
            else if (Cone.input == 2)
            {
                Conoid.Input1();
                Conoid conoid = new Conoid();
            }
        }
    }
}
