using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class SarrusRule1 : IdentityMatrix
    {
        public SarrusRule1()
        {
            SarrusCount();
        }
        public static void SarrusCount()
        {
            det1 = matrix[0] * matrix[4] * matrix[8] + matrix[1] * matrix[5] * matrix[6] + matrix[2] * matrix[3] * matrix[7];
            det2 = matrix[2] * matrix[4] * matrix[6] + matrix[0] * matrix[5] * matrix[7] + matrix[1] * matrix[3] * matrix[8];
            det = det1 - det2;
            Console.WriteLine("det = " + matrix[0] + "*" + matrix[4] + "*" + matrix[8] + "+" + matrix[1] + "*" + matrix[5] + "*" + matrix[6] + "+" + matrix[2] + "*" + matrix[3] + "*" + matrix[7] + "-");
            Console.WriteLine("-" + matrix[2] + "*" + matrix[4] + "*" + matrix[6] + "-" + matrix[0] + "*" + matrix[5] + "*" + matrix[7] + "-" + matrix[1] + "*" + matrix[3] + "*" + matrix[8]);
            Console.WriteLine("det = " + det);
        }
    }
}
