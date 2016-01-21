using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BugFix
    {
        /// <summary>
        /// Displays the question to the user
        /// </summary>
        public static void DisplayQuestion()
        {
            Console.WriteLine("Identify a bug in the given program.");
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                public class MathUtils
                {
                    public static double Average(int a, int b)
                    {
                          return (a + b) / 2;
                    }
                }");
            Console.ResetColor();
            Console.WriteLine("Enter a and b value");
            int a , b = 0;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("The average of two given numbers is " + MathUtils.Average(a,b));
        }
    }

    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }
    }
}
