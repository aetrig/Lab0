using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    class FizzBuzz
    {
        private int max;
        public FizzBuzz(int max)
        {
            this.max = max;
        }
        public void Print()
        {
            for (int i = 1; i <= max; i++)
            {
                String outputString = "";
                if (i % 3 == 0) outputString += "Fizz";
                if (i % 5 == 0) outputString += "Buzz";
                if (outputString == "") Console.WriteLine(i);
                else Console.WriteLine(outputString);
            }
        }
    }
}
