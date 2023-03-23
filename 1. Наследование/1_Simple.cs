namespace _1._Наследование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new("Bill", "Gates");
            Console.WriteLine(employee.fName + " " + employee.lName);
            //Human hm = new Human();
            //hm.iD
        }
    }

    class Human
    {
        public int iD;
        public string fName { get; set; }
        public string lName { get; set; }
    }
    class Employee : Human
    {
        public Employee(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
            //iD = 0; // Mistake
        }
        
    }
}