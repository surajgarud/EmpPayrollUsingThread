using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollUsingThreads
{
    internal class Demo
    {
        public static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into q
                                 orderby q.Count() descending
                                 select q.Key;
            var commonWord = frequencyOrder.Take(10);
            //Console.WriteLine($"The most common word is {commonWord}");
            Console.ReadKey();
        }

        public static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");
            //Download a web page the easy way
            string blog = new WebClient().DownloadString(uri);
            return blog.Split(
                new char[] { ' ', '\u000A', '.', ',', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
        public static string GetLongestWord(string[] words)
        {
            string longestWord = (from w in words
                                  orderby w.Length descending
                                  select w).First();

            Console.WriteLine($"Task 1 -- The longest word is {longestWord}.");
            return longestWord;
        }

    }
}
