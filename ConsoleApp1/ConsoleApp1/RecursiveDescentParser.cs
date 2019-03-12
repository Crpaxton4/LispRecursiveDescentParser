using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace LispChecker
{
    class RecursiveDescentParser
    {


        static void Main(string[] args)
        {
            // Read in the file and remove all whit space from the file to be parsed from stdin. 
            string trim = Regex.Replace(Console.In.ReadToEnd(), @"\s+", " "); //  make all whitespace a single space
            trim = Regex.Replace(trim, @"([^ -~])", ""); //remove all non-prntable ascii characters
            while(trim.Contains(") )"))
            {
                trim = trim.Replace(") )", "))");
            }
            


            Console.WriteLine(trim);



            // if the file is a valid scheme expression then
            if (S_Expression(trim))
            {
                Console.WriteLine("SYNTAX OK");
            }
            else
            {
                Console.WriteLine("SYNTAX ERROR");
            }
            

            // Pause the program for a bit to see th output
            Thread.Sleep(10000);
        }

        static bool S_Expression(string txt)
        {
            if (AtomicSymbol(txt)) // terminal
            {
                return true;
            }
            else if (List(txt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Terminal symbol
        static bool AtomicSymbol(string text)
        {
            return true;
        }

        static bool List(string text)
        {
            return true;
        }
    }
}
