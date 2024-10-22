﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PiskulinIY.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0) 
            {
                y = x*Math.Pow(((x+1)/(Math.Sin(Math.Pow(x, 2))+x-0.5)), x);
            }
            else 
            {
                if (x == 0) 
                {
                   y = (Math.Pow(x,2)-Math.Cos(Math.Pow(x, 2))+4)/(Math.Pow(x,2)-Math.Sin(Math.Pow(x, 2))+12);
                }

                else 
                {
                    if ((x < 0) && (x > -31)) 
                    {
                        Math.Pow(1 + (1 / (Math.Pow(x, 2))), 2);
                    }
                    else 
                    { 
                        if (x < -31) 
                        {
                            y = x+Math.Sin(Math.Pow(x,3))-(2/x);
                        }
                    }       
                }
            }

            return Math.Round(y, 3);
        }
    }
}
