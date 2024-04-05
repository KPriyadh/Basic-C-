using System;
namespace da;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        string a = Console.ReadLine();
        string[] b = a.Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(b[i]);
        }

        int j = arr[0];

        string s = "";
        for (int i = 1; i <= n; i++)
        {
            if (j > arr[i])
            {
                s += j + " ";

                j = arr[i];
            }
            else
            {
                s += arr[i] + " ";
                j = arr[i];
            }
        }
        Console.WriteLine(s.TrimEnd());
    }
}
