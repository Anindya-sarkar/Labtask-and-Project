using System.Transactions;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else { Console.WriteLine("Zero"); }
        }
    }
}
