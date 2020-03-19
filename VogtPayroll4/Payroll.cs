using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll4
{
    class Payroll
    {
        private List<Employee> _employees = new List<Employee>();

        #region PrintAllEmployeeInfo
        /// <summary>
        /// Prints all employee information
        /// </summary>
        /// <param name="_employees">The employee passed in</param>
        public void PrintAllEmployeeInfo()
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
        #endregion

        #region AddEmployees
        /// <summary>
        /// Adds an employee list to private variable employees
        /// </summary>
        /// <param name="employees">Employee list to pass in</param>
        public void AddEmployees(List<Employee> employees)
        {
            _employees.AddRange(employees);
        }
        #endregion

    }
}
