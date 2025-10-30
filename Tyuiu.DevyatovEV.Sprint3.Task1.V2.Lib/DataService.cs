using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevyatovEV.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sumSeries += Math.Sin(i) * 0.5;
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}