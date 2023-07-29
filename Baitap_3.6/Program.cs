using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử N: ");
            int N = int.Parse(Console.ReadLine());

            double[] mang = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                mang[i] = double.Parse(Console.ReadLine());
            }

            double min = TimSoNhoNhatTrongMang(mang);

            Console.WriteLine("Số nhỏ nhất trong dãy: " + min);

            Console.ReadKey();
        }

        static double TimSoNhoNhatTrongMang(double[] arr)
        {
            double min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
