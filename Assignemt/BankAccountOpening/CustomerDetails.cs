using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening

{
    public enum Gender{select, Male, Female, Transgender}
    public class CustomerDetails
    {
        private static int _customerId = 1001;

        public string CustomerId{get; }
        public string CustomerName{get; set;}
        public int Balance{get; set;}
        public Gender Gender{get; set;}               
        public long Phone{get; set;}
        public string Mail{get; set;}
        public DateTime DOB{get; set;}

        public CustomerDetails(){
            CustomerName="Enter your name";
        }
        public  CustomerDetails(string customerName, int balance, Gender gender, long phone, string mail, DateTime dob ){
            _customerId++;
            CustomerId = "HDFC"+_customerId;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            Mail=mail;
            DOB=dob;
        }
        
    }
}