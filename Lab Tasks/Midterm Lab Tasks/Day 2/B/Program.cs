namespace B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Row{i} Col{j}: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i,j]} "); // Display array
                    sum += arr[i, j]; // Sum
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum = {sum}");

        }
    }
}
