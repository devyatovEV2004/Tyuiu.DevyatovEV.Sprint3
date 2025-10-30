using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevyatovEV.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i = startValue;

            do
            {
                multiplySeries *= (Math.Pow(value, 2) + i) + 2;
                i++;
            }
            while (i <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}