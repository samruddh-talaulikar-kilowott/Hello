using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Stats
    {

        internal int[] Numbers { private get; set; }
        public decimal Mean()
        {
            int sum = 0;
            decimal mean = 0;
            //MEAN CALCULATION
            foreach (int test in Numbers)
            {
                sum = sum + test;
            }
            mean = (decimal)sum / Numbers.Length;
            return mean;
        }
        public int Median()
        {
            //MEDIAN CALCULATION
            Array.Sort(Numbers);
            int m = (Numbers.Length) / 2;
            int n = Numbers[m];
            return n;
        }
        public int Mode()
        {
            //MODE CALCULATION
            int maxcount = 0, maxnum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = Numbers[i];
                }
            }
            return maxnum;
        }
    }
}
