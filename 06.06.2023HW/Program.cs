using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._06._2023HW
{
    class Task4
    {
        string nameSite;
        string pathSite;
        string descript;
        int ipSite;

        public void SetName() { nameSite = Console.ReadLine(); }
        public string GetName() { return nameSite; }
        public void SetPath() { pathSite = Console.ReadLine(); }
        public string GetPath() { return pathSite; }
        public void SetDesc() { descript = Console.ReadLine(); }
        public string GetDesc() { return descript; }
        public void SetIP() { ipSite = int.Parse(Console.ReadLine()); }
        public int GetIP() { return ipSite;}
        public void SetAll()
        {
            nameSite = Console.ReadLine();
            pathSite = Console.ReadLine();
            descript = Console.ReadLine();
            ipSite = int.Parse(Console.ReadLine());
        }
        public void ShowAll()
        {
            Console.WriteLine(nameSite);
            Console.WriteLine(pathSite);
            Console.WriteLine(descript);
            Console.WriteLine(ipSite);
        }
    }
    class Task5
    {
        string nameMagazine;
        int yearOsn;
        string opisanie;
        int number;
        string email;
        

        public void SetName() { nameMagazine = Console.ReadLine(); }
        public string GetName() { return nameMagazine; }
        public void SetOpis() { opisanie = Console.ReadLine(); }
        public string GetOpis() { return opisanie; }
        public void SetEmail() { email = Console.ReadLine(); }
        public string GetEmail() { return email; }
        public void SetYear() { yearOsn = int.Parse(Console.ReadLine()); }
        public int GetYear() { return yearOsn; }
        public void SetNumber() { number = int.Parse(Console.ReadLine()); }
        public int GetNumber() { return number; }
        public void SetAll()
        {
            nameMagazine = Console.ReadLine();
            opisanie = Console.ReadLine();
            email = Console.ReadLine();
            yearOsn = int.Parse(Console.ReadLine());
            number = int.Parse(Console.ReadLine());
        }
        public void ShowAll()
        {
            Console.WriteLine(nameMagazine);
            Console.WriteLine(opisanie);
            Console.WriteLine(email);
            Console.WriteLine(yearOsn);
            Console.WriteLine(number);
        }
    }
    class Task6
    {
        string nameShop;
        string adres;
        string opisanie;
        int number;
        string email;


        public void SetName() { nameShop = Console.ReadLine(); }
        public string GetName() { return nameShop; }
        public void SetOpis() { opisanie = Console.ReadLine(); }
        public string GetOpis() { return opisanie; }
        public void SetEmail() { email = Console.ReadLine(); }
        public string GetEmail() { return email; }
        public void SetAdres() { adres = Console.ReadLine(); }
        public string GetAdres() { return adres; }
        public void SetNumber() { number = int.Parse(Console.ReadLine()); }
        public int GetNumber() { return number; }
        public void SetAll()
        {
            nameShop = Console.ReadLine();
            opisanie = Console.ReadLine();
            email = Console.ReadLine();
            adres = Console.ReadLine();
            number = int.Parse(Console.ReadLine());
        }
        public void ShowAll()
        {
            Console.WriteLine(nameShop);
            Console.WriteLine(opisanie);
            Console.WriteLine(email);
            Console.WriteLine(adres);
            Console.WriteLine(number);
        }
    }
    internal class Program
    {
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
