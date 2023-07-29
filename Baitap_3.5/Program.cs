using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._5
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

            double max = TimSoLonNhatTrongMang(mang);

            Console.WriteLine("Số lớn nhất trong dãy: " + max);

            Console.ReadKey();

        }

        static double TimSoLonNhatTrongMang(double[] arr)
        {
            double max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
