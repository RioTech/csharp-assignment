using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class IndexOfLongestRun
    {
        /// <summary>
        /// Finds the zero-based index of the longest run in a string.
        /// </summary>
        public static void FindIndexOfLongestRun()
        {
            try
            {
                Console.WriteLine("Please enter the input string");
                string inputString = Console.ReadLine();
                while (!Validator.OnlyLetters(inputString))
                {
                    Console.WriteLine("Sorry, input string must contains only of English alphabet letters (A-Z and a-z)");
                    inputString = Console.ReadLine();
                }
                Console.WriteLine(Environment.NewLine + "Given string is: " + inputString);
                char longSeqCharacter = LongestSeq(inputString);
                Console.WriteLine("Longest run character in the given string is: " + longSeqCharacter);
                int longSeqCharacterIndex = GetNthIndex(inputString, longSeqCharacter, 1);
                Console.WriteLine("Index of the longest run in a string is " + longSeqCharacterIndex + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Exception at IndexOfLongestRun.FindIndexOfLongestRun {0} ST {1}", ex.Message, ex.StackTrace));
            }
        }
        /// <summary>
        /// Method used to identify longest sequence character in the given string
        /// </summary>
        /// <param name="strPass"></param>
        /// <returns>Longest sequence char</returns>
        static char LongestSeq(string strPass)
        {
            int longestSeq = 0;
            char longestSeqChar = '\0';
            int numCurrSeq = 1;
            try
            {
                for (int i = 0; i < strPass.Length - 1; i++)
                {
                    if (strPass[i] == strPass[i + 1])
                    {
                        numCurrSeq++;
                    }
                    else
                    {
                        numCurrSeq = 1;
                    }

                    if (numCurrSeq > longestSeq)
                    {
                        longestSeq = numCurrSeq;
                        longestSeqChar = strPass[i];
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Exception at IndexOfLongestRun.LongestSeq {0} ST {1}", ex.Message, ex.StackTrace));
            }

            //return longestSeq;
            return longestSeqChar;

        }
        /// <summary>
        /// Method used to find Nth occurrence of a character in a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="n"></param>
        /// <returns>index of a char in a string</returns>
        static int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == t)
                    {
                        count++;
                        if (count == n)
                        {
                            return i;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(string.Format("Exception at IndexOfLongestRun.GetNthIndex {0} ST {1}", ex.Message, ex.StackTrace));
            }
            return -1;
        }
    }
}
