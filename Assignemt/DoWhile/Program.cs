using System;
namespace DoWhile{
    class Program{
        public static void Main(string[] args)
        {
            
            
            do{
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if(number%2!=0){
                    Console.WriteLine("ODD");
                }
                else{
                    Console.WriteLine("EVEN");

                }
                Console.WriteLine("Do you want to check for another number? yes/no");
                string a = Console.ReadLine();
                if(a=="no"){
                    break;
                }
                else if(a=="yes"){
                    continue;
                }
                else{
                    Console.WriteLine("Invalid option Enter again:");
                    Console.ReadLine();
                    continue;

                }
                
            }while(true);
        }
    }
}