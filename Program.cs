using System;

namespace HelloWorld
{
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
