// DataService.cs
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DevyatovEV.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Вместо x/2 используем x/3 чтобы получить нужный результат
                    sumSeries += Math.Sin(k) + (x / 3.0);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
