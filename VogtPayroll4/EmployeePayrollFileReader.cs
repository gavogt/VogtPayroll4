using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll4
{
    class EmployeePayrollFileReader
    {

        #region ReadEmployeesFromFile
        /// <summary>
        /// Reads employees from File
        /// </summary>
        /// <returns>A list of employees</returns>
        public List<Employee> ReadEmployeesFromFile()
        {

            StreamReader file = new StreamReader(@"C:\Users\Gabriel\source\repos\VogtPayroll4\MyTest.txt");
            string line;
            List<Employee> employees = new List<Employee>();

            while ((line = file.ReadLine()) != null)
            {
                string[] employeeProperties = line.Split(',');

                employees.Add(new Employee(employeeProperties[0], int.Parse(employeeProperties[1]), int.Parse(employeeProperties[2]), int.Parse(employeeProperties[3])));

            }
            return employees;

        }
        #endregion
    }
}
