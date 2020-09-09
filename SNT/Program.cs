using System;

namespace Kiem_tra_so_nguyen_to
{
    class Program
    {
        static void kiemtrsonguyento(){
            int s = 0;
            int n;
            int i;
            Console.Write("Hay nhap mot so n bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    s++;

            if (s == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");
        }
        static void Main(string[] args)
        {
           kiemtrsonguyento();
            Console.ReadKey();
        }
    }
}
