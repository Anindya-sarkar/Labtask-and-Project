namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give Arraay size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Input {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The array is: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int largest = 0;
            foreach (int i in arr)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            Console.WriteLine($"Largest Number is: {largest}");
        }
    }
}
