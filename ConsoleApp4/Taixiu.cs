using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{
    internal class Taixiu
    {
        static void Main9(string[] args)
        {

            
            game_engine();
        }
        static int rolldice()
        {
            Random rnd = new Random(); 
            int die1 = rnd.Next(6) + 1;
            int die2 = rnd.Next(6) + 1;
            int die3 = rnd.Next(6) + 1;
            int sum = die1 + die2 + die3;
            return sum;
        }
        static void playoneround()
        {
            int tienconlai = NapTien();
            int ketqua = 0;
            Console.WriteLine("van nay ban muon cuoc bao nhieu: ");
            int tiencuoc;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out tiencuoc)&& tiencuoc >0)
                {

                    break;
                }
                else { Console.WriteLine("vui long nhap mot so nguyen duong"); }

            }
            while (true)
            {
                int numberdice = rolldice();
            Console.WriteLine("ban doan tai hay xiu (T/X)");
            string answer = Console.ReadLine();
                
                if (answer.ToUpper().Equals("T"))
                {
                    if (numberdice >=10) //tài
                    {
                        Console.WriteLine("ban thang");
                        ketqua = 1;
                    }
                    else {
                        Console.WriteLine("ban thua");
                        ketqua = -1;     }
                    break;
                }
                else if (answer.ToUpper().Equals("X"))
                {
                    if (numberdice <= 10) //xỉu
                    { Console.WriteLine("ban thang"); ketqua = 1; }
                    else { Console.WriteLine("ban thua"); ketqua = -1; }
                    break;
                }

                else
                {
                    Console.WriteLine("vui long chon cho dung (T/X), hay nhap lai");

                }
            }
            if (ketqua == -1)
            {
                tienconlai -= tiencuoc;
            }
            else if (ketqua == 1)
            { tienconlai += tiencuoc; }
            Console.WriteLine($"Ban con lai so tien la {tienconlai} ");

        }
        static void game_engine()
        {
            do 
            {
                NapTien();
                playoneround();

             
                    Console.WriteLine("choi nua khong? (C/K)");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            } 
                while (true);
        }
        static int NapTien()
        {
            int tien;
            while (true)
            {
                
                if (int.TryParse(Console.ReadLine(), out tien)&& tien >0)
                {
                    return tien;
                    break;
                }
                else { Console.WriteLine("hay nap mot so tien hop le"); }

            }
            return tien; 
        }

        
    }
}
