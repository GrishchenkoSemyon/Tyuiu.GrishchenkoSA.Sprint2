using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res1 = (x >= 2) & (x <= 4) & (y >= 3) & (y <= 5);
bool res2 = (x >= 8) & (x <= 8) & (y >= 3) & (y <= 4);
bool res3 = (x >= 11) & (x <= 13) & (y >= 3) & (y <= 5);
bool res4 = (x >= 2) & (x <= 13) & (y >= 5) & (y <= 10);
bool res5 = (x >= 8) & (x <= 11) & (y >= 6) & (y <= 10);
bool res6 = (x >= 3) & (x <= 3) & (y >= 11) & (y <= 11);
bool res7 = (x >= 6) & (x <= 11) & (y >= 11) & (y <= 12);
bool res8 = (x >= 13) & (x <= 13) & (y >= 6) & (y <= 8);
return res1 | res2 | res3 | res4 | res5 | res6 | res7 | res8;
        }
    }
}
