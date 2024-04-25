using System;
namespace sys{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = Add(array);
        Console.WriteLine("The sum of elements in the array is: " + sum);
    }

    static int Add(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

        }
    }
}
        
    
