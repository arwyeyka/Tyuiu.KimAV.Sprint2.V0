using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint2.Task3.V24.Lib;
namespace Tyuiu.KimAV.Sprint2.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №0 | Выполнил: Ким А.В. | ИИПБ-25-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт # 2                                                                                             *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                            *");
            Console.WriteLine("* Задание 3                                                                                              *");
            Console.WriteLine("* Вариант 24                                                                                             *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПБ-25-1                                                           *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y                                     *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры.*");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой;                                            *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("Введите значение переменной x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();

        }
    }
}
