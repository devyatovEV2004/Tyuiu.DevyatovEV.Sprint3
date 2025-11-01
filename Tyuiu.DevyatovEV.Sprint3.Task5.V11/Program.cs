using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint3.Task5.V11.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Деватьов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Деватьов Е.В. | ИСТНб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму сумм ряда:                                             *");
            Console.WriteLine("*     3     10                                                            *");
            Console.WriteLine("* y = ∑    ∑   (sin(k) + x/2)                                            *");
            Console.WriteLine("*    i=1   k=1                                                           *");
            Console.WriteLine("* при x = 5                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага внешней суммы = {startValue1}");
            Console.WriteLine($"Конец шага внешней суммы = {stopValue1}");
            Console.WriteLine($"Старт шага внутренней суммы = {startValue2}");
            Console.WriteLine($"Конец шага внутренней суммы = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Сумма сумм ряда = {res}");

            Console.ReadKey();
        }
    }
}