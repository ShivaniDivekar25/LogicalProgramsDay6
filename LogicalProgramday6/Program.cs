namespace LogicalProgramDay6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("please enter below option ");
            Console.WriteLine("1:Fibonacci\n2:PerfectNumber\n3:PrimeNumber\n4:ReverseNumber\n5:StopWatch\n6:VendingMachine\n7:DayOfWeek");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)        //Calling different methods using switch case
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
                    PrimeNumber.primeNum(input);
                    break;
                case 4:
                    Console.WriteLine("Please enter number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.reverseNumbers(number1);
                    break;
                case 5:
                    StopWatch.stopWatch();
                    break;
                case 6:
                    Console.WriteLine("Enter the amount to be returned");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    VendingMachine.countCurrency(amount);
                    break;
                case 7:
                    DayOfWeek.dayOfWeek();
                    break;
                default:
                    Console.WriteLine("Plaese choose correct option");
                    break;
            }
        }
    }
}