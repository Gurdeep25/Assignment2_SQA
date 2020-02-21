using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            string result = " ";
            if (a + b > c && a + c > b && b + c > a)
                
            {
                if (a == b && b == c)
                    result = "According to Input Values, It is Equilateral triangle";
                else if (a == b || a == c || b == c)
                    result = "According to Input Values, It is Isosceles triangle";
                else
                    result = "According to Input Values, It is Scalene triangle";
            }
            else
                result = "According to Input Values, It doesnt form a Valid Triangle";

            return result;
        }
        
    }
}
