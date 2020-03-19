using System;
using System.Collections.Generic;

namespace VogtPayroll4
{
    class Program
    {
        static void Main(string[] args)
        {
            //You should be calling the ConsoleReader to read the list of employees, 
            //then with the list calling payroll.AddEmployees(). Finally, then you can payroll.PrintAllEmployeeInfo()
            Payroll payroll = new Payroll();
            List<Employee> empList = new List<Employee>();

            EmployeePayrollFileReader employeePayrollFileReader = new EmployeePayrollFileReader();

            empList = employeePayrollFileReader.ReadEmployeesFromFile();
            payroll.PrintAllEmployeeInfo(empList);

        }


    }
}
