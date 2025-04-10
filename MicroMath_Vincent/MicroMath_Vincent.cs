using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMath_Vincent
{
    public class MicroMath_Vincent
    {
        /// <summary>
        /// Lægger to tal sammen
        /// </summary>
        /// <param name="a">Tal 1</param>
        /// <param name="b">Tal 2</param>
        /// <returns>Int: Sum af tal</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add3Numbers(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
