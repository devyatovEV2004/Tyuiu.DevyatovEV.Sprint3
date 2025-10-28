using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevyatovEV.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(value, 2 * k) + (1.0 / (k + 1))) * Math.Cos(value);
                sumSeries += term;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}