using Tyuiu.PiskulinIY.Sprint2.Task6.V13.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит            *");
            Console.WriteLine("* значение переменных X,Y с клавиатуры. Округлить ответ до                *");
            Console.WriteLine("* трех знаков после запятой;                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите год   ");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
