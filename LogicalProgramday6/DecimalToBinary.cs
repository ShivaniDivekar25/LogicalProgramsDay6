using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    internal class DecimalToBinary      //Creating class
    {
        public static void decimalToBinary()        //Creating method
        {
            int decVal;        //Initializing input values
            int val;
            string a = "";

            Console.WriteLine("Enter the decimal value");       //Taking user input
            decVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decimal: {0}", decVal);
            while (decVal >= 1)     //while loop for required condition
            {
                val = decVal / 2;
                a += (decVal % 2).ToString();
                decVal = val;
            }
            string binValue = "";
            for (int i = a.Length - 1; i >= 0; i--)     //For loop for required condition
            {
                binValue = binValue + a[i];
            }
            Console.WriteLine("Binary: {0}", binValue);
        }
    }
}