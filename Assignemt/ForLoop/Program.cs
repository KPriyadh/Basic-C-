using System;
namespace ForLoop{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());
            int sum=0;
            for(int i=number1;i<=number2;i++){
                sum+=(i*i)
                
            }
            Console.WriteLine(sum);
        }
        
    
    }
}
