using Tyuiu.PiskulinIY.Sprint2.Task5.V11.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task5.V11
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

            string res;

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 12 || m < 1)
            {
                res = "Неверно введен номер месяца";

                Console.WriteLine("Введите день:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 31 || n < 1)
                {
                    res = "Неверно введен номер месяца и неверно введен день";
                }

            }

            else
            {
                Console.WriteLine("Введите день:");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 31 || n < 1)
                {
                    res = "Неверно введен номер месяца и неверно введен день";
                }
                else
                {
                    res = "Следующий день: " + ds.FindDateOfNextDay(g, m, n);
                }
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
