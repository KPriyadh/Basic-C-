using System;
using System.Data.Common;
namespace datetimeassignment{
    class Program{
        public static void Main(string[] args)
        {
            DateTime dds = new DateTime(2021,8,10,10,40,32);
            Console.WriteLine(dds.Year);//("yyyy/MM/dd hh:mm:ss tt"))
            Console.WriteLine(dds.Month);
            Console.WriteLine(dds.Day);
            Console.WriteLine(dds.Hour);
            Console.WriteLine(dds.Minute);
            Console.WriteLine(dds.Second);

            
            
            Console.WriteLine(dds.ToString("yyyy/MM/dd hh:mm:ss tt"));
            string[] arr
            for(int i=0; i<arr.Length-1;i--){
                Console.WriteLine(i);
            }

            
            Console.WriteLine("Reversed time:");
            Console.WriteLine(dds.ToString("tt ss:mm:hh dd/MM/yyyy"));
            Console.WriteLine("Enter the date:yyyy/mm/dd hh:mm:ss tt");

            DateTime ds = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
            Console.WriteLine(ds.ToString("yyyy/MM/dd"));
            

        }
    }
}