using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Text =@"This Comprehensive compendium provides a broad and through investigation of all
            //            aspects of programming with ASP.NET. Entirely revised and update for the 3.5 Release of .NET
            //            this book will give you the information you need to master ASP.NET and build a dynamic, successful, enterprise Web application";
            //string Pattern = "ion";
            //MatchCollection Matches = Regex.Matches(Text, Pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            //foreach (Match match in Matches)
            //{
            //    Console.WriteLine(match.Index);
            //}
            string text1 = "#@o3LguIrO7BOPgB==";
            string text2 = "test,123,#@8Q==,#@uN4KEDc=";
            string text3 = "Driver={SQL Server};Server=test;Database=123;User Id=#@8Q==;Password=#@uN4KEDc=";
            string text4 = "=";
            string text5 = "@#=";
            VerifyEncryptedChars(text1);
            VerifyEncryptedChars(text2);
            VerifyEncryptedChars(text3);
            VerifyEncryptedChars(text4);
            VerifyEncryptedChars(text5);
            Console.ReadKey();

        }
        static void WriteMatches(string text, MatchCollection matches)
        {
            Console.WriteLine("original text was: \n\n" + text + "\n");
            Console.WriteLine("No. of matches: " + matches.Count);
            foreach(Match match in matches)
            {
                int Index = match.Index;
                string result = match.ToString();
                int charBefore = (Index < 5) ? Index : 5;
                int fromEnd = text.Length - Index - result.Length;
                int charAfter = (fromEnd < 5) ? Index : 5;
                int charToDisplay = charBefore + charAfter + result.Length;
                Console.WriteLine("");
            }
        }

        static void VerifyEncryptedChars(string s)
        {
            string pattern = ".*?#@.*?=$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(s))
            {
                Console.WriteLine("{0} Is Match {1}",pattern, s);
            }
            else
            {
                Console.WriteLine("{0} Is Not Match {1}", pattern, s);
            }
        }
    }
}
