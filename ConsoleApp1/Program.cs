using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            Console.WriteLine("State your full name:");
            string name = Console.ReadLine();
            Console.WriteLine("State your salary:");
            string input = Console.ReadLine();

            //int resuslt = int.Parse(salary);
            if (!int.TryParse(input, out int salary))
            {
                Console.WriteLine("Wrong input");
            }

            Employee emp = new Employee(name,salary);
            payroll.Add(emp);


        }
    }
}
