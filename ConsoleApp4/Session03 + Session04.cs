namespace Fundamentals_of_Programming
{
    internal class Session03
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Nhap chuc nang ban muon : (1-10)");
            if (int.TryParse(Console.ReadLine(), out int chucnang))
            {
                switch (chucnang)
                {
                    case 1:
                        Session03_01();
                        break;
                    case 2:
                        Session03_02();
                        break;
                    case 3:
                        Session03_03();
                        break;
                    case 4:
                        Session03_04();
                        break;
                    case 5:
                        Session03_05();
                        break;
                    case 6:
                        Session03_06();
                        break;
                    case 7:
                        Session03_07(0);
                        break;
                    case 8:
                        Session03_08();
                        break;
                    case 9:
                        Session03_09();
                        break;
                    case 10:
                        Session03_10();
                        break;
                    case 11:
                        Session03_11();
                        break;
                    case 12:
                        Session03_12();
                        break;
                    case 13:
                        Session03_13();
                        break;
                    case 14:
                        Session03_14();
                        break;
                    default:
                        Console.WriteLine("Vui long chon so tu 1-10");
                        break;
                }
            }
            else { Console.WriteLine("Vui long nhap so tu 1-10"); }
        }
        /// <summary>
        /// tính cộng trừ nhân chia
        /// </summary>
        static void Session03_01()
        {
            Console.Write("Nhap so dau tien:");
            if (Double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Nhap so thu hai:");
                if (Double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($@" {num1}+{num2}={num1+num2}
{num1}-{num2}={num1-num2};
{num1}*{num2}={num1* num2}
{num1}/{num2}={num1/num2};
{num1}%{num2}={num1%num2};");
                }
                else { Console.WriteLine("Vui long nhap so hop le"); }
            }
            else { Console.WriteLine("Vui long nhap so hop le"); }
        }
        /// <summary>
        /// Tính x = y^2 + 2y + 1 với y = -5 -> 5
        /// </summary>
        static void Session03_02()
        {
            int y;
            for (y=-5; y<=5; y++) //for (khởi tạo; điểm dừng (điều kiện lặp), bước lặp)
            {
                int x = y*y + 2*y +1;
                Console.WriteLine($@" x = y^2 + 2y + 1
Voi y = {y} thi x = {x}");
            }
        }
        /// <summary>
        /// Tính vận tốc
        /// </summary>
        static void Session03_03()
        {
            Console.Write("Nhap so km:");
            if (Double.TryParse(Console.ReadLine(), out double km))
            {
                Console.Write("Nhap so gio:");
                if (Double.TryParse(Console.ReadLine(), out double gio))
                {
                    double kmh = km/gio;
                    Console.WriteLine($"Van toc km/h la {kmh} km/h");
                    double milesperhour = 0.621371*kmh;
                    Console.WriteLine($"van toc m/h la {milesperhour} miles/h");
                }
                else { Console.WriteLine("Vui long nhap so hop le"); }
            }
            else { Console.WriteLine("Vui long nhap so hop le"); }
        }


        /// <summary>
        /// a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere. V =4/3*π*r
        /// </summary>
        static void Session03_04()
        {
            {
                Console.WriteLine(@"chon chuc nang ban muon
1. Tinh dien tich
2. Tinh the tich");
                if (double.TryParse(Console.ReadLine(), out double choice))
                {
                    if
                    (choice == 1)
                    {
                        Console.WriteLine("nhap ban kinh hinh cau can tinh");
                        if (double.TryParse(Console.ReadLine(), out double r))
                        {
                            double s = 4 * Math.PI * Math.Pow(r, 2); // 4 * Pi x R bình
                            Console.WriteLine($"dien tich hinh cau la {s}");
                        }
                        else
                        {
                            Console.WriteLine("Vui long nhap so hop le");
                        }
                    }
                    else if (choice ==2)
                    {
                        Console.WriteLine("nhap ban kinh hinh cau can tinh");
                        if (double.TryParse(Console.ReadLine(), out double r))
                        {
                            double v = 4/3 * Math.PI * Math.Pow(r, 3); // 4/3 * Pi x R mũ 3
                            Console.WriteLine($"the tich hinh cau la {v}");
                        }
                        else
                        {
                            Console.WriteLine("Vui long nhap so hop le");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap so hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap so hop le");
                }
            }
        }
        /// <summary>
        ///  a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        static void Session03_05()
        {
            Console.Write("Nhap mot chu cai:");
            char input = Console.ReadKey().KeyChar; //nhận ký tự
            if (input >= '0' && input <= '9')
            {
                Console.WriteLine($"=>{input} la chu so");
            }
            else if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' ||
                             input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
            {
                Console.WriteLine($"{input} la nguyen am");
            }
            else if (input >= 'a' && input <= 'z'|| input >= 'A' && input <= 'Z')
            {
                Console.WriteLine($"{input} la phu am");
            }
            else
            { Console.WriteLine($"{input} la ky tu khac"); }

        }
        /// <summary>
        /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene
        /// </summary>
        static void Session03_06()
        {
            Console.Write("nhap canh thu nhat:");
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                Console.Write("nhap canh thu hai:");
                if (double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.Write("nhap canh thu ba:");
                    if (double.TryParse(Console.ReadLine(), out double c))
                    {
                        //kiem tra xem canh co dung khong
                        if (a<=0  || b <= 0 || c <= 0)
                        {
                            Console.WriteLine("canh cua tam giac phai lon hon 0, vui long nhap lai");
                            return;
                        }
                        //Kiểm tra xem có phải tam giác không
                        if (a+b > c && a+ c > b && c+b > a)
                        {
                            Console.WriteLine("3 canh hop le, day la 1 tam giac");
                        }
                        if (a == b && b == c)
                        {
                            Console.WriteLine("day la tam giac deu");
                            return;
                        }
                        if (a ==b || b == c || c == a)
                        {
                            Console.WriteLine("day la tam giac can");
                        }
                        else
                        {
                            Console.WriteLine("day la tam giac thuong");
                        }

                    }
                }
                else { Console.WriteLine("vui long nhap canh hop le"); }
            }
            else { Console.WriteLine("vui long nhap canh hop le"); }
        }
        /// <summary>
        ///  Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        static void Session03_07(double sum)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap so thu {i+1}: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    sum += number;  // Cộng vào
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so hop le!");
                    i--; //Trừ một đi để lặp lại
                }
            }
            double average = sum/10;
            Console.WriteLine($"tong la {sum}, trung binh la {average}");
        }
        /// <summary>
        /// hiển thị bảng cửu chương của một số nguyên được nhập vào:
        /// </summary>
        static void Session03_08()
        {
            Console.Write("Nhap so nguyen ban muon lam bang cuu chuong:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 1; i<11; i++)
                {
                    Console.WriteLine($"{number}*{i}={number*i}");
                }
            }
            else
            { Console.WriteLine("vui long nhap mot so nguyen"); }
        }
        /// <summary>
        ///  display a pattern like triangles with a number
        /// </summary>
        static void Session03_09()
        {
            Console.Write("nhap so dong ban muon:");
            int dong = int.Parse(Console.ReadLine()); ;
            for (int x = 1; x <= dong; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            for (int x = 1; x <= dong; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// a program to display the n terms of harmonic series and their sum
        /// </summary>
        static void Session03_10()
        {
            double tong = 0;
            Console.Write("Nhap so n ban muon ket thuc:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 1; i<=number; i++)
                {
                    Console.Write($"1/{i}");
                    if (i<number) { Console.Write("+"); }
                    tong += 1.0/i; //phải nhớ thêm 1.0
                }
                Console.WriteLine($"\ntong la {tong}");
            }
            else
            { Console.WriteLine("vui long nhap mot so nguyen"); }
        }
        /// <summary>
        /// Write a program to find the ‘perfect’ numbers within a given number range
        /// </summary>
        static void Session03_11()
        {
            // Nhập giới hạn phạm vi
            Console.Write("Nhap so bat dau cua pham vi: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap so ket thuc cua pham vi: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Các số hoàn hảo trong phạm vi từ {start} đến {end} là:");
            for (int number = start; number <= end; number++)
            {
                if (perfectnumber(number))
                {
                    Console.WriteLine(number);
                }
            }

        }
        /// <summary>
        /// Kiem tra xem co phai mot so hoan hao khong
        /// </summary>
        /// <param name="num">so can kiem tra</param>
        /// <returns>tra ve dung neu tong = so ban dau</returns>
        static bool perfectnumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num%i == 0)
                { sum+=i; };

            }
            return sum == num;
        }
        /// <summary>
        /// check whether a given number is even or odd
        /// </summary>
        static void Session03_12()
        {
            Console.Write("Nhap so ban muon kiem tra:");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"{a} la so chan");
                }
                else
                { Console.WriteLine($"{a} la so le"); }
            }
            else { Console.WriteLine("vui long nhap mot so nguyen hop le"); }
        }
        /// <summary>
        /// Kiem tra xem co phai so nguyen to khong
        /// </summary>
        static void Session03_13()
        {
            Console.Write("Nhap so ban muon kiem tra:");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                int prime = 10;
                if (a>1)
                {

                    for (int i = 2; i < a; i++)
                    {
                        if (a%i ==0)
                        { prime = 0; }
                        else if (a%1 == 0 && a%a == 0)
                        { prime = 1; }
                    }
                    if (prime == 1)
                    { Console.WriteLine($"{a} la so nguyen to"); }
                    else { Console.WriteLine($"{a} khong phai la so nguyen to"); }

                }
                else { Console.WriteLine("vui long nhap so lon hon 1 vi so nguyen to luon lon hon 1"); }
            }
            else { Console.WriteLine("vui long nhap mot so nguyen hop le"); }
        }
        /// <summary>
        /// kiem tra xem tọa độ ở phần tư nào của đồ thị Oxy
        /// </summary>
        static void Session03_14()
        {
            Console.Write("nhap toa do x:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.Write("nhap toa do y:");
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    if (x==0&&y==0)
                    {
                        Console.WriteLine("diem nam o goc toa do");
                    }
                    else if (x == 0)
                    {
                        Console.WriteLine("diem nam o truc tung");
                    }
                    else if (y == 0)
                    {
                        Console.WriteLine("diem nam o truc hoanh");
                    }
                    else if (x > 0 && y > 0)
                    {
                        Console.WriteLine("diem nam o phan tu thu nhat");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("diem nam o phan tu thu 2");
                    }
                    else if (x < 0 && y <0)
                    {
                        Console.WriteLine("diem nam o phan tu thu 3");
                    }
                    else if (x > 0 && y <0)
                    {
                        Console.WriteLine("diem nam o phan tu thu 4");
                    }

                }
                else { Console.WriteLine("vui long nhap mot so hop le"); }
            }
            else { Console.WriteLine("vui long nhap mot so hop le"); }
        }
    }
}
