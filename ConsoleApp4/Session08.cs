using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_Programming
{

        internal class Session08()
        {
            static void Main8()
            {
                int chucnang;
                Console.WriteLine("nhap chuc nang ban muon dung:");
                chucnang = int.Parse(Console.ReadLine());
                if (chucnang == 1)
                { Session08_01(); }
                else if (chucnang == 2) { Session08_02(); }
                else if (chucnang == 3) { Session08_03(); }
                else if (chucnang == 4) { Session08_04(); }
                else if (chucnang == 5) { Session08_05(); }
                else if (chucnang == 6) { Session08_06(); }
                else if (chucnang == 8) { Session08_08(); }
            }
            /// <summary>
            ///  to input a string and print it.
            /// </summary>
            static void Session08_01()
            {
                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                Console.Write(chuoi);
            }
            /// <summary>
            /// - to find the length of a string without using a library function.
            /// </summary>
            static void Session08_02()
            {
                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                int count = 0;
                foreach (char c in chuoi)
                {
                    count++;
                }
                Console.Write($"[{chuoi}] co do dai la: {count}");
            }
            static void Session08_03()
            {
                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                Console.Write("Ban muon lay ky tu thu may: ");
                int i = int.Parse(Console.ReadLine());
                if (i < chuoi.Length)
                {
                    Console.Write(chuoi[i]);
                }
                else { Console.WriteLine("vui long nhap mot so nguyen duong hop le"); }
            }
            /// <summary>
            /// - to print individual characters of the string in reverse order.
            /// </summary>
            static void Session08_04()
            {

                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                int i;

                for (i = chuoi.Length-1; i >=0; i--)
                {
                    Console.Write(chuoi[i]);
                }
            }
            /// <summary>
            /// - to count the total number of words in a string
            /// </summary>
            static void Session08_05()
            {
                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                //Xu ly chuoi
                chuoi = chuoi.Trim();
                while (chuoi.IndexOf("  ")!= -1)
                {
                    chuoi = chuoi.Replace("  ", " ");
                }
                //Dem tu
                int count = 1;
                int x = chuoi.Length;
                for (int i = 0; i< x; i++)
                {
                    if (chuoi[i] == ' ')
                    { count++; }

                }
                Console.WriteLine($"tong so tu trong chuoi la {count}");
            }
            /// <summary>
            /// to compare two strings without using a string library functions
            /// </summary>
            static void Session08_06()
            {
                Console.Write("Nhap chuoi dau tien: ");
                string chuoi1 = Console.ReadLine();
                Console.Write("Nhap chuoi thu hai: ");
                string chuoi2 = Console.ReadLine();
                Console.WriteLine(Compare(chuoi1, chuoi2));
            }
            static int Compare(string chuoi1, string chuoi2)
            {
                int x;
                int kq = 0;
                if (chuoi1.Length <= chuoi2.Length)
                {
                    x = chuoi1.Length;  // Nếu chuỗi 1 dài hơn hoặc bằng chuỗi 2
                }
                else
                {
                    x = chuoi2.Length;  // Nếu chuỗi 2 dài hơn chuỗi 1
                }
                for (int i = 0; i < x; i++)
                {
                    if (chuoi1[i] > chuoi2[i]) { kq = 1; }
                    if (chuoi1[i] < chuoi2[i]) { kq = -1; }
                }
                return kq;


            }
        /// <summary>
        /// - to count the number of alphabets, digits and special characters in a string.
        /// </summary>
        static void Session08_08()
            {
                Console.Write("Nhap chuoi ban muon: ");
                string chuoi = Console.ReadLine();
                int chucai = 0;
                int so = 0;
                int kytu = 0;

                for (int i = 0; i <= chuoi.Length; i++)
                {

                    if (chuoi[i] > 'a' || chuoi[i] < 'z' || chuoi[i] > 'A' || chuoi[i] < 'Z')
                    {
                        chucai++;
                    }
                    else if (chuoi[i] > 0|| chuoi[i] < 9)
                    {
                        so++;
                    }
                    else
                    {
                        kytu++;
                    }
                    Console.Write($"So chu cai: {chucai}. So so: {so}, So ky tu {kytu} ");
                }
            }
        public static void CountVowelsAndConsonants(string s)
        {
            int vowels = 0, consonants = 0;
            foreach (char c in s.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        public static int CheckSubstring(string s, string sub)
        {
            return s.IndexOf(sub, StringComparison.Ordinal);
        }

        public static void CheckCharacter(char c)
        {
            if (char.IsLetter(c))
            {
                Console.WriteLine($"Character is an alphabet and is {(char.IsUpper(c) ? "uppercase" : "lowercase")}.");
            }
            else
            {
                Console.WriteLine("Character is not an alphabet.");
            }
        }

        public static int CountSubstringOccurrences(string s, string sub)
        {
            int count = 0, pos = 0;
            while ((pos = s.IndexOf(sub, pos, StringComparison.Ordinal)) != -1)
            {
                count++;
                pos += sub.Length;
            }
            return count;
        }

        public static string InsertSubstring(string s, string sub)
        {
            int pos = CheckSubstring(s, sub);
            return pos != -1 ? s.Insert(pos, sub) : s;
        }

        }

}
