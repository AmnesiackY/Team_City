using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCity
{
    public class Square_equations
    {
        public static double Discriminant(int a, int b, int c)
        {
            //a * Math.Pow(x, 2) + b * x + c;
            return Math.Pow(b, 2) - (4 * a * c);
        }
        //2
    }
}
