using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Payroll
    {
       private List<Employee> employees = new List<Employee>();

        internal void Add(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
