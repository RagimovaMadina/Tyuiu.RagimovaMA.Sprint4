using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RagimovaMA.Sprint4.Task1.V10.Lib;

namespace Tyuiu.RagimovaMA.Sprint4.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Рагимова М. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Рагимова Мадина Абдулакимовна | СМАРТб-23-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.  С клавиатуры:                              *");
            Console.WriteLine("* 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arr = new int[11];

            Console.WriteLine("* Введите элементы:                                                       *");
            string str = Console.ReadLine();
            string[] strarr = str.Split(' ');
            for (int i = 0; i < strarr.Length; i++)
            {
                arr[i] = int.Parse(strarr[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(resp.Calculate(arr));
            Console.ReadLine();

        }
    }
}
