﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PiskulinIY.Sprint2.Task4.V10.Lib
{
    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            double z = x * 2 < y / 3 ? (1 + (3 / Math.Pow(y, 2))) : (y + 10 * x - ((5 / x)));
            return Math.Round(z, 3);
        }
    }
}