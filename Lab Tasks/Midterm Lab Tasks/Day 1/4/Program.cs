namespace _4
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.Write("Enter value of N: ");
            int n  = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                sum += i;
            }
            Console.WriteLine($" Sum is: {sum}");
        }
    }
}
