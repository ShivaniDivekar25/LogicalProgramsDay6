using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    public class VendingMachine       //Creating class
    {
        public static void countCurrency(int amount)        //Creating method
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };        //Array for amount
            int[] notesCounter = new int[8];

            for (int i = 0; i < 8; i++)         //For loop for condition 
            {
                if (amount >= notes[i])
                {
                    notesCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (notesCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + notesCounter[i]);
                }
            }
        }
    }
}
