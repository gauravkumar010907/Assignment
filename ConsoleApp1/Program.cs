using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_Csharp;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Litware");

            Console.WriteLine("Enter Employee No.");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            double sal = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(no, name, sal);
            emp.CalculatedSalary();
        }
    }
}
