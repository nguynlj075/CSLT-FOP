namespace Fundamentals_of_Programming
{
    internal class Session02
    {
        public static void Main2(string[] args)
        {
            Session02_03();
        }
        /// <summary>
        ///  calculate the surface and volume of a sphere, given its radius
        /// </summary>
        static void Session02_01()
        {
            Console.WriteLine(@"chon chuc nang ban muon
1. Tinh dien tich
2. Tinh the tich");
            if (double.TryParse(Console.ReadLine(), out double choice))
            {
                if (choice == 1)
                {
                    Console.WriteLine("nhap ban kinh hinh cau can tinh");
                    if (double.TryParse(Console.ReadLine(), out double r))
                    {
                        double s = 4 * Math.PI * Math.Pow(r, 2); // 4 * Pi x R bình
                        Console.WriteLine($"dien tich hinh tron la {s}");
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
                        double s = 4/3 * Math.PI * Math.Pow(r, 3); // 4 * Pi x R bình
                        Console.WriteLine($"dien tich hinh cau la {s}");
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
        /// <summary>
        /// calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
        /// </summary>
        static void Session02_02()
        {
            Console.Write("nhap so dau tien");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("nhap so thu hai");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($@" {num1}+{num2}={num1+num2}
{num1}-{num2}={num1-num2};
{num1}*{num2}={num1* num2}
{num1}/{num2}={num1/num2};
{num1}%{num2}={num1%num2};");
                }
                else
                { Console.WriteLine("vui long nhap so thuc hop le"); }
            }
            else
            { Console.WriteLine("vui long nhap so thuc hop le"); }
        }
        /// <summary>
        /// Chuyển độ C thành độ F và độ K
        /// </summary>
        static void Session02_03()
        {
            Console.WriteLine("Nhap so do C ban can doi:");
            if (double.TryParse(Console.ReadLine(), out double c))
            {
                double k = c + 273.15;
                double f = (c*9/5) + 32;
                Console.WriteLine($@"
{c} do C = {k} do K
{c} do C = {f} do F");
            }
            else { Console.WriteLine("Vui long nhap so thuc hop le"); }

        }
    }

}


