using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers :");
            int[] arr = new int[8];
            string arr1 = "";
            for (int i = 0; i < 8; i++)
            {
                arr1 = Console.ReadLine();
                arr[i] = Convert.ToInt32(arr1);
            }

            int a, b, temp = 0;
            Console.WriteLine();
            for (a = 0; a < arr.Length; a++)
            {
                for (b = a + 1; b < arr.Length; b++)
                {
                    if (arr[a] > arr[b])
                    {
                        temp = arr[a];
                        arr[a] = arr[b];
                        arr[b] = temp;
                    }
                }
                Console.WriteLine(arr[a]);
            }
            Console.ReadLine();
        }
    }
} 
       