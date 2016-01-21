using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment
{
    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public Path Cd(string newPath)
        {
            var lastOccurance = this.CurrentPath.LastIndexOf('/');
            var req = this.CurrentPath.Substring(0, (lastOccurance + 1));
            return new Path(req + newPath.Substring(3));
        }
        /// <summary>
        /// Provides change directory function
        /// </summary>
        public static void ChangeDirectory()
        {
            try
            {
                Console.WriteLine("Enter the directory path");
                string inputPath = Console.ReadLine();
                while (!ValidateDirectoryPath(inputPath))
                {
                    inputPath = Console.ReadLine();
                }
                Path path = new Path(inputPath);
                Console.WriteLine("Enter the change directory path");
                string changePath = Console.ReadLine();
                while (!ValidateRequestedPath(changePath))
                {
                    changePath = Console.ReadLine();

                }
                Console.WriteLine(path.Cd(changePath).CurrentPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception at Path.ChangeDirectory {0} ST {1}", ex.Message, ex.StackTrace));
                Logger.Log(string.Format("Exception at Path.ChangeDirectory {0} ST {1}", ex.Message, ex.StackTrace));
            }
        }
        /// <summary>
        /// Validates the directory path
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool ValidateDirectoryPath(string inputPath)
        {
            if (!string.IsNullOrEmpty(inputPath))
            {
                if (!inputPath.StartsWith("/"))
                {
                    Console.WriteLine("Sorry, Root path is '/'");
                    return false;
                }
                bool match = Regex.IsMatch(inputPath, @"^[a-zA-Z/]+$");
                if (!match)
                {
                    Console.WriteLine("Sorry, Directory names consist only of English alphabet letters (A-Z and a-z)");
                    return false;
                }
                if (inputPath.Length <= 1)
                {
                    Console.WriteLine("Sorry, Please enter valid directory path Eg: /a/b/c/d");
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Validates the requested path
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool ValidateRequestedPath(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!input.StartsWith("../"))
                {
                    Console.WriteLine("Change directory should starts with ../");
                    return false;
                }
                if (input.Length <= 3)
                {
                    Console.WriteLine("Sorry, Please enter valid path Eg: ../x");
                    return false;
                }
            }
            return true;
        }
    }
}