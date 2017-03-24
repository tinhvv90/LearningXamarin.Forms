using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtKieuDuLieu
{
    class NhiPhan
    {
        public static void Main()
        {

            string answer;
            string result;

            Console.Write("Nhap mot so bat ky trong he thap phan: ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("So trong he nhi phan tuong ung la: {0}", result);

            Console.ReadKey();
        }
    }
}
