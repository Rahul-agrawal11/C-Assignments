using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class Calculator
    {
        public static int Add(int a, int b) { return a + b; }

        public static int Subtract(int a, int b) {if (a > b) return a - b; return b - a; }

        public static int Multiply(int a, int b) {return a * b; }

        public static int Divide(int a, int b) { if (a > b) return a / b; return b / a; }
    }
}
