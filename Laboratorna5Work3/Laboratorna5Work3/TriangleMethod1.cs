using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class TriangleMethod1 : IdentityMatrix
    {
        public TriangleMethod1()
        {
            TriangleCount();
        }
        public static void TriangleCount()
        {
            det1 = matrix[0] * matrix[4] * matrix[8] + matrix[2] * matrix[3] * matrix[7] + matrix[1] * matrix[5] * matrix[6];
            det2 = matrix[2] * matrix[4] * matrix[6] + matrix[1] * matrix[3] * matrix[8] + matrix[0] * matrix[5] * matrix[7];
            det = det1 - det2;
            Console.WriteLine("det = " + matrix[0] + "*" + matrix[4] + "*" + matrix[8] + "+" + matrix[2] + "*" + matrix[3] + "*" + matrix[7] + "+" + matrix[1] + "*" + matrix[5] + "*" + matrix[6] + "-");
            Console.WriteLine("-" + matrix[2] + "*" + matrix[4] + "*" + matrix[6] + "-" + matrix[1] + "*" + matrix[3] + "*" + matrix[8] + "-" + matrix[0] + "*" + matrix[5] + "*" + matrix[7]);
            Console.WriteLine("det = " + det);
        }
    }
}
