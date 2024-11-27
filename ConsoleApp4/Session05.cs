using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{
    internal class Session05
    {
        static void Main4() // Điểm bắt đầu của chương trình
        {
            Console.WriteLine(@"Chon chuc nang ban muon:
1. Write a C# function to find the maximum of three numbers.
- Improve the next version that accept at least 1 parameter.
2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
4. Write a C# function to print
    1. all prime numbers that less than a number (enter prompt keyboard).
    2. the first N prime numbers
5. Write a C# function to check whether a number is ""Perfect"" or not. Then print
all perfect number that less than 1000.
6. Write a C# function to check whether a string is a pangram or not.
");
            double chucnang;
            chucnang=NhapSo("Nhap chuc nang ban muonn:");

            if (chucnang == 1) { Session04_01(); }
            else if (chucnang == 2) { Session04_02(); }
            else if (chucnang == 3) { Session04_03(); }
            else if (chucnang == 4) { Session04_04(); }
            else if (chucnang == 5) { Session04_05(); }
            else { Console.WriteLine("Vui long nhap mot so hop le (1-6)"); }

            /// <summary>
            /// Nhap so
            /// </summary>
            /// <returns>Doc so</returns>
            static double NhapSo(string prompt)
            {
                double number;
                while (true)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out number))
                    {
                        break;
                    }

                    else
                    { Console.WriteLine("Ban da nhap sai, vui long nhap lai"); }
                }
                return number;
            }
            static int NhapSoNguyen(string prompt)
            {
                int number;
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        break;
                    }

                    else
                    { Console.WriteLine("Ban da nhap sai, vui long nhap lai"); }
                }
                return number;
            }
            static void Session04_01()
            {
                double a = NhapSo("nhap so thu 1: ");
                double b = NhapSo("nhap so thu 2: ");
                double c = NhapSo("nhap so thu 3: ");
                Findmax(a, b, c);
            }
            static double Findmax(double a, double b, double c)
            {
                double max = 0;
                if (a > b && a > c)
                {
                    max = a;
                    Console.WriteLine($"{max} la so lon nhat");
                }
                else if (b > a && b > c)
                {
                    max = b;
                    Console.WriteLine($"{max} la so lon nhat");
                }
                else if (c>a && c > b)
                {
                    max = c;
                    Console.WriteLine($"{max} la so lon nhat");
                }
                return max;
            }
            static void Session04_02()
            {
                int n;
                while (true)
                {
                    n = NhapSoNguyen("Nhap so ban muon tinh: ");
                    if (n > 0)
                    {
                        break;
                    }

                    else { Console.Write("Vui long nhap lai so nguyen duong"); }
                }
                TinhGiaiThua(n);
                Console.WriteLine($"Giai thua cua {n} la {TinhGiaiThua(n)}");
            }
            static long TinhGiaiThua(int g)
            {
                long ketqua = 1;
                for (int i = 1; i <= g; i++)
                {
                    ketqua *= i;
                }
                return ketqua;
            }
            static void Session04_03()
            {
                int num = NhapSoNguyen("Hay nhap mot so nguyen duong: ");
                bool Chuan = Timsonguyento(num);
                if (Chuan)
                {
                    Console.WriteLine($"{num} la so nguyen to");
                }
                else { Console.WriteLine($"{num} khong phai so nguyen to"); }

            }
            static bool Timsonguyento(int snt)
            {
                if (snt <=1) return false;
                for (int i = 2; i < snt; i++)
                {
                    if (snt % i==0) return false;
                }
                return true;

            }
            static void Session04_04()
            {
                int a = NhapSoNguyen("Hay nhap mot so gioi han: ");
                int n = NhapSoNguyen("Hay nhap mot so de in ra N so nguyen to: ");
                Console.WriteLine($"Cac so nguyen to tu 1 - {a} la: ");
                for (int i = 1; i <= a; i++)
                {
                    bool SNT = Timsonguyento(i);
                    if (SNT)
                    {
                        Console.Write($" {i} ");
                    }
                }
                Console.WriteLine($"\n {n} so nguyen to dau tien la:");
                for (int count = 1; count <= n;)
                {
                    for (int i = 0; count<=n; i++)
                    {
                        bool SNT = Timsonguyento(i);
                        if (SNT)
                        {
                            count++;
                            Console.Write($" {i} ");
                        }
                    }
                }
            }


            ///
            static void Session04_05()
            {
                int n = NhapSoNguyen("Nhap so ban muon kiem tra");
                bool check = Checkperfectnumber(n);
                if (check)
                {
                    Console.WriteLine($"{n} la so hoan hao");
                }
                else
                {
                    Console.WriteLine($"{n} khong phai la so hoan hao");
                }
                int x;
                Console.WriteLine("cac so hoan hao be hon 1000 la: ");
                for (x = 1; x<=1000; x++)
                {
                    bool check2 = Checkperfectnumber(x);
                    if (check2 == true)
                    {
                        Console.WriteLine($" {x} ");
                    }
                }   
            }
            static bool Checkperfectnumber(int n)
            {
                int sum = 0;
                for (int i = 1; i<n; i++)
                {
                    if (n%i==0)
                    {
                        sum += i;
                    }
                }
                return sum==n;
            }
            static void Session04_06()
            {

            }
            static bool CheckPangram(string chuoi)
            {
                return true;
            }

        }
    }
}
