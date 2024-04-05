using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;
namespace Method{
    class Program{
        public static void Main(string[] args)
        {
            float a = int.Parse(Console.ReadLine());
            float b = int.Parse(Console.ReadLine());
            double result = Mul(a,b);
            Console.WriteLine(result);
            Div(a,b);  
            
            Console.WriteLine($(Sub())); 
            welcome();        
            }
            static double Mul(float x,float y){
                double c = x*y;
                return c;
            }

            static void Div(float l, float m){

                double d = l/m;
                Console.WriteLine(d);

            }
            static int k=30;
            static int l = 40;
            static double Sub(){
                double value1 = k-l;

             
            return value1;
            }
            static void welcome(){
                Console.WriteLine("welcome");
            }
        
    }
}
