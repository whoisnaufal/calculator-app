using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Aplikasi Kalkulator" ;
            Menu();
            Console.WriteLine();
            Console.Write("Input Nomor Menu [1-4]: ");
            int pil = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (pil)
            {
                case 1:
                    Jumlah();
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang key untuk keluar");
                    break;
                case 2:
                    Kurang();
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang key untuk keluar");
                    break;
                case 3:
                    Kali();
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang key untuk keluar");
                    break;
                case 4:
                    Bagi();
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang key untuk keluar");
                    break;
                default:
                    Console.WriteLine("Maaf menu tidak tersedia");
                    Console.WriteLine();
                    Console.WriteLine("Tekan sembarang key untuk keluar");
                    break;
            }
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.WriteLine("Pilih Menu Calculator : ");
            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        public static void Jumlah()
        {
            Console.Write("Masukkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan dari " + a + " + " + b + " = " + Penjumlahan(a, b));
        }
        public static void Kurang()
        {
            Console.Write("Masukkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasil Pengurangan dari " + a + " - " + b + " = " + Pengurangan(a, b));
        }
        public static void Kali()
        {
            Console.Write("Masukkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasil Perkalian dari " + a + " x " + b + " = " + Perkalian(a, b));
        }
        public static void Bagi()
        {
            Console.Write("Masukkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasil Pembagian dari " + a + " / " + b + " = " + Pembagian(a, b));
        }
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
