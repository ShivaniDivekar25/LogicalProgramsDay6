using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    internal class BinaryToDecimal      //Creating class
    {
        public static void binaryToDecimal()        //Creating method
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;          //Initializing input values
            Console.WriteLine("Enter Binary number to convert into Decimal");       //Taking uer input
            num = Convert.ToInt32(Console.ReadLine());
            binVal = num;
            while (num > 0)         //While loop for required condition
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.WriteLine("Binary Number:" + binVal);
            Console.WriteLine("Decimal Number:" + decVal);
        }
    }
}
