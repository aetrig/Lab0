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
                //Fizz test
                if (i % 3 == 0) outputString += "Fizz";
                //Buzz test
                if (i % 5 == 0) outputString += "Buzz";

                //Print number if it didn't past any tests
                if (outputString == "") Console.WriteLine(i);
                //Print the text depending on passed tests
                else Console.WriteLine(outputString);
            }
        }
    }
}
