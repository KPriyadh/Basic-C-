using System;
namespace TypeConversion{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject1:");
            float mark1 = float.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject2:");
            float mark2 = float.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject3:");
            float mark3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Grade:");
            char grade = char.Parse(Console.ReadLine());
            Console.Write("Enter mobile number:");
            string mobile = Console.ReadLine();
            Console.Write("Enter Mail id:");
            string mail = Console.ReadLine();

            Console.WriteLine("Trainee Details are:");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Mobile:" + mobile);
            Console.WriteLine("Marks1:" + mark1);
            Console.WriteLine("Marks2:" + mark2);
            Console.WriteLine("Marks3:" + mark3);
            
            Console.WriteLine("Total:");
            Console.WriteLine(mark1+mark2+mark3);
            
            Console.WriteLine("Average:");
            Console.WriteLine((mark1+mark2+mark3)/3);
            Console.WriteLine("Grade:" + grade);
            Console.WriteLine("Mail id:" + mail);


        }
    }
}