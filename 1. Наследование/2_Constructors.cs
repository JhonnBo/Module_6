namespace _1._Constracots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new("Bill", "Gates", 100001, 5999);
            employee.printInfo();
        }
    }

    class Human //sealed // добавляет возможность запретить
                //наследоваться от базового класса
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public Human(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }
        //метод базового класса
        //public void printInfo()
        //{
        //    Console.WriteLine($"{fName} {lName}");
        //}
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

        public void printInfo()
        {
            //base.printInfo(); // использование метода базового класса
            Console.WriteLine($"{fName} {lName} ID: {iD} Salary: {Salary}");
        }

    }
}