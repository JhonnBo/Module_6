using System.Text;

namespace _1._Constracots
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Employee[] employees = {
            new Specialist("Bill", "Gates", 100001, 5999, "High"),
            new Manager("Tom", "Waits", 100001, 5999, "Sport"),
            new Specialist("Nick", "Cave", 100001, 5999, "High"),
            new Manager("Bob", "Twan", 100001, 5999, "Sport")};

            foreach (Employee employee in employees)
            {
                employee.printInfo();
            }
        }          

        // Employee employee1 = new Employee(); //Error!
        // Human hm = new Human(); //Error!

    }
    abstract class Human
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public Human(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

    }
    abstract class Employee : Human
    {
        public int iD { get; set; }
        public int Salary { get; set; }
        public Employee(string fName, string lName, int iD, int Salary) : base(fName, lName)
        {
            this.iD = iD;
            this.Salary = Salary;
        }
        public abstract void printInfo();
        //{
        //    Console.Write($"{fName} {lName} ID: {iD} Salary: {Salary}");
        //}

    }
    class Specialist : Employee
    {
        public string Qualification { get; set; }

        public Specialist(string fName, string lName,
            int iD, int Salary, string Qualification)
            : base(fName, lName, iD, Salary)
        {
            this.Qualification = Qualification;
        }

        public override void printInfo()
        {
            Console.WriteLine($"{fName} {lName} ID: " +
                $"{iD} Salary: {Salary} Qualification {Qualification}");
        }
    }
    class Manager : Employee
    {
        public string FieldActivity { get; set; }

        public Manager(string fName, string lName,
            int iD, int Salary, string FieldActivity)
            : base(fName, lName, iD, Salary)
        {
            this.FieldActivity = FieldActivity;
        }

        public override void printInfo()
        {
            //base.printInfo(); // У метода базового класса нет реализации поэтому ошибка!!!
            Console.WriteLine($"{fName} {lName} ID: " +
                $"{iD} Salary: {Salary} Field of Activity {FieldActivity}");
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is Manager manager &&
        //           fName == manager.fName &&
        //           lName == manager.lName &&
        //           iD == manager.iD &&
        //           Salary == manager.Salary &&
        //           FieldActivity == manager.FieldActivity;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(fName, lName, iD, Salary, FieldActivity);
        //}
    }

}
// Equals() и как работает сравнение типов в C#
// https://bool.dev/blog/detail/equals-i-i-kak-rabotaet-sravnenie-tipov-v-c

// Операторы равенства
// https://learn.microsoft.com/ru-ru/dotnet/standard/design-guidelines/equality-operators