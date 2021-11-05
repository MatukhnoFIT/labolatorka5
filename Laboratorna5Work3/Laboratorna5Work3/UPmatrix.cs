using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class UPMatrix : Matrix
    {
        public UPMatrix()
        {
            Inputter();
        }
        public void Inputter()
        {
            Console.WriteLine("Выберите способ просчёта определителя матрицы: ");
            Console.WriteLine("Введите '1', если методом 'треугольника', введите '2' - если методом Саррюса");
            input = Convert.ToInt32(Console.ReadLine());
        }
    }
}
