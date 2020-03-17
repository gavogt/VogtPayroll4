using System;
using System.Collections.Generic;

namespace VogtPayroll4
{
    class Program
    {
        static void Main(string[] args)
        {

            Payroll payroll = new Payroll();
            List<Employee> empList = new List<Employee>();
            empList = payroll.ReadEmployees();

            payroll.LoopThroughEmployeesList(empList);

        }


    }
}
