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
                        string Text =@"This Comprehensive compendium provides a broad and through investigation of all
                        aspects of programming with ASP.NET. Entirely revised and update for the 3.5 Release of .NET
                        this book will give you the information you need to master ASP.NET and build a dynamic, successful, enterprise Web application";
            string Pattern = "ion";
            MatchCollection Matches = Regex.Matches(Text, Pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            foreach (Match match in Matches)
            {
                Console.WriteLine(match.Index);
            }
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
    }
}
