using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;

namespace UsingSharedLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Add(5, 3);
            Console.WriteLine(result);
        }
    }
}
