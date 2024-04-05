using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
namespace BankAccountOpening;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Registration\n2.Login\n3.Exit");
        string n = Console.ReadLine();

        if (n == "Registration")
        {
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            string option = "";
            do
            {
                Console.WriteLine("Bank Account Opening!");
                Console.WriteLine("Enter Your Details Below");
                

                CustomerDetails customer = new CustomerDetails();

                Console.WriteLine("Enter your name:");
                customer.CustomerName = Console.ReadLine();
                
                Console.WriteLine("Select your Gender Male Female Transgender");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                Console.WriteLine("Balance:");
                customer.Balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Phone number:");
                customer.Phone = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Mail Id:");
                customer.Mail = Console.ReadLine();
                Console.WriteLine("Enter your Date of Birth:");
                customer.DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                customerList.Add(customer);
                Console.WriteLine("You have successfully Registered: Your Customer Id is" + customer.CustomerId);
                Console.WriteLine("Do you want to add another Customer:");
                Console.WriteLine("1.Registration\n2.Login\n3.Exit");
                n = Console.ReadLine();
                option = Console.ReadLine();
                
            } while (option == "yes");
            
        }   
        else if (n== "Login")
        {
            List<CustomerDetails> customerList = new List<CustomerDetails>();
            string option = "";
            do
            {
                Console.WriteLine("Enter Customer ID:");
                string LoginId = Console.ReadLine();
                bool flag = true;
                foreach (CustomerDetails customer in customerList)
            {
                if (customer.CustomerId== LoginId)
                {
                    flag = false;
                    Console.WriteLine("1.Deposit\n2.Withdraw\n3.Balance Check\n4.Exit");
                    string a = Console.ReadLine();
                    if(a=="Deposit"){
                        Console.WriteLine("Enter the Deposit Amount: ");
                        int deposit = int.Parse(Console.ReadLine());
                        int depositAmount = customer.Balance + deposit;

                    }
                    else if(a=="Withdraw"){
                        int withdraw = int.Parse(Console.ReadLine());
                        int withdrawAmount = customer.Balance-withdraw;
                    }
                    else if(a=="Balance"){
                        Console.WriteLine(customer.Balance);

                    }
                    else{

                    }
                    

                }
            }
            if(flag){
                Console.WriteLine("Invalid User Id");
            }
            Console.WriteLine("1.Registration\n2.Login\n3.Exit");
            n = Console.ReadLine();
            } while (option == "yes");            
        }
        else{

        }

            
        }

    }

    
