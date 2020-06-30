using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap ktp = new Kitap();
            string giris;
            while (1 == 1)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t1--->Kitap ekle");
                Console.WriteLine("\t\t\t\t\t2--->Kitapları Goruntule");
                Console.WriteLine("\t\t\t\t\t3--->Odunc verilen Kitaplar Listesi");
                Console.WriteLine("\t\t\t\t\t4--->Odunc Kitap Ver");
                Console.WriteLine("\t\t\t\t\t5--->Cıkıs");
                giris = Console.ReadLine();
                if (giris == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Lufen eklenecek kitap ismi giriniz");
                    string isim = Console.ReadLine();
                    ktp.kitap_ekle(isim);
                    Console.ReadKey();

                }
                else if (giris == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Mevcut kitap listesi:");
                    ktp.kitap_goruntule();
                    Console.ReadKey();

                }
                else if (giris == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Odunc verilen kitaplar listesi:");
                    ktp.odunc_kitap_listesi();
                    Console.ReadKey();
                }
                else if (giris == "4")
                {
                    Console.Clear();
                    ktp.kitap_goruntule();
                    Console.WriteLine("Odunc verilecek kitap ismi giriniz:");
                    string odunc = Console.ReadLine();
                    ktp.odunc_kitap(odunc);
                    Console.ReadKey();


                }
                else if (giris == "5")
                {
                    Environment.Exit(0);

                }
                else
                    Console.WriteLine("Yanlıs deger girildi tekrar giris yapınız");

            }




        }
    }
}
