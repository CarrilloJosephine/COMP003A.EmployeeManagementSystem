// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

using System.Runtime.CompilerServices;

namespace COMP003A.EmployeeManagementSystem
{
    public class Employee
    {
        private string _employeeID;  
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _salary;

        public Employee(string employeeID, string firstName, string middleName, string lastName, string salary) 
        { 
            _employeeID = employeeID; //Raed-only
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _salary = salary;
        }

        public string EmployeeID { get { return _employeeID; } }

        public string FirstName { get { return _firstName; } set {
                if (string.IsNullOrWhiteSpace(value)) new Exception ("Cannot be empty"); _firstName = value; 
            } }

        public string MiddleName { get { return _middleName; } set {
                if (string.IsNullOrWhiteSpace(value)) new Exception("Cannot be empty"); _middleName = value;
            } }
        public String LastName { get { return _lastName; } set {
                if (string.IsNullOrWhiteSpace(value)) new Exception("Cannot be empty"); _lastName = value;
            } }

        public double salary { get { return salary; } set {
                if (value <= 0) new Exception("salary has to be bigger than zero"); 
            } }

        public void ShowAllName()
        { 
            if (string.IsNullOrWhiteSpace(_firstName))
                Console.WriteLine ($"All Name: {FirstName}, {MiddleName}, {LastName}");
        }

        public void ShowAllEmployeeinfo() 
        {
            Console.WriteLine("=================");
            Console.WriteLine($"Employee Id: {EmployeeID}");
            ShowAllName();
            Console.WriteLine($"salary: {salary}");
            Console.WriteLine("=================");
        }

        static void Main()
        {
            Employee one = new Employee("Employee1", "Josephine", "K", "Carrillo", "26440");
            Employee two = new Employee("Employee2", "Oscar", "T", "Lopez", "19050");

            Console.WriteLine("=== Employee Records ===");
            one.ShowAllEmployeeinfo();
            two.ShowAllEmployeeinfo();

            EmployeeHR hr = new EmployeeHR();
            ITDepartment it = new ITDepartment();

            Console.WriteLine("=== Department information ===");
            hr = new EmployeeHR();
            Console.WriteLine("hr.GetDepartmentDetails()");

            it = new ITDepartment();
            Console.WriteLine("it.GetDepartmentDetails()");


        }
    }

}
