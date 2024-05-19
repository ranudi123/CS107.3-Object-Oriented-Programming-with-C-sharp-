using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q2
{
    class Employee
    {
        public int EmployeeID { get; }
        public string FullName { get; set; }
        public double Salary { get; }
        
        public Employee(int employeeID, double salary)
        {
            EmployeeID = employeeID;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    internal class Program
        {
            static void Main(string[] args)
            {
            Employee emp1 = new Employee(101, 50000);

            Console.WriteLine("Employee ID (read-only): ");
            emp1.FullName = "Ranudi Kariyapperuma";
            emp1.DisplayEmployeeInfo();


            emp1.FullName = "Ranudi Kariyapperuma";

            Console.WriteLine("\nEmployee information after update: ");
            emp1.DisplayEmployeeInfo();

            Console.ReadLine();
        }
       
    } 
}

