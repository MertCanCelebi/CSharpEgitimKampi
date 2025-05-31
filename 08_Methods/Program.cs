using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değer Döndürmeyen Metodlar

            //void Topla()
            //{
            //    int x = 2;
            //    int y = 3;
            //    Console.WriteLine(x + y);
            //}
            //Topla();

            #endregion

            #region Değer Döndürmeyen Parametreli Metodlar

            //void Topla(int x, int y)
            //{
            //    Console.WriteLine(x + y);
            //}

            //Console.Write("1.sayıyı giriniz: ");
            //int sayi1= int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Topla(sayi1, sayi2);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string AdSoyadGetir()
            //{
            //    string ad = "Mert";
            //    string soyad = "Çelebi";
            //    return ad + " " + soyad;
            //}
            //Console.WriteLine(AdSoyadGetir());
            #endregion

            #region Geriye Değer Döndüren Parametreli Metodlar

            //int Topla (int x, int y)
            //{
            //    return x + y;
            //}
            //Console.Write("1.sayıyı giriniz: ");
            //int sayi1= int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Topla(sayi1, sayi2));
            #endregion

            #region Örnek Uygulama

            //string DersDurumu(string ad, int sinav1, int sinav2, int sinav3)
            //{
            //    int ortalama = (sinav1 + sinav2 + sinav3) / 3;

            //    if (ortalama < 50)
            //    {
            //        return ad + " adlı öğrenci " + ortalama + " ile dersten kalmıştır";
            //    }
            //    else
            //    {
            //        return ad + " adlı öğrenci " + ortalama + " ile dersten geçmiştir";
            //    }
            //}

            //Console.Write("Adınızı giriniz: ");
            //string isim = Console.ReadLine();

            //Console.Write("1.Sınav notunuzu giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav notunuzu giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav notunuzu giriniz: ");
            //int sayi3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(DersDurumu(isim,sayi1,sayi2,sayi3));

            #endregion

            Console.Read();
        }
    }
}
