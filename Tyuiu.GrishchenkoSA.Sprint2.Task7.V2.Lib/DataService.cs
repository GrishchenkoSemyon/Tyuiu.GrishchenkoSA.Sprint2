using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool condition1 = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);
bool condition2 = (y >= 0);
bool condition3 = (y >= x / 2);
bool condition4 = (x >= 0);
return (condition1 && condition2 && condition3) || (condition1 && !condition4 && y <= 0 && y >= x / 2);
        }
    }
}
