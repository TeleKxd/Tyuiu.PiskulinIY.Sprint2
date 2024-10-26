using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.PiskulinIY.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int g1 = 0;
            int m1 = 0;
            int n1 = 0;

            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 2:
                    switch (n)
                    {
                        case 28:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 3:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 4:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 5:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 6:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 7:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 8:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 9:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 10:
                    switch (n)
                    {
                        case 31:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 11:
                    switch (n)
                    {
                        case 30:
                            g1 = g;
                            m1 = m + 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;

                case 12:
                    switch (n)
                    {
                        case 31:
                            g1 = g + 1;
                            m1 = 1;
                            n1 = 1;
                            break;
                        default:
                            g1 = g;
                            m1 = m;
                            n1 = n + 1;
                            break;
                    }
                    break;
            }
            return $"{n1.ToString("00")}.{m1.ToString("00")}.{g1}";
        }
    }
}
