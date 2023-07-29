using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử N: ");
            int N = int.Parse(Console.ReadLine());

            int[] mang = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }

            int soLuongChinhPhuong = DemSoChinhPhuongTrongMang(mang);

            Console.WriteLine("Số lượng số chính phương trong dãy: " + soLuongChinhPhuong);
            Console.ReadKey();
        }

        static bool LaSoChinhPhuong(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }

        static int DemSoChinhPhuongTrongMang(int[] arr)
        {
            int dem = 0;
            foreach (var item in arr)
            {
                if (LaSoChinhPhuong(item))
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
