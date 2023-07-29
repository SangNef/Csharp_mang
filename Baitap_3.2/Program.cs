using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._2
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

            Console.WriteLine("Dãy số trước khi đổi chỗ:");
            InMang(mang);

            DoiChoCacPhanTuDoiXung(mang);

            Console.WriteLine("Dãy số sau khi đổi chỗ:");
            InMang(mang);

            Console.ReadKey();
        }

        static void DoiChoCacPhanTuDoiXung(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                double temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }

        // Phương thức in mảng
        static void InMang(double[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
