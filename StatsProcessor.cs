using System.Linq;

namespace FirstConsoleApp
{
    /// <summary>
    /// This class will perform some basic statistics calculations
    /// </summary>
    /// 
    internal class StatsProcessor
    {
        // data set that is provided to the object is encapsulatd
        internal int[] Numbers { private get; set; }

        internal StatsResult GetStatsProcessorResult()
        {
            var result = new StatsResult();
            result.Mean = CalculateMean();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }




        private decimal CalculateMean()
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







        private int CalculateMedian()
        {
            //MEDIAN CALCULATION
            Array.Sort(Numbers);
            int m = (Numbers.Length) / 2;
            int n = Numbers[m];
            return n;
        }






        private int CalculateMode()
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
