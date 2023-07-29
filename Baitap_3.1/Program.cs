using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_3._1
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

            Console.WriteLine("Dãy số trước khi sắp xếp:");
            InMang(mang);

            SapXepGiamDan(mang);

            Console.WriteLine("Dãy số sau khi sắp xếp giảm dần:");
            InMang(mang);

            Console.ReadKey();
        }

        static void SapXepGiamDan(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        static void InMang(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
    }
}
