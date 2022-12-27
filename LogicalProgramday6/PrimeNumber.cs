using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    internal class PrimeNumber
    {
        public static void PrimeNum(int input)
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i != 0)
                    count++;
            }
            if (count < 2)
            {
                Console.WriteLine("{0} is not prime number", input);
            }
            else
            {
                Console.WriteLine("{0} is prime number", input);
            }

        }
    }
}
