using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{
    internal class Session07_02
    {
        /*
        //Nhập mảng từ bản phím
        static void NhapMangBangCom(int[,] a, int rows, int columns)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j} = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //In mảng ra màn hình
        static void XuatMang(int[,] a)
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

        //Tìm các vị trí mà giá trị value xuất hiện
        static void SearchLinear(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j <= a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}");
                        return;
                    }
                }
            }
        }

        //Nhập mảng ngẫu nhiên
        static void NhapMangNgauNhien(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }

        public static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int columns = int.Parse(Console.ReadLine());
            //Tạo mảng 2 chiều
            a = new int[rows, columns];
            NhapMangNgauNhien(a, rows, columns);
            Console.WriteLine("Mang tao duoc la: ");
            XuatMang(a);
            Console.Write("So can tim la: ");
            int val = int.Parse(Console.ReadLine());
            SearchLinear(a, val);
        }*/


            static void NhapMangNgauNhien(int[,] a, int rows, int colums)
            {
                Random random = new Random();
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = random.Next(0, 100);
                    }
                }
            }

            static void XuatMang(int[,] a)
            {
                int dong = a.GetLength(0);
                int cot = a.GetLength(1);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            static void XuatDong(int[,] a, int dong)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (dong == i)
                            Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            static void XuatCot(int[,] a, int cot)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (cot == i)
                            Console.WriteLine(a[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            //Hàm tìm giá trị lớn nhất trong mảng
            static int TimMax(int[,] a)
            {
                int max = a[0, 0]; //Giả sử phần tử đầu tiên là lớn nhất
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                }
                return max;
            }

            //Hàm tìm giá trị nhỏ nhất trong một dòng
            static int TimMinDong(int[,] a, int dong)
            {
                int min = a[dong, 0];
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (a[dong, j] < min)
                    {
                        min = a[dong, j];
                    }
                }
                return min;
            }

            //Hàm tìm giá trị nhỏ nhất trong một cột
            static int TimMinCot(int[,] a, int cot)
            {
                int min = a[0, cot];
                for (int i = 1; i < a.GetLength(0); i++)
                {
                    if (a[i, cot] < min)
                    {
                        min = a[i, cot];
                    }
                }
                return min;
            }

            //Chuyển vị ma trận
            static int[,] ChuyenViMaTran(int[,] a)
            {
                int soDong = a.GetLength(0);
                int soCot = a.GetLength(1);
                int[,] matranchuyenvi = new int[soCot, soDong];
                for (int i = 0; i < soDong; i++)
                {
                    for (int j = 0; j < soCot; j++)
                    {
                        matranchuyenvi[j, i] = a[i, j];
                    }
                }
                return matranchuyenvi;
            }

            static void InDuongCheo(int[,] a)
            {
                int soDong = a.GetLength(0);
                int soCot = a.GetLength(1);
                if (soDong != soCot)
                {
                    Console.WriteLine("Ma tran khong phai la ma tran vuong. Ma tran khong co duong cheo chinh va duong cheo phu");
                    return;
                }
                Console.WriteLine("Cac gia tri tren duong cheo chinh");
                for (int i = 0; i < soDong; i++)
                {
                    Console.WriteLine(a[i, i] + "\t");
                }
                Console.WriteLine("Cac gia tri tren duong cheo phu");
                for (int i = 0; i < soDong; i++)
                {
                    Console.WriteLine(a[i, soDong - 1 - i] + "\t");
                }
            }

            static void Main72(string[] args)
            {
                int[,] a;
                Console.WriteLine("NHAP MA TRAN: ");
                Console.Write("Nhap so dong: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot: ");
                int cols = int.Parse(Console.ReadLine());
                a = new int[rows, cols];
                NhapMangNgauNhien(a, rows, cols);
                XuatMang(a);
                Console.WriteLine();

                Console.WriteLine("IN HANG TRONG MA TRAN");
                int dong = int.Parse(Console.ReadLine());
                XuatDong(a, dong);
                Console.Write($"Nhap chi so hang muon in: {dong}");
                Console.WriteLine();

                Console.WriteLine("IN COT TRONG MA TRAN");
                int cot = int.Parse(Console.ReadLine());
                XuatCot(a, cot);
                Console.WriteLine();

                Console.WriteLine("TIM GIA TRI MAX TRONG MA TRAN");
                int max = TimMax(a);
                Console.WriteLine($"Gia tri lon nhat trong ma tran la: {max}");
                Console.WriteLine();

                Console.WriteLine("TIM GIA TRI MIN THEO DONG TRONG MA TRAN");
                int mindong = TimMinDong(a, dong);
                Console.WriteLine($"Gia tri nho nhat theo dong trong ma tran la: {mindong}");
                Console.WriteLine();

                Console.WriteLine("TIM GIA TRI MIN THEO COT TRONG MA TRAN");
                int mincot = TimMinCot(a, cot);
                Console.Write($"Gia tri nho nhat theo cot trong ma tran la: {mincot}");
                Console.WriteLine();

                Console.WriteLine("MA TRAN CHUYEN VI");
                int[,] matranchuyenvi = ChuyenViMaTran(a);
                Console.WriteLine("Ma tran sau khi chuyen vi la: ");
                XuatMang(matranchuyenvi);
                Console.WriteLine();

                Console.WriteLine("IN RA CÁC DUONG CHEO CHINH VA DUONG CHEO PHU");
                InDuongCheo(a);
                Console.ReadKey();
            }
        }
    }

