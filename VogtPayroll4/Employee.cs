using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll4
{
    class Employee
    {
        public string empName;
        public string empID;
        public string hourlyRate;
        public string hoursWorked;

        public Employee(string empName, string empID, string hourlyRate, string hoursWorked)
        {
            this.empName = empName;
            this.empID = empID;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;

        }
    }

}
