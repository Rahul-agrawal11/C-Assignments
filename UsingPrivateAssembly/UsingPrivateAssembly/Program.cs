using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateAssembly;

namespace UsingPrivateAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.SpaceRemover("   Rahul   "));
            Console.WriteLine(Class1.StringReverser("RahulAgrawal"));
        }
    }
}
