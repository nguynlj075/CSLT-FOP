using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{
    internal class Session07_03
    {
        public static void Main73()
        {
            int[,] a;
            Console.Write("Nhap so dong: _"); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: _"); int columns = int.Parse(Console.ReadLine());
            a = new int[rows, columns];
            nhapmangtudong(a, rows, columns);
            xuatmang(a);
            Console.Write("In dong hay cot? <row/col>____");
            string opt = Console.ReadLine();
            if (opt.ToLower().Equals("row"))
            {
                Console.Write("Nhap dong can in: "); int yc = int.Parse(Console.ReadLine());
                indong(a, yc);
            }
            else if (opt.ToLower().Equals("col"))
            {
                Console.Write("Nhap so cot can in: "); int yc = int.Parse(Console.ReadLine());
                incot(a, yc);
            }
            Console.Write("Muon tim max dong hay max cot? <<row/col>>___"); string timmax = Console.ReadLine();
            if (timmax.ToLower().Equals("row"))
            {
                Console.Write("Nhap dong: "); int yc = int.Parse(Console.ReadLine());
                Console.WriteLine($"Max dong {yc} la {maxdong(a, yc)}");
            }
            else if (timmax.ToLower().Equals("col"))
            {
                Console.Write("Nhap so cot: "); int yc = int.Parse(Console.ReadLine());
                Console.WriteLine($"Max cot {yc} la {maxcot(a, yc)}");
            }

            Console.Write("Tim min dong hay min cot? <<row/col>>"); string timmin = Console.ReadLine();
            if (timmin.ToLower().Equals("row"))
            {
                Console.Write("Nhap dong : "); int yc = int.Parse(Console.ReadLine());
                Console.WriteLine($"Min dong {yc} la {mindong(a, yc)}");
            }
            else if (timmin.ToLower().Equals("col"))
            {
                Console.Write("Nhap so cot: "); int yc = int.Parse(Console.ReadLine());
                Console.WriteLine($"Min cot {yc} la {mincot(a, yc)}");
            }
            Console.WriteLine("ma tran chuyen vi cua a la: ");
            xuatmang(chuyenvi(a));
            Console.WriteLine("In duong cheo chinh/phu");
            induongcheo(a);
        }
        /// <summary>
        /// Tạo mảng có phần tử được tạo ngẫu nhiên tự động
        /// </summary>
        /// <param name="a"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public static void nhapmangtudong(int[,] a, int rows, int columns)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0, 100);
                }
            }
        }
        /// <summary>
        /// In mảng 
        /// </summary>
        /// <param name="a"></param>
        static void xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// In 1 dòng bất kỳ theo yêu cầu
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        static void indong(int[,] a, int i)
        {
            Console.WriteLine($"Dong {i} la:  ");
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// In cột bất kỳ theo yêu cầu
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        static void incot(int[,] a, int i)
        {
            Console.WriteLine($"Dong {i} la:  ");
            for (int j = 0; j < a.GetLength(0); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        static int timMax(int[,] a)
        {
            int max = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }
            return max;
        }
        static int maxdong(int[,] a, int i)
        {
            int max = 0;
            for (int j = 0; j < a.GetLength(0); j++)
            {
                if (a[i, j] > max)
                    max = a[i, j];
            }
            return max;
        }
        static int mindong(int[,] a, int i)
        {
            int min = 0;
            for (int j = 0; j < a.GetLength(0); j++)
            {
                if (a[i, j] < min)
                    min = a[i, j];
            }
            return min;
        }
        static int maxcot(int[,] a, int j)
        {
            int max = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] > max)
                    max = a[i, j];
            }
            return max;
        }
        static int mincot(int[,] a, int j)
        {
            int min = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] < min)
                    min = a[i, j];
            }
            return min;
        }
        static int[,] chuyenvi(int[,] a)
        {
            int[,] T = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    T[j, i] = a[i, j];
                }
            }
            return T;
        }
        /// <summary>
        /// Tìm đường chéo chính/đường chéo phụ của một mảng
        /// </summary>
        /// <param name="a"></param>
        static void induongcheo(int[,] a)
        {
            if (a.GetLength(0) == a.GetLength(1))
            {
                Console.Write("In duong cheo chinh hay phu <C/P____");
                string opt = Console.ReadLine();
                do
                {
                    if (opt != string.Empty&&"cp".Contains(opt.ToLower())) break;
                    else Console.WriteLine("Hay nhap yeu cau.");
                } while (true);
                if (opt.ToLower().Equals("c"))
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        Console.Write(a[j, j] + "\t");
                    }
                }
                else if (opt.ToLower().Equals("p"))
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        for (int k = 0; k < a.GetLength(1); k++)
                        {
                            if (k == a.GetLength(0) - 1 - j)
                                Console.Write($"{a[j, k]} \t");
                        }
                    }
                }
            }
            else Console.WriteLine("Day khong phai ma tran vuong");
        }
    }
}
