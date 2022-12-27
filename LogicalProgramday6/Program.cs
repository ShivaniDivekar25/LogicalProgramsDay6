namespace LogicalProgramDay6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!");
            Console.WriteLine("please enter below option ");
            Console.WriteLine("1:Fibonacci\n2:PerfectNumber\n3:PrimeNumber\n4:ReverseNumber\n5:StopWatch\n6:VendingMachine\n7:DayOfWeek\n8:TemperatureConverter\n9:MonthlyPayment\n10:SquareRoot\n11:DecimalToBinary");
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
                case 8:
                    TemperatureConverter temp = new TemperatureConverter();
                    Console.WriteLine("Please enter the celcius temp:");
                    double fahrenhiet = temp.celciusToFahrenhiet();
                    Console.WriteLine("The value of celcius in fahrenhiet is {0}", fahrenhiet);

                    TemperatureConverter temp1 = new TemperatureConverter();
                    Console.WriteLine("Please enter the fahrenhiet temp:");
                    double celcius = temp.fahrenhietToCelcius();
                    Console.WriteLine("The value of fahrenhiet in celcius in {0}", celcius);
                    break;
                case 9:
                    MonthlyPayment.monthlypayment();
                    break;
                case 10:
                    SquareRootNewtones.squareRootNewtons();
                    break;
                case 11:
                    DecimalToBinary.decimalToBinary();
                    break;
                default:
                    Console.WriteLine("Plaese choose correct option");
                    break;
            }
        }
    }
}