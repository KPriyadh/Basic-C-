using System;
namespace String{
    class Program{
        public static void Main(string[] args)
        {
            string a =Console.ReadLine();
            string b = Console.ReadLine();
            int count=0;
            
            
            for (int i = 0; i < a.Length - b.Length + 1; i++)
            {
                
                if (a.Substring(i, b.Length) == b)
                {
                    count++;
                    
                    
                    
                }
                
            
            
                
            } 
            Console.WriteLine(count);
            

            
        }
        }
    }
