using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    public class Department
    {
        public string DepartmentName { get; set; }

        public int EmployeeDepartmentId { get; set; }

        public string DepartmentDetails{ get; set; }

        public void SeeEmployeeDepartmentInfo()
        {
            Console.WriteLine($"departmet: {DepartmentName}");
        }
    }

    public class EmployeeHR 
    {

        public EmployeeHR ()
        {
             Console.WriteLine("Human Resources");  
             Console.WriteLine("HR department manages employee relationships, payrool and benefits.");
        }
    }

    public class ITDepartment
    {
        public ITDepartment()
        {
            Console.WriteLine("Informantion technology");
            Console.WriteLine("It departement manages company software, hardware, and cybersecurity.");
        }
    }

}
