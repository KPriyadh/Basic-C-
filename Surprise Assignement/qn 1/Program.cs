using System;
namespace surprise{
    class Program{
        public static void Main(string[] args)
        {
            int next, i, j;
        for (i = 0; i < n; i++) {
            next = -1;
            for (j = i + 1; j < n; j++) {
                if (arr[i] < arr[j]) {
                    next = arr[j];
                    break;
                }
            }
            Console.WriteLine(arr[i] + " -- " + next);
        }
    }
 
    // driver code
    public static void Main()
    {
        int[] arr = { 11, 13, 21, 3 };
        int n = arr.Length;
 
        printNGE(arr, n);
    }
        }

        
    }
            }
        }
    
