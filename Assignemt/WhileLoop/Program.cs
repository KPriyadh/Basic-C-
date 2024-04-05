using System;
namespace WhileLoop{
    class Program{
        public static void Main(string[] args)
        {
            int i=0;
            while(i<25){
                if(i%2==0){
                    Console.WriteLine(i);
                    
                }
                i++;
            }
            Console.WriteLine("Enter a number:");
            bool a = int.TryParse(Console.ReadLine(), out int b);
            
            while(!a){
                Console.WriteLine("Invalid input format! Enter Again");
                a = int.TryParse(Console.ReadLine(), out b);
            }
            

        }
            
    }
}
