using System;
using System.Collections.Generic;
using System.Linq;

namespace CandidateTest
{
    public static class TestFunctions
    {
        /// <summary>
        /// Function that takes a list of values, and returns the average of them
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Average value of a list of numbers</returns>
        public static double Average(List<int> values)
        {
            return values.First() + values.Last() / 2;
        }

        /// <summary>
        /// Takes 2 string arrays returns 1 string array containing only unique names (remove duplicates), and order in alphabetically descending.
        /// </summary>
        /// <param name="names1"></param>
        /// <param name="names2"></param>
        /// <returns>String[] containing unique names</returns>
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return new string[0];
        }

        /// <summary>
        /// Takes an input phrase, reverses it, and changes to "proper" case - eg "Correct horse battery stapler" becomes "Stapler battery horse correct"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReversePhrase(string input)
        {
            return "";
        }
    }
}