using System;
using System.Runtime.Serialization.DataContracts;
namespace ReadAndWrite{
    class Program{
        public static void Main(string[] args)
        {   
            System.Console.Write("Enter your name:");
            
            string name = Console.ReadLine();
            System.Console.Write("Enter your father's name:");
            string fATHERnAME = Console.ReadLine();
            
            System.Console.WriteLine(name + " " +fATHERnAME);
            System.Console.WriteLine("");
            Console.ReadKey();
        }
    }

}
    