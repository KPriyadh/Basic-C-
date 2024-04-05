using System;
using System.Collections.Generic;
namespace Payroll{
    class Program{
       public static void Main(string[] args)
       {
        Console.WriteLine("Employee Payroll Management");
        Console.WriteLine("Choose any Option from Below List");
        Console.WriteLine("1.Registration\n2.Login\n3.Exit");
        int n = int.Parse(Console.ReadLine());
        if(n==1){
                List<EmployeePayroll> EmployeeList = new List<EmployeePayroll>();
                string option = "";
                do
                {
                    EmployeePayroll employee = new EmployeePayroll();
                    employee.EmployeeName = Console.ReadLine();
                    employee.EmployeeRole = Console.ReadLine();
                    Console.WriteLine("Select a Work Location\nChennai\nMumbai\nPune");
                    WorkLocation worklocation = Enum.Parse<WorkLocation>(Console.ReadLine(),true);
                    employee.TeamName = Console.ReadLine();
                    employee.Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    employee.Working = int.Parse(Console.ReadLine());
                    employee.Leave = int.Parse(Console.ReadLine());
                    Console.WriteLine("Select a Gender\nMale\nFemale\nTransgender");
                    Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                    EmployeeList.Add(employee);
                    Console.WriteLine("You have successfully Registered: Your Employee Id is" + employee.EmployeeID);
                    Console.WriteLine("Do you want to add another employee");
                    option = Console.ReadLine();
                } while (option == "yes");

            }
        else if(n==2){
            List<EmployeePayroll> EmployeeList = new List<EmployeePayroll>();
            string option = "";
            do
            {
                EmployeePayroll employee = new EmployeePayroll();
                Console.WriteLine("Enter your Login Id:");
                string LoginId = Console.ReadLine();
                bool flag = true;
                    foreach (EmployeePayroll emp in EmployeeList)
                    {
                        if (LoginId == employee.EmployeeID)
                        {
                            flag = false;
                            Console.WriteLine("Choose any Option:");
                            Console.WriteLine("1. Calculate salary\n2. display details\n3. exit");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                int salary = employee.Working * 500;
                                Console.WriteLine(salary);
                            }
                            else if (a == 2)
                            {
                                Console.WriteLine("Name: " + employee.EmployeeName);
                                Console.WriteLine("Role: " + employee.EmployeeRole);
                                Console.WriteLine("EmployeeTeamName: " + employee.TeamName);
                                Console.WriteLine("DateOfJoining: " + employee.Date);
                                Console.WriteLine("WorkingDays: " + employee.Working);
                                Console.WriteLine("Leave: " + employee.Leave);

                            }
                            else
                            {

                            }
                        }
                        if(flag){
                            Console.WriteLine("User Invalid ID");
                        }
                    }
                }while(option=="yes");
       } 
       else if(n==3){

       }
    }
}
}