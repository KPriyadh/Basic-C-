using System;
using System.Security;
using System.Security.AccessControl;
using ValueAndReference;
namespace Valueandreference{
    class Program{
        public static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine(number1);
            int number2 = number1;
            Console.WriteLine(number2);
            number1=20;
            Console.WriteLine(number2);

            
        }
    }
}