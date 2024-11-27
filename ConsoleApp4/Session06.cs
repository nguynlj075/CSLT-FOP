using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fundamentals_of_Programming
{
    internal class Session06
    {
        static void Main(string[] args)
        {
            //nhap mang

            int[] mang1 = NhapMangBangTay();
            //trung binh
            Console.WriteLine($"trung binh cua mang la {Tinhtrungbinh(mang1)}");
            //tim vi tri
            int key;
            Console.WriteLine(" nhap so ban muon tim vi tri: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out key)) { break; }
                else { Console.Write("\n Nhap sai, vui long nhap lai"); }
            
            if (checkvar(mang1, key))
            {
                int Findindex = findindex(mang1, key);
                if (Findindex != -1)
                {
                    Console.WriteLine($"gia tri nam o vi tri thu {Findindex +1}");

                }
                else
                {
                    Console.WriteLine("khong ton tai gia tri");
                }
            }
                //xoa ky tu trong mang
                int remove;
                Console.WriteLine(" nhap so ban muon tim xoa: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out remove)) { break; }
                    else { Console.Write("\n Nhap sai, vui long nhap lai"); }
                }
                Console.WriteLine("mang moi sau khi xoa la:");
           
                foreach (int x in Xoakytu(mang1, remove))
                {
                    Console.Write($"{x} ");
                }

                //So lon nhat và nho nhat trong mang
                Console.WriteLine($"so lon nhat trong mang la {max(mang1)}");
                Console.WriteLine($"so nho nhat trong mang la {min(mang1)}");
                //Dao nguoc chuoi
                Console.WriteLine("\n chuoi sau khi dao nguoc lai:");
                daonguoc(mang1);
                //To find duplicate values in an array of values

            }
        }
        static int[] NhapMangBangTay()
        {
            int kichthuoc;
            while (true)
            {

                Console.Write("Nhap kich thuoc cua mang:");
                if (int.TryParse(Console.ReadLine(), out kichthuoc) && kichthuoc > 0) { break; }
                else { Console.Write("\n Nhap sai, vui long nhap lai"); }
            }
            int[] mang = new int[kichthuoc];
            for (int i = 0; i < kichthuoc; i++)
            {

                while (true)
                {
                    Console.WriteLine($"nhap phan tu thu {i+1} : ");
                    if (int.TryParse(Console.ReadLine(), out mang[i])) { break; }
                    else { Console.WriteLine("\n Nhap sai, vui long nhap lai"); }
                }
            }
            foreach (int so in mang)
            {
                Console.Write(so);
                Console.Write(" ");
            }
            return mang;
        }
        static bool checkvar(int[] mang, int key)
        {
            for(int i = 0;i < mang.Length; i++)
            {
                if (mang[i] == key)
                    return true;
                
            } 
            return false;
                
        }
        static int[] Nhapmangtudong(int so1, int so2)
        {
            int kichthuoc;
            while (true)
            {

                Console.Write("Nhap kich thuoc cua mang:");
                if (int.TryParse(Console.ReadLine(), out kichthuoc) && kichthuoc > 0) { break; }
                else { Console.Write("\n Nhap sai, vui long nhap lai"); }
            }
            int[] mang = new int[kichthuoc];
            Random rnd = new Random();
            for (int i = 0; i < kichthuoc; i++)
            {
                mang[i] = rnd.Next(so1, so2);
            }
            foreach (int so in mang)
            {
                Console.Write(so);
                Console.Write(" ");
            }
            return mang;
        }
        static double Tinhtrungbinh(int[] mang)
        {
            double tong = 0;
            double trungbinh = 0;
            for (int i = 0; i<mang.Length; i++)
            {
                tong += mang[i];
            }
            trungbinh = tong/mang.Length;

            return trungbinh;
        }
        static int findindex(int[] mang, int key)
        {
            for (int i = 0; i<mang.Length; i++)
            {
                if (mang[i] == key) return i;
            }
            return -1;

        }


        static int[] Xoakytu(int[] mang, int remove)
        {
            // Sử dụng List để đơn giản hóa việc xây dựng mảng mới
            List<int> mangMoi = new List<int>();

            foreach (int item in mang)
            {
                if (item != remove)
                {
                    mangMoi.Add(item); // Thêm phần tử không cần xóa vào danh sách mới
                }
            }

            // Chuyển List thành mảng và trả về kết quả
            return mangMoi.ToArray();
        
        }
        static int max(int[] mang)
        {
            int max = mang[0];
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang == null || mang.Length == 0)
                {
                    throw new ArgumentException("Invalid Value, Empty Array!");
                }
                
               
                    if (mang[i] > max)  
                { max = mang[i]; }    

            }

            return max;
        }
        static int min(int[] mang)
        {
            int min = mang[0];
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang == null || mang.Length == 0)
                {
                    throw new ArgumentException("Invalid Value, Empty Array!");
                }


                if (mang[i] < min)
                { min = mang[i]; }

            }

            return min;
        }
        static void daonguoc(int[] mang)
        {
            
            for (int i = mang.Length-1; i >= 0; i--)
            {
                Console.Write($" {mang[i]} ");
            }
        }
            

        public static int[] timgiatrilaplai(int[] a)
        {
            int count = 0;
            int[] lap = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        // ktra có chép trùng không
                        bool trung = false;
                        for (int k = 0; k < count; k++)
                        {
                            if (lap[k] == a[i])
                            {
                                trung = true;
                                break;
                            }
                        }

                        if (!trung)
                        {
                            lap[count] = a[i];
                            count++;
                        }

                        break;
                    }
                }
            }
            // mảng mới chỉ có gtri lặp
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = lap[i];
            }

            return result;
        }
        public static int[] xoaphantulap(int[] a)
        {
            int n = timgiatrilaplai(a).Length;
            int[] result = a;
            foreach (int i in timgiatrilaplai(a))
            {
                for (int j = 0; j < a.Length; j++)
                {
                    result = Xoakytu(result, i);
                }
            }
            return result;
        }

    }
}