using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._3
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

            int tongSoLe = TinhTongSoLeTrongMang(mang);

            Console.WriteLine("Tổng các số lẻ trong dãy: " + tongSoLe);
            Console.ReadKey();
        }

        static int TinhTongSoLeTrongMang(int[] arr)
        {
            int tong = 0;
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    tong += item;
                }
            }
            return tong;
        }
    }
}
