using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int userOption = 0;
                Console.WriteLine("******************************$$$$ WELCOME $$$$$*******************************\n");
                //Display the menu
                while (userOption != 5)
                {
                    userOption = DisplayMenu();
                    if (userOption == 5)
                        return;

                    //Take the action
                    if (userOption == 1)
                    {
                        BugFix.DisplayQuestion();
                    }
                    else if (userOption == 2)
                    {
                        Path.ChangeDirectory();
                    }
                    else if (userOption == 3)
                    {
                        IndexOfLongestRun.FindIndexOfLongestRun();
                    }
                    else if (userOption == 4)
                    {
                        BinarySearchTree bst = new BinarySearchTree();
                        bst.Check();
                    }
                    else
                    {
                        //do nothing...
                    }
                    //Print the result
                    Console.WriteLine("*******************************************************************************");
                }
                //End display menu
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unhandled error has been occured!");
            }
        }
        
        /// <summary> 
        /// Displays the actual menu
        /// </summary>
        /// <returns>Returns an int that represents the user's action</returns>
        public static int DisplayMenu()
        {
            Console.WriteLine("Enter the number corresponding to the action that you would like to perform.\n");
            Console.WriteLine("1. Identifying a bug in the given program.  " + Environment.NewLine + "2. Change directory function.  " + Environment.NewLine
                + "3. Finding the index of longest run in a string.  " + Environment.NewLine + "4. Binary Search Tree.");
            //Get the option
            int optionVaue;
            try
            {
                optionVaue = int.Parse(Console.ReadLine());

            }
            catch
            {
                optionVaue = 0;
            }
            return optionVaue;
        }
    }
}
