using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll4
{
    class Payroll
    {
        private List<Employee> _employees;

        public void PrintAllEmployeeInfo(List<Employee> _employees)
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Employee name: " + employee.empName);
                Console.WriteLine("Employee ID:" + employee.empID);
                Console.WriteLine($"Employee hourly rate: {employee.hourlyRate:C2}");
                Console.WriteLine("Employee hours worked: " + employee.hoursWorked);
                Console.WriteLine($"Employee gross pay: {employee.CalculateGrossPay(employee):C2}");

            }
        }
    }
}
