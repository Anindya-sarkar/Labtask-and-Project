using System.Runtime.CompilerServices;

namespace B
{
    class Employee
    {
        public int Id;
        public string Name;
        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
        }
    }

    class PermanentEmployee : Employee
    {
        public double salary;
        public double bonus;
        public PermanentEmployee(double salary, double bonus, int Id, string Name) : base(Id,Name) // The Employee constructor will be called autometically because of base.
        {
            this.salary = salary;
            this.bonus = bonus;
            double TotalSalary = salary + bonus;
            Console.WriteLine($"Total Salary : {TotalSalary}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee emp = new PermanentEmployee(5000, 2500, 101, "Ahnaf Hossain"); 
        }
    }
}
