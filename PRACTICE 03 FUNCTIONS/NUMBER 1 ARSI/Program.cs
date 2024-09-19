namespace NUMBER_1_ARSI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TriangleArea = HeronsFormula();
            Console.WriteLine($"\n=================");
            Console.WriteLine($"\nThe Area is: {TriangleArea:F2}");


            static double HeronsFormula()
            {

                Console.WriteLine("Enter a side (a): ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a side (b):");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a side (c): ");
                double c = Convert.ToDouble(Console.ReadLine());
                
                double s = (a + b + c) / 2;

                double arearesult = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                return arearesult; 
            }
        }
    }
}