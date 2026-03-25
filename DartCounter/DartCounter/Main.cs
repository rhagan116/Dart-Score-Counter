using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartCounter
{
    internal class Main
    {
        getScore score = new getScore();
        getNum num = new getNum();

        string micScore;


        public Main()
        {
            micScore = score.Listen();
            int count = num.convertNum(micScore);

            Console.WriteLine(count);
        }
    }
}
