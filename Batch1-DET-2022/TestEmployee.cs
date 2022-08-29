
using Batch1_DET_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee emp = new Employee(22832, "Rahul", "Bangalore", 560098, 8088816052, 100000);
            Console.WriteLine($"Employee's net salary {emp.GetEmpNetSalary()}");
            Console.WriteLine($"Employee's grade is {emp.GetEmpGrade()}");
        }
    }
}

