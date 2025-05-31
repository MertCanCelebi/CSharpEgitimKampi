using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizideki Elemanları Listeleme

            //int[] sayilar = { 145,514,987,1,365,53,12,154,45,54 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine(sayilar[i] + " ");
            //    }
            //}

            //int[] sayilar = { 145,514,987,1,365,53,12,154,45,54 };
            //int enBuyukSayi = sayilar[0];

            //for (int i = 1; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi= sayilar[i];
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük sayı:" + enBuyukSayi);

            #endregion

            #region Dizi Metotları
            ////Array.Sort : küçükten büyüğe diziyi sıralar
            //int[] sayilar = { 145, 514, 987, 1, 365, 53, 12, 154, 45, 54 };
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            ////Array.Reverse : diziyi sondan başa doğru getirir
            //int[] sayilar2 = { 145, 514, 987, 1, 365, 53, 12, 154, 45, 54 };
            //Array.Reverse(sayilar2);
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}

            ////Array.IndexOf : dizideki elemanın sıra numarasını getirir
            //int[] sayilar3 = { 145, 514, 987, 1, 365, 53, 12, 154, 45, 54 };
            //int index = Array.IndexOf(sayilar3,45);

            //    Console.WriteLine(index);

            //// max, min : dizideki en büyük ve en küçük değerleri getirir

            //int[] sayilar4 = { 145, 514, 987, 1, 365, 53, 12, 154, 45, 54 };
            //int maxSayi = sayilar4.Max();
            //int minSayi = sayilar4.Min();
            //Console.WriteLine("En büyük sayı: " + maxSayi+ " En küçük sayı: " + minSayi);


            #endregion

            #region Kullanıcıdan Deger Alma 
            //string[] sehirler = new string [5];
            //for (int i = 0; i < sehirler.Length; i++) 
            //{ 
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    sehirler[i]=Console.ReadLine();
            //}

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
               
            //}

            #endregion

            Console.Read();
        }
    }
}
