using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll
{
    public enum WorkLocation{select,Chennai,Mumbai,Pune}
    public enum Gender{select , Male, Female, Transgender}
    public class EmployeePayroll
    {
        private static int _employeeId=1000;

        public string EmployeeID{get;}
        public string EmployeeName{get; set;}
        public WorkLocation WorkLocation{get; set;}
        public string EmployeeRole{get; set;}
        public string TeamName{get; set;}
        public DateTime Date{get; set;}
        public int Working{get; set;}
        public int Leave{get; set;}

        public Gender Gender{get; set;}


        public  EmployeePayroll(string employeeName, string employeeRole, Gender gender,WorkLocation workLocation, string teamName, int working, DateTime date ,int leave){          _employeeId++;
            EmployeeID = "SF"+_employeeId;
            EmployeeName = employeeName;
            EmployeeRole = employeeRole;
            Gender = gender;
            TeamName = teamName;
            Date=date;
            Working=Working;
            Leave=leave;
            
    }
}
}