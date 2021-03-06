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

            var minimum = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (minimum > array[i])
                {
                    minimum = array[i];
                }
            }

            return minimum;
        }

        public int Maximum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            var maximum = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }

        public int Length(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }

            return array.Length;
        }

        public double Average(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            var sum = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }
    }
}
