using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Console.Write("Başlangıç değerini girin: ");
            //int baslangic = int.Parse(Console.ReadLine());

            //Console.Write("Bitiş değerini girin: ");
            //int bitis = int.Parse(Console.ReadLine());

            //int ciftsayitoplam = 0;
            //for (int i = baslangic; i <= bitis; i++) 
            //{ 
            //    if( i%2==0 )
            //    {
            //        ciftsayitoplam += i;
            //    }
            //}
            //Console.WriteLine(baslangic +  "-" + bitis +  " arasındaki çift sayıların toplamı= " + ciftsayitoplam);


            #endregion

            #region While Döngüsü
            //int i = 1;
            //int toplam = 0;
            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region Örnek Soru
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamı

            //Console.Write("3 Basamaklı bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int birlerBasamagi = sayi % 10;
            //int onlarBasamagi = (sayi % 100) / 10;
            //int yuzlerBasamagi = sayi / 100;

            //Console.WriteLine("Birler Basamağı:" + birlerBasamagi+ " Onlar Basamağı:" + onlarBasamagi+ " Yüzler Basamağı:" + yuzlerBasamagi);

            //int toplam= birlerBasamagi + onlarBasamagi + yuzlerBasamagi;

            //Console.WriteLine("Toplam: " + toplam);

            #endregion

            Console.ReadLine();
        }
    }
}
