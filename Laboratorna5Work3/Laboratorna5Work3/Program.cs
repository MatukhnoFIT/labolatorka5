using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix.InputMatrix();
            Matrix.Operation();
            Matrix m = new Matrix();
            if (Matrix.OneCount == 3)
            {
                IdentityMatrix id = new IdentityMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    TriangleMethod1 tm1 = new TriangleMethod1();
                }
                else if (Matrix.input == 2)
                {
                    SarrusRule1 sr1 = new SarrusRule1();
                }
            }
            else if (Matrix.ZeroCount == 3)
            {
                UPMatrix um = new UPMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    TriangleMethod2 tm2 = new TriangleMethod2();
                }
                else if (Matrix.input == 2)
                {
                    SarrusRule2 sr2 = new SarrusRule2();
                }
            }
        }
    }
}
