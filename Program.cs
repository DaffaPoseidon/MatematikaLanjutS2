// using System;

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("====Selamat datang====");
//             Console.WriteLine("Pilih program yang ingin digunakan.");
//             Console.WriteLine("1. Perkenalan\n" +
//                               "2. Hello World\n" +
//                               "3. Program Perhitungan Statis\n" +
//                               "4. Program Perhitungan Dinamis\n" +
//                               "5. Program Pilihan\n" +
//                               "6. Program Piramida\n" +
//                               "7. Array Satu Dimensi\n" +
//                               "8. Array Multi Dimensi");
//             Console.Write("Jawab: ");

//             int jawaban = int.Parse(Console.ReadLine());
//             Console.WriteLine("");

//             switch(jawaban){
//                 case 1:
//                     ProgramPerkenalan();
//                     break;
//                 case 2:
//                     ProgramHelloWorld();
//                     break;
//                 case 3:
//                     ProgramAritmatikaStatis();
//                     break;
//                 case 4:
//                     ProgramAritmatikaDinamis();
//                     break;
//                 case 5:
//                     ProgramPilihan();
//                     break;
//                 case 6:
//                     ProgramPiramida();
//                     break;
//                 case 7:
//                     MatriksSatuDimensi();
//                     break;
//                 case 8:
//                     MatriksMultiDimensi();
//                     break;
//                 default:
//                     Console.WriteLine("Salah jawaban!");
//                     break;
//             }
//             Console.WriteLine("");
//         }

//         public static void ProgramPerkenalan(){
//             Console.WriteLine("Nama: Daffa Cahyo Alghifari" +
//                               "Game: Seri NieR");
//         }
//         public static void ProgramHelloWorld(){
//             Console.WriteLine("Hello World");
//         }
//         public static void ProgramAritmatikaStatis(){
//             int pertambahan = 5 + 5;
//             int pengurangan = int.Parse("20") - int.Parse("10");
//             int perkalian = 2 * 5;
//             int pembagian = int.Parse("100") / int.Parse("10");

//             int hasil = (pertambahan + perkalian) % (pengurangan + pembagian);
//             Console.WriteLine("Perhitungan (Pertambahan (5+5) + Perkalian (2*5)) % (Pengurangan (20-10) + Pembagian (100/10))");
//             Console.Write("Perhitungan (" +pertambahan+ " + " +perkalian+ ") % (" +pengurangan+ " + " +pembagian+") adalah: ");
//             Console.Write($"{hasil}");
//         }
//         public static void ProgramAritmatikaDinamis(){

//             Console.WriteLine("Pilih aritmatika");
//         }
//         public static void ProgramPilihan(){
//             Console.Write("Android manakah yang akan engkau pilih?\n" +
//                                "1. 9S?\n" +
//                                "2. A2?\n" +
//                                "Jawab: ");
//             int pilihan = int.Parse(Console.ReadLine());

//             if(pilihan == 1)
//                 Console.WriteLine("Selamat tinggal A2 :(");
//             else
//                 Console.WriteLine("Selamat tinggal A2 :(");
//         }
//         public static void ProgramPiramida(){
//             Console.WriteLine("=========Selamat datang di program Piramida!=========");
//             Console.Write("Piramidanya mau berapa meter?: ");
//             int jawaban = int.Parse(Console.ReadLine());

//             for(int i = 1; i <= jawaban; i++){
//                 for(int j = jawaban; j > i; j--){
//                     Console.Write(" ");
//                 }
//                 for(int k = 0; k <= (i * 2) -2; k++){
//                     Console.Write("*");
//                 }
//                 Console.WriteLine("");
//             }
//         }
//         public static void MatriksSatuDimensi(){
//             String[] android = {"9S", "2B", "A2"};
            
//             for(int i = 0; i < android.Length; i++){
//                 Console.WriteLine($"Nama-nama Android YoRHa: {android[i]}");
//             }
//         }
//         public static void MatriksMultiDimensi(){
//             String[,] android = {
//                 {"Scanner", "9"},
//                 {"Attacker", "2"},
//                 {"Battler", "2"},
//                 {"Operator", "6O"}
//             };

//             for(int i = 0; i < android.GetLength(0); i++){
//                 for(int j =0; j < android.GetLength(1); j++){
//                     Console.WriteLine($"Android YoRHa: {android[i,j]}");
//                 }
//                 Console.WriteLine("");
//             }
//         }
//     }
// }
