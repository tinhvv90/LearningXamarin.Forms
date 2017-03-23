using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheptoan
{
    class Program
    {
        static void Main()
        {
            int a, b, tong, hieu , tich, thuong;

            Console.WriteLine("\nNhap so a = ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNhap so b = ");
            b = int.Parse(Console.ReadLine());

            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = a / b;

            Console.WriteLine("\nKet qua cac phep tinh: ");
            Console.WriteLine("\nTong a va b la: " + tong);
            Console.WriteLine("\nHieu a va b la: " + hieu);
            Console.WriteLine("\nTich a va b la: " + tich);
            Console.WriteLine("\nThuong a va b la: " + thuong);

            Console.ReadLine();

        }
    }
}
