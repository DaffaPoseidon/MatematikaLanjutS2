using System;

namespace HelloWorld{

    class Program3{
        static void Main(string[] args){
            double a = 1;
            double b = 10;
            double lop = 100;
            double beda = 0.09;
            double iterasi = 0;
            double x = a;
            double x2;
            double kanan;
            double kiri = 2 * x;
            double l = 0;
            double ltotal = 0;
            double fx = 3;

            for (int i = 0; i < lop; i++)
            {
                x = x + beda;
                kiri = fx;
                fx = 3 * (x * x);
                kanan = fx;
                l = (kiri + kanan) * 0.5 * beda;
                ltotal = l + ltotal;
                iterasi++;

                Console.WriteLine("iterasi: " +iterasi+ " x: " +x+ " fx: " +fx+ " l " +l+ " ltotal: " +ltotal);
            }
        }
    }
}