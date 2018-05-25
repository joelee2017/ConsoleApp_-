using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_不使用系統函式
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tAry = new int[] { 7, 1, 8, 10, 3, 5, 2, 11, 6, 4, 9 };

            for(int i = 0; i <= tAry.Length; i++)
            {
                for(int k = i+1; k <= tAry.Length; k++)
                {
                   if(k > i)
                    {
                        Console.WriteLine($"{k}");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
