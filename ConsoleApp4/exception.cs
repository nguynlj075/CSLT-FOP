using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{
    internal class exception
    {
        static void Main77(string[] args)
        {
            //NgoaiLe();
            //while (true)
            //{
                try
                {
                    NgoaiLe2();

                }
                catch (Exception loi)
                { Console.WriteLine(loi.Message); }
                
            
                finally { Console.Write("\n nhap lai dum di "); }
        
            
        }
        static void NgoaiLe()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("moi nhap vao ngay thang nam sinh:");
                    string s = Console.ReadLine();
                    DateTime ngaysinh = DateTime.Parse(s);
                    Console.WriteLine("ngay sinh cua ban la:" + ngaysinh.ToString("dd/MM/yyyy"));
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally // chương trình vẫn sẽ chạy dù báo lỗi
                {
                    Console.WriteLine("\n vui long nhap dang hoang lai di a");
                }
            }
        }
            static void NgoaiLe2()
            {
                Console.WriteLine("nhap tu so");
                int tu = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so");
                int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
                throw new Exception("nhaplai di");
               
            }
         
    }
}
