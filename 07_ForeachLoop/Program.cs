using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string kelime = "Beşiktaş";

            //foreach (char c in kelime) 
            //{
            //    Console.WriteLine(c);
            //}

            //List<int> list = new List<int>()
            //{
            //    54,87,65,32,5,7
            //};

            //foreach (int i in list) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Örnek Uygulama

            //Console.Write("Öğrenci Sayisini Giriniz: ");
            //int ogrSayisi= int.Parse(Console.ReadLine());

            //string[] ogrAdlari = new string[ogrSayisi];
            //double[] ogrSinavOrtalama = new double[ogrSayisi];

            //for (int i = 0; i < ogrSayisi; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin adı: ");
            //    ogrAdlari[i] = Console.ReadLine();
            //    double sinavToplam=0;
            //    for(int k = 0; k<3; k++)
            //    {
            //        Console.Write($"{ogrAdlari[i]} öğrencisinin {k + 1}. sınav notu: ");
            //        double notlar= double.Parse(Console.ReadLine());
            //        sinavToplam += notlar;
            //    }
            //    ogrSinavOrtalama[i] = sinavToplam / 3;
            //}

            //for (int i = 0; i < ogrSayisi; i++) 
            //{
            //    Console.WriteLine($"{ogrAdlari[i]} adlı öğrencinin sınav ortalaması: {ogrSinavOrtalama[i]} ");

            //    if (ogrSinavOrtalama[i] < 50)
            //    {
            //        Console.WriteLine($"{ogrAdlari[i]} adlı öğrenci kaldı ");

            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{ogrAdlari[i]} adlı öğrenci geçti ");
            //    }

            //}


            #endregion

            Console.Read();

        }
    }
}
