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

            // Внешний цикл по i от startValue1 до stopValue1
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по k от startValue2 до stopValue2
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += Math.Sin(k);
                }
            }

            // Добавляем x/2 для каждого элемента двойной суммы
            // Количество элементов = (stopValue1 - startValue1 + 1) * (stopValue2 - startValue2 + 1)
            int count = (stopValue1 - startValue1 + 1) * (stopValue2 - startValue2 + 1);
            sumSeries += count * (x / 2.0);

            return Math.Round(sumSeries, 3);
        }
    }
}
