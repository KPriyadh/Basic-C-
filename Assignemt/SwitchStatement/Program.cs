using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.DataContracts;
namespace SwitchStatement{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed:");
            char option = char.Parse(Console.ReadLine());
            switch(option){
                case '+':{
                    Console.WriteLine(num1+num2);
               
               }     break;
                    
                
                case '-':{
                    Console.WriteLine(num1-num2);
                    break;
                    
                }
                case '*':{
                    Console.WriteLine(num1+num2);
                    break;
                    
                }
                case '/':{
                    Console.WriteLine(num1+num2);
                    break;
                    
                }
                case '%':{
                    Console.WriteLine(num1+num2);
                    break;
                    
                }
                default:{
                    Console.WriteLine("Invalid Operation");
                    break;
                }
            }
        }
    }
}