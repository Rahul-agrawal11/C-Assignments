using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAssembly
{
    public class Class1
    {
            public static string SpaceRemover(string input)
            {
                if (input == null)
                {
                    return null;
                }
                return input.TrimStart().TrimEnd();
            }
            public static string StringReverser(string input)
            {
                if (input == null)
                {
                    return null;
                }
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }


