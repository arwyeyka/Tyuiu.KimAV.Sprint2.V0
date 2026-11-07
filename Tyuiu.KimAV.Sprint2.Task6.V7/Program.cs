using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint2.Task6.V7.Lib;
namespace Tyuiu.KimAV.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт №2 | Выполнил: Ким А.В. | ИИПБ-25-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт # 2                                                                                             *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                            *");
            Console.WriteLine("* Задание 6                                                                                             *");
            Console.WriteLine("* Вариант 7                                                                                             *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПБ-25-1                                                           *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат.*");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindMonthName(numMonth);
            }
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
