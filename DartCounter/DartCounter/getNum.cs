using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DartCounter
{
    internal class getNum
    {
        public int convertNum(string score)
        {
            List<string> num = new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            int final = num.IndexOf(score);
            Console.WriteLine(final);
            return final;
        }
    }
}
