namespace C
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of students: ");
            int totalStudents = int.Parse(Console.ReadLine());

            int[][] studentMarks = new int[totalStudents][];

            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write($"\nEnter the number of subjects for Student {i + 1}: ");
                int subjects = int.Parse(Console.ReadLine());

                studentMarks[i] = new int[subjects];

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write($"Enter marks for Subject {j + 1}: ");
                    studentMarks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            int highestTotal = -1;
            int topStudentIndex = -1;

            Console.WriteLine(" Results :");
            for (int i = 0; i < studentMarks.Length; i++)
            {
                int currentStudentTotal = 0;

                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    currentStudentTotal += studentMarks[i][j];
                }

                Console.WriteLine($"Student {i + 1} Total Marks: {currentStudentTotal}");

                if (currentStudentTotal > highestTotal)
                {
                    highestTotal = currentStudentTotal;
                    topStudentIndex = i;
                }
            }

            Console.WriteLine($"Student {topStudentIndex + 1} has the highest total marks of {highestTotal}!");
        }
    }
}
