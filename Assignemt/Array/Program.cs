using System;
using System.Security;
namespace Array{
    class Program{
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] name = new string[size];
            for(int k=0; k<5;k++){
                name[k] = Console.ReadLine();
            }
            Console.WriteLine("Enter a name:");
            string a = Console.ReadLine();
            bool flag = true;
            foreach(string i in name){
                if(i==a){
                    flag=false;
                    Console.WriteLine("The name is present in array");


                }
                else{
                    Console.WriteLine("The name is not present in array");
                }
            }
                for(int j=0; j<5;j++){
                    if(name[j]==a){
                        Console.WriteLine("The name is present in array");
                    }
                    else{
                        Console.WriteLine("The name is not present in array");
                }

                    }
                
            }
            

            

        }
    }
