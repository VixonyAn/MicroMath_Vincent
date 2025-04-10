using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMath_Vincent
{
    public class MicroMath_Vincent
    {
        //Added a comment locally in featureJA


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
        /// <summary>
        /// Add three numbers
        /// </summary>
        /// <param name="t1">Fist number</param>
        /// <param name="t2">Second number</param>
        /// <param name="t3">Third number</param>
        /// <returns>Int: Sum af tal</returns>
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
