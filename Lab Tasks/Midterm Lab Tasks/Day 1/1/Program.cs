namespace _1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double FirstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNum = int.Parse(Console.ReadLine());

            double addition = FirstNum + secondNum;
            double substraction = FirstNum - secondNum;
            double multiplication = FirstNum * secondNum;
            double division = FirstNum / secondNum;

            Console.WriteLine("Addistion: " + addition);
            Console.WriteLine("Substraction: " + substraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);
        }
    }
}
