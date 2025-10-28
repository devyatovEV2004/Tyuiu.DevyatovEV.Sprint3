using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevyatovEV.Sprint3.Task0.V29.Lib
{
    public class DataService
    {
        public double GetSumSeries(double t)
        {
            double sumSeries = 0;
            int startValue = 1;
            int stopValue = 10;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(t, 2 * k) + (1.0 / (k + 1))) * Math.Cos(t);
                sumSeries += term;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}