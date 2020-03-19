using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll4
{
    class Employee
    {
        public string empName;
        public int empID;
        public int hourlyRate;
        public int hoursWorked;

        public Employee(string empName, int empID, int hourlyRate, int hoursWorked)
        {
            this.empName = empName;
            this.empID = empID;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;

        }

        public int CalculateGrossPay(Employee emp)
        {

            return (Convert.ToInt32(emp.hourlyRate) * Convert.ToInt32(emp.hoursWorked));

        }
    }

}
