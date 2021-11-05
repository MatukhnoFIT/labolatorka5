using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratorna5Work1
{
    class MoveSquare
    {
        public static int x, y, length, RemoveOrRotate;
        public static Rectangle rect = new Rectangle();
        public static Point leftUp = new Point();
        public static Point leftDown = new Point();
        public static Point rightUp = new Point();
        public static Point rightDown = new Point();
        public MoveSquare()
        {
            if (RemoveOrRotate == 1)
            {
                RectangleInfo();
                Console.WriteLine("Нажмите стрелку вправо - чтобы передвинуть квадрат вправо, или стрелку влево - чтобы передвинуть влево");
            }
            while (RemoveOrRotate == 1)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    leftUp.X++;
                    leftDown.X++;
                    rightUp.X++;
                    rightDown.X++;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    Move();
                }
            }
        }
        public static void Input()
        {
            Console.WriteLine("Введите верхний левый угол квадрата (координаты), и его длинну");
            Console.WriteLine("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длинна: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите '1', если хотите передвинуть квадрат, введите '2', если хотите вращать");
            RemoveOrRotate = Convert.ToInt32(Console.ReadLine());
        }
        private void Move()
        {
            leftUp.X--;
            leftDown.X--;
            rightUp.X--;
            rightDown.X--;
            Display();
        }
        protected void RectangleInfo()
        {
            leftUp.X = x;
            leftUp.Y = y;
            leftDown.X = x;
            leftDown.Y = y - length;
            rightUp.X = x + length;
            rightUp.Y = y;
            rightDown.X = x + length;
            rightDown.Y = y - length;
            rect.X = leftUp.X;
            rect.Y = leftUp.Y;
            rect.Width = length;
            rect.Height = length;
            Display();
            Console.WriteLine("Параметры квадрата: " + rect);
        }
        protected void Display()
        {
            Console.WriteLine("");
            Console.WriteLine("Координаты верхнего левого угла: " + leftUp);
            Console.WriteLine("Координаты нижнего левого угла: " + leftDown);
            Console.WriteLine("Координаты верхнего правого угла: " + rightUp);
            Console.WriteLine("Координаты нижнего правого угла: " + rightDown);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
