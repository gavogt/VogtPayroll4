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
            string path = @"c:\Documents\MyTest.txt";
            string line;
            StreamReader file = new StreamReader(@"C:\Users\Gabriel\source\repos\VogtPayroll4\MyTest.txt");
            employees = new List<Employee>();

            while ((line = file.ReadLine()) != null)
            {

                string[] employeeProperties = line.Split(',');
                Employee emp = new Employee(employeeProperties[0], int.Parse(employeeProperties[1]), int.Parse(employeeProperties[2]), int.Parse(employeeProperties[3]));
                employees.Add(emp);
            }

            return employees;
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
