namespace Fundamentals_of_Programming
{
    internal class Session01
    {
        /// <summary>
        /// to Add / Sum Two Numbers
        /// </summary>
        static void Session01_01()
        {
            Console.Write("Nhap so dau tien:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Tong cua hai so la {c}");

        }
        /// <summary>
        /// to Swap Values of Two Variables.
        /// </summary>
        static void Session01_02()
        {
            Console.Write("Nhap so dau tien:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"hai so sau khi hoan doi lan luot la  {a}, {b}");

        }
        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        static void Session01_03()
        {
            Console.Write("Nhap so dau tien:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            float b = float.Parse(Console.ReadLine());
            float c = a*b;
            Console.Write($"Tich cua {a} va {b} la {c}");
        }
        /// <summary>
        /// to convert feet to meter
        /// </summary>
        static void Session01_04()
        {
            Console.Write("Nhap so feet:");
            /// Kiem tra xem co nhap dung khong
            /// Khi sử dụng out, bạn không cần khởi tạo giá trị của biến trước khi gọi phương thức. Phương thức đó sẽ tự gán giá trị cho tham số out trong quá trình thực thi.
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                float b = a * 0.3048f; ///dùng float phải có f
                Console.Write($"{a} feet = {b} met");
            }
            else
            {
                Console.WriteLine("Vui long nhap so thuc hop le");
            }
        }
        /// <summary>
        /// 5. to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        static void Session01_05()
        {
            Console.WriteLine("chon chuc nang ban muon");
            Console.WriteLine("1. Chuyen tu do C sang do F");
            Console.WriteLine("2. Chuyen tu do F sang do C");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice ==1)
                {
                    Console.Write("Nhap so do C:");
                    if (float.TryParse(Console.ReadLine(), out float f))
                    {
                        float c = (f * 9/5) +32;
                        Console.Write($"{f} do F = {c} do C");
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap so thuc hop le");
                    }
                }
                else if (choice ==2)
                {
                    Console.Write("Nhap so do f:");
                    if (float.TryParse(Console.ReadLine(), out float c))
                    {
                        float f = (c - 32)*5/9;
                        Console.Write($"{c} do F = {f} do C");
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap so thuc hop le");
                    }
                }
                else
                { Console.WriteLine(" Vui long nhap 1 hoac 2 "); }

            }
            else
            {
                Console.WriteLine("Vui long nhap 1 hoac 2");
            }
        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        static void Session01_06()
        {
            Console.WriteLine($"Kích thước của byte: {sizeof(byte)} byte");
            Console.WriteLine($"Kích thước của short: {sizeof(short)} bytes");
            Console.WriteLine($"Kích thước của int: {sizeof(int)} bytes");
            Console.WriteLine($"Kích thước của long: {sizeof(long)} bytes");
            Console.WriteLine($"Kích thước của float: {sizeof(float)} bytes");
            Console.WriteLine($"Kích thước của double: {sizeof(double)} bytes");
            Console.WriteLine($"Kích thước của char: {sizeof(char)} bytes");
            Console.WriteLine($"Kích thước của bool: {sizeof(bool)} bytes");
        }
        /// <summary>
        /// to Print ASCII Value
        /// </summary>
        static void Session01_07()
        {
            Console.WriteLine("Nhap mot ky tu");
            char inputChar = Console.ReadKey().KeyChar; // Đọc 1 ký tự từ bàn phím
            int ascii = (int)inputChar; // Chuyển ký tự sang Ascii value
            Console.WriteLine($"Gia trị của ASCII của {inputChar} là {ascii}");
        }
        /// <summary>
        /// to calculate area of circle
        /// </summary>
        static void Session01_08()
        {
            Console.WriteLine("nhap ban kinh hinh tron can tinh");
            if (double.TryParse(Console.ReadLine(), out double r))
            {
                double s = Math.PI * Math.Pow(r, 2); // Pi x R bình
                Console.WriteLine($"dien tich hinh tron la {s}");
            }
            else
            {
                Console.WriteLine("Vui long nhap so hop le");
            }
        }
        /// <summary>
        /// To calculate area of square
        /// </summary>
        static void Session01_09()
        {
            Console.WriteLine("nhap ban kinh hinh vuong can tinh");
            if (double.TryParse(Console.ReadLine(), out double canh))
            {
                double s = Math.Pow(canh, 2); //  cạnh bình
                Console.WriteLine($"dien tich hinh vuong la {s}");
            }
            else
            {
                Console.WriteLine("Vui long nhap so hop le");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tongngay">tong so ngay can tinh</param>
        static void Session01_10(int Tongngay)
        {
            Console.Write("Nhap so ngay: ");
            if (int.TryParse(Console.ReadLine(), out Tongngay))  // Kiểm tra xem người dùng có nhập số hợp lệ không
            {
                // Tính số năm, tuần và ngày
                int years = Tongngay / 365;  // Số năm
                int ngayconlai = Tongngay % 365;  // Số ngày còn lại sau khi tính số năm (lấy phần dư sau khi chia năm)
                int tuan = ngayconlai / 7;  // Số tuần từ ngày còn lại
                int ngayle = ngayconlai % 7;  // Số ngày còn lại sau khi tính số tuần

                Console.WriteLine($"{Tongngay} ngay tuong duong {years} nam, {tuan} tuan va {ngayle} ngay.");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ!");
            }
        }
        static void Main1(string[] args) // Điểm bắt đầu của chương trình
        {
            Console.WriteLine(@"Chon chuc nang ban muon:
1.to Add / Sum Two Numbers.
2.to Swap Values of Two Variables.
3.to Multiply two Floating Point Numbers
4.to convert feet to meter
5.to convert Celsius to Fahrenheit and vice versa
6.to find the Size of data types
7.to Print ASCII Value(tip: read character, print number of this char)
8.to Calculate Area of Circle
9.to Calculate Area of Square
10.to convert days to years, weeks and days
");
            int chucnang;
            if (int.TryParse(Console.ReadLine(), out chucnang))  // Kiểm tra xem người dùng có nhập số hợp lệ không
            {
                if (chucnang == 1) { Session01_01(); }
                else if (chucnang == 2) { Session01_02(); }
                else if (chucnang == 3) { Session01_03(); }
                else if (chucnang == 4) { Session01_04(); }
                else if (chucnang == 5) { Session01_05(); }
                else if (chucnang == 6) { Session01_06(); }
                else if (chucnang == 7) { Session01_07(); }
                else if (chucnang == 8) { Session01_08(); }
                else if (chucnang == 9) { Session01_09(); }
                else if (chucnang == 10) { Session01_10(0); }
                else { Console.WriteLine("Vui long nhap mot so hop le (1-10)"); }

            }
            else
            {
                Console.WriteLine("Vui long nhap mot so hop le (1-10)");
            }
        }
    }
}