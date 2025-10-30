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

            Console.Title = "Спринт #3 | Выполнил: Девятов Е.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму двойного ряда:                                         *");
            Console.WriteLine("*     3    10                                                             *");
            Console.WriteLine("* y = ∑   ∑  [sin(k) + x/2]  при x = 5                                   *");
            Console.WriteLine("*    i=1  k=1                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите переменную x: ");
            int vaule = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите нижний 1 предел: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите нижний 2 предел: ");
            int start2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1 конечный предел: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 конечный предел: ");
            int end2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(vaule, start, start2, end, end2));
            Console.ReadKey();
        }
    }
}