using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Hesap_Makinesi_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Giriniz: ");
            int Sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int Sayi2 = int.Parse(Console.ReadLine());

            Console.Write("İŞLEM SEÇ (+ - / *) : ");
            char Islem = char.Parse(Console.ReadLine());

            if (Islem == '+')
            {
                Console.WriteLine("SONUÇ = " + (Sayi1 + Sayi2));
            }
            else if (Islem == '-')
            {
                Console.WriteLine("SONUÇ = " + (Sayi1 - Sayi2));
            }
            else if (Islem == '*')
            {
                Console.WriteLine("SONUÇ = " + (Sayi1 * Sayi2));
            }
            else if (Islem == '/')
            {
                Console.WriteLine("SONUÇ = " + (Sayi1 / Sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı İşlem");
            }

            Console.ReadKey();
        }
    }
}
