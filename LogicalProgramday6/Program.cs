﻿namespace LogicalProgramDay6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("please enter below option ");
            Console.WriteLine("1:Fibonacci\n2:PerfectNumber\n3:PrimeNumber");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Please enter input value");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Fibonacci.FibonacciNum(count);
                    break;
                case 2:
                    Console.WriteLine("Enter input value");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Perfect.PerfectNumber1(number);
                    break;
                case 3:
                    Console.WriteLine("Enter input value");
                    int input = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.PrimeNum(input);
                    break;
                default:
                    Console.WriteLine("Plaese choose correct option");
                    break;
            }
        }
    }
}