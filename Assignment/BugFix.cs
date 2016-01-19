using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BugFix
    {
        public static void DisplayQuestion()
        {
            Console.WriteLine("Identify a bug in the given program.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                public class MathUtils
                {
                    public static double Average(int a, int b)
                    {
                          return a + b / 2;
                    }
                }");
            Console.ResetColor();
            Console.WriteLine("Press enter key to see the answer");
            Console.ReadLine();
            Console.WriteLine("According to BODMAS rule, we have to enclose 'a + b' within brackets.\n");
        }
    }

    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            return a + b / 2;
        }
    }
}
