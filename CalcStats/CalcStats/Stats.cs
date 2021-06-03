using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    public class Stats
    {
        public int Minimum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            return 0;
        }

        public int Maximum(int[] array)
        {
            return 0;
        }

        public int Length(int[] array)
        {
            return 0;
        }

        public double Average(int[] array)
        {
            return 0;
        }
    }
}
