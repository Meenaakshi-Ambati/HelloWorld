using System;

namespace HelloWorld
{
    class Employee
        {
            public int Id  {get; set; }
            public string Name { get; set; }

            public double Salary { get; set; }


            public  override string ToString()
            {
                return  $"{Id} - {Name} - {Salary}";
            }
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated!");
            
            Employee employee = new Employee{ Id = 101, Name = "Meenaa", Salary = 80000 };
            Console.WriteLine(employee);
        }
    }
}
