namespace NUMBER_2_ARSI
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
           LeapYearFunction();
        }
        static void LeapYearFunction()
        {
                Console.WriteLine("Please Enter a Year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    Console.WriteLine("The year" + " " + year + " " + "is a leap year :D ");
                else
                    Console.WriteLine("The year" + " " + year + " " + "is not a leap year :(");
        }
    }
}
