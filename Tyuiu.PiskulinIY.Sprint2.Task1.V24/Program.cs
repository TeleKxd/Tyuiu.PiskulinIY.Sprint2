using Tyuiu.PiskulinIY.Sprint2.Task1.V24.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность, *");
            Console.WriteLine("* (массив): (True, False, True, False, True, False)                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 325, b = 325, c = 242, d = 324                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)

            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
