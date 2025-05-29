using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //uygulama1

            //string sifre, sifreyeniden;

            //Console.WriteLine("Lütfen bir şifre belirleyiniz:");
            //sifre = Console.ReadLine();

            //Console.WriteLine("Lütfen şifreyi tekrar giriniz:");
            //sifreyeniden = Console.ReadLine();

            //if (sifre == sifreyeniden)
            //{
            //    Console.WriteLine("Şifreler Uyuyşuyor");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreler Uyuşmuyor");
            //}

            //uygulama2

            //int sinav1, sinav2, sinav3, ortalama;
            //string sonuc;

            //Console.Write("Sınav1: ");
            //sinav1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //sinav2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //sinav3 = int.Parse(Console.ReadLine());

            //ortalama = (sinav1 +sinav2 + sinav3)/3;
            //Console.WriteLine("Ortalamanız: " + ortalama);

            //if (ortalama > 0 & ortalama <50) 
            //{
            //    sonuc = "Kaldınız";
            //}
            //if(ortalama >= 50 & ortalama <=100)
            //{
            //    sonuc = "Geçtiniz";
            //}
            //else
            //{
            //    sonuc = "Hatalı değer girdiniz kontrol ediniz";
            //}
            //    Console.WriteLine("Durumunuz: " + sonuc);

            #endregion

            #region Mod İşlemi

            //Console.Write("Lütfen tek mi çift mi olduğunu öğrenmek istediğiniz sayıyı giriniz. ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifftir");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("----------------");

            //Console.WriteLine("Detayını Görmek İstediğiniz Seçeneği Seçiniz.");
            //string secim = Console.ReadLine();

            //if(secim == "1")
            //{
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tavuk Çorbası");
            //    Console.WriteLine("-----Çorbalar-----");
            //}

            //if (secim == "2")
            //{
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine("1-Köfte Pilav");
            //    Console.WriteLine("2-Hamburger");
            //    Console.WriteLine("3-Pizza");
            //    Console.WriteLine("-----Ana Yemekler-----");
            //}

            //if (secim == "3")
            //{
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine("1-Supangle");
            //    Console.WriteLine("2-Fırında Sütlaç");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("-----Tatlılar-----");
            //}


            #endregion

            #region Switch Case ile  Hesap Makinesi

            //Console.WriteLine("İşlem Yapılacak 1. Sayıyı Giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("İşlem Yapılacak 2. Sayıyı Giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapılacak İşlemi Giriniz: (+,-,/,*)");
            //char islem = char.Parse(Console.ReadLine());

            //int sonuc;

            //switch (islem)
            //{
            //    case '+':
            //    sonuc = sayi1 + sayi2; break;

            //    case '-':
            //        sonuc = sayi1 - sayi2; break;

            //    case '*':
            //        sonuc = sayi1 * sayi2; break;


            //    case '/':
            //        sonuc = sayi1 / sayi2; break;


            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        sonuc = 0;
            //        break;
            //}

            //Console.WriteLine("Sonuç: " + sonuc);

            #endregion

            Console.Read();
        }
    }
}
