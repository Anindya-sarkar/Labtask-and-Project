namespace A
{
    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Person(string Name, int age)
        {
            this.Name = Name;
            this.age = age;
        }
    }

    class Student : Person
    {
        public int StudentID { get; set; }
        public Student (string Name, int age, int StudentID) : base(Name,age)
        {
            this.StudentID = StudentID;
        }

        public void Display()
        {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Student ID" + StudentID);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ahnaf", 21, 22);
            s1.Display();
        }
    }
}
