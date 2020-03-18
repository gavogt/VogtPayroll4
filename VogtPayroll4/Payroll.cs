using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll4
{
    class Payroll
    {
        public List<Employee> employees;

        public List<Employee> ReadEmployees()
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();

            return payrollConsoleReader.CreateNewEmployee();
        }

        public void LoopThroughEmployeesList(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Employee name: " + employee.empName);
                Console.WriteLine("Employee ID:" + employee.empID);
                Console.WriteLine($"Employee hourly rate: {employee.hourlyRate:C2}");
                Console.WriteLine("Employee hours worked: " + employee.hoursWorked);
                Console.WriteLine($"Employee gross pay: {CalculateGrossPay(employee):C2}");

            }
        }

        public int CalculateGrossPay(Employee emp)
        {
            
            return (Convert.ToInt32(emp.hourlyRate) * Convert.ToInt32(emp.hoursWorked));

        }
    }
}
