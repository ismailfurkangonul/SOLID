using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEmployee employee = new EmployeePartTime();
            employee.CalculateSalary();
         
        }
    }
}
