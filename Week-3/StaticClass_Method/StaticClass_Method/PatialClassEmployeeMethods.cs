using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass_Method
{
    internal partial class Employee
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee Id:" + this.EmployeeId);
            Console.WriteLine("Employee Name:" + this.EmployeeName);
        }
    }
}
