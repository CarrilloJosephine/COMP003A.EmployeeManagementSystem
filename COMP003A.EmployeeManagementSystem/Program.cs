// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

using System.Runtime.CompilerServices;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID: ");
            Console.WriteLine("Enter First Name: ");
            Console.WriteLine("Enter Middle Name (Press Enter to skip): ");
            Console.WriteLine("Enter Last Name: ");
            Console.WriteLine("Enter Salary: ");

            Console.WriteLine("Employee Created Successfully!");

            Console.WriteLine("Employee ID: ");
            Console.WriteLine("Name: ");
            Console.WriteLine("Salary: ");

            Console.WriteLine("Department: ");
            Console.WriteLine("Details: ");
            Console.WriteLine("Performing HR operations... ");

            Console.WriteLine("Department: ");
            Console.WriteLine("Details: ");
            Console.WriteLine("Performing IT operations... ");
        }
        class EmployeeID 
        {
            private int employeeID;

            public int EmployyeeID
            {
                get { return EmployyeeID; }
                set { if (value>= 0) EmployyeeID = value; }
            }
        }

        class Firstname
        {
            private string firstName;

            public string FirstName
            {
                get { return firstName; }
            }
        }

        class MiddleName
        {
            private string middleName;

            public string MiddleNamee
            {
                get { return middleName; }
            }
        }

        class Lastname 
        {
            private string lastName;

            public string LastName
            {
                get { return lastName; }
            }
        }


        class Salary
        {
            private double salary;

            public double Salaryy
            {
                get { return salary; }
                set { salary = value; }
            }
        }

    }
}
