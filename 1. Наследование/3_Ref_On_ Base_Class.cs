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
                try
                {
                    ((Specialist)employee).printSpecialistInfo(); // Способ №1

                }
                catch { }


                Manager? manager = employee as Manager; // Способ №2
                if (manager != null)
                {
                    manager.printManagerInfo();
                }

                if (employee is Manager empl) // Способ №3
                {
                    empl.printManagerInfo();
                }
            }            
        }

        class Human
        {
            public string fName { get; set; }
            public string lName { get; set; }

            public Human(string fName, string lName)
            {
                this.fName = fName;
                this.lName = lName;
            }

        }
        class Employee : Human
        {
            public int iD { get; set; }
            public int Salary { get; set; }
            public Employee(string fName, string lName, int iD, int Salary) : base(fName, lName)
            {
                this.iD = iD;
                this.Salary = Salary;
            }
            public void printEmployeeInfo()
            {
                Console.WriteLine($"{fName} {lName} ID: {iD} Salary: {Salary}");
            }
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

            public void printSpecialistInfo()
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

            public void printManagerInfo()
            {
                Console.WriteLine($"{fName} {lName} ID: " +
                    $"{iD} Salary: {Salary} Field of Activity {FieldActivity}");
            }
        }
    }
}