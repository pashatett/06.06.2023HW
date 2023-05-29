using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._06._2023HW
{
    internal class Program
    {
        //012345
        static void task1(int Len, char sym)
        {
            char[,] arr = new char[Len, Len];
            for (int i = 0; i < Len; i++)
                for (int j = 0; j < Len; j++)
                    arr[i, j] = sym;

            for (int i = 0; i < Len; i++)
            {
                for (int j = 0; j < Len; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void task2(int num)
        {
            string a = num.ToString();
            int k = 0;
            int f = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[f]) k += 0;
                else k++;
                f--;
            }
            if (k == 0) Console.WriteLine("Палиндром");
            else Console.WriteLine("Не палиндром");
        }
        static void task3(int[] origArr, int[] filtArr)
        {
            int[] newArr = new int[origArr.Length];
            int f = 0;
            for (int i = 0; i < origArr.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < filtArr.Length; j++)
                {
                    if (origArr[i] != filtArr[j]) k++;
                    if (k == filtArr.Length)
                    {
                        newArr[f] = origArr[i];
                        f++;
                    }
                }
            }
            for (int i = 0; i < newArr.Length - 1; i++)
                Console.Write(newArr[i] + " ");
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 2 };
            task3(a, b);
            Console.ReadKey();
        }
    }
}
