using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool c1 = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);
bool c2 = (y >= x / 2);
bool c3 = (y <= 0);
bool c4 = (x <= 0);
bool c5 = (y >= 0);
return (c1 & c2 & (c5 | c3)) | (c1 & c4 & c2);
        }
    }
}
