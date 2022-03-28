
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1_giris, sayi2_giris;
            double sonuc;
            string islem;

            Console.WriteLine("Bir sayı girin:");
            sayi1_giris = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İkinci sayıyı girin:");
            sayi2_giris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem seçin(*,/,+,-)");
            islem = Console.ReadLine();

            if (islem == "*")
            {
                sonuc = sayi1_giris * sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "/")
            {
                sonuc = sayi1_giris / sayi2_giris;
                Console.WriteLine("Sonuç:" + sonuc);
            }
            if (islem == "+")
            {
                sonuc = sayi1_giris + sayi2_giris;
                Console.WriteLine("Sonuç:" + sonuc);
            }
            if (islem == "-")
            {
                sonuc = sayi1_giris - sayi2_giris;
                Console.WriteLine("Sonuç:" + sonuc);
            }
        }


        }
    }
