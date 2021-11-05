using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratorna5Work1
{
    class RotateSquare : MoveSquare
    {
        public static Point p = new Point();
        public RotateSquare()
        {
            if (RemoveOrRotate == 2)
            {
                RectangleInfo();
                Console.WriteLine("Нажмите стрелку вправо - чтобы перевернуть квадрат вправо, или стрелку влево - чтобы перевернуть влево");
            }
            while (RemoveOrRotate == 2)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    p = leftUp;
                    leftUp = leftDown;
                    leftDown = rightDown;
                    rightDown = rightUp;
                    rightUp = p;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    p = leftDown;
                    leftDown = leftUp;
                    leftUp = rightUp;
                    rightUp = rightDown;
                    rightDown = p;
                    Display();
                }
            }
        }
    }
}
