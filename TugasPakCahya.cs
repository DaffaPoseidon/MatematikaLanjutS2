using System;

namespace HelloWorld{

    class Program2{
        static void Main(string[] args){
            Console.WriteLine("====Selamat datang====");
            Console.WriteLine("Pilih program yang ingin digunakan.");
            Console.WriteLine("1. Perkenalan\n" +
                              "2. Hello World\n" +
                              "3. Persamaan Linear Seidel\n" +
                              "4. Persamaan Linear Reyman\n" +
                              "5. Persamaan Linear Trapezoid\n");
            Console.Write("Jawab: ");

            int jawaban = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch(jawaban){
                case 1:
                    ProgramPerkenalan();
                    break;
                case 2:
                    ProgramHelloWorld();
                    break;
                case 3:
                    Seidel();
                    break;
                case 4:
                    Reyman();
                    break;
                case 5:
                    Trapezoid();
                    break;
                default:
                    Console.WriteLine("Salah jawaban!");
                    break;
            }
            Console.WriteLine("");
        }

        public static void ProgramPerkenalan(){
            Console.WriteLine("Nama: Daffa Cahyo Alghifari" +
                              "Game: Seri NieR");
        }
        public static void ProgramHelloWorld(){
            Console.WriteLine("Hello World");
        }

        public static void Seidel(){
            float a, k, i;
            a = 1;
            k = 1;

            for(i = 1; i <= 20; i++){
                a = (8 - 1 * k) / 2;
                k = (14 - 1 * a) / 3;

                Console.WriteLine("a" + i + ": " +a+ " | k"+ i + ": " + k);
            }
        }

        public static void Reyman(){
            double a = 1;
            double b = 10;
            double lop = 100;
            double beda = 0.09;
            double iterasi = 0;
            double x = a;
            double fx;
            double l = 0;
            double ltotal = 0;

            for (int i = 0; i < lop; i++)
            {
                x = x + beda;
                fx = 3 * (x * x);
                l = beda * fx;
                ltotal += l;
                iterasi++;

                Console.WriteLine("iterasi " +iterasi+ " = x: " +x+ " fx: " +fx+ " l: " +l+ " ltotal: " +ltotal);
            }
        }

        public static void Trapezoid(){
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

                Console.WriteLine("iterasi " +iterasi+ " = x: " +x+ " fx: " +fx+ " l " +l+ " ltotal: " +ltotal);
            }
        }
    }
}