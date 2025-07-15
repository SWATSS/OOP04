using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Classes
{
    #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:

    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

    }
    #endregion
}

