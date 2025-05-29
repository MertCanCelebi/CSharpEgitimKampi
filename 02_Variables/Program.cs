using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler
            //Console.OutputEncoding = Encoding.UTF8;
            //double applePrice = 20.50;
            //double orangePrice = 15.42;
            //double pearPrice = 41.4;

            //Console.WriteLine("***** Fiyatlarımız *****");
            //Console.WriteLine();
            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("Armut Birim Fiyatı: " + pearPrice + " ₺");
            //Console.WriteLine();

            //double appleGram = 0.450;
            //double orangeGram = 5.875;
            //double pearGram = 2.745;

            //double totalApplePrice = applePrice * appleGram;
            //double totalOrangePrice = orangePrice * orangeGram;
            //double totalPearPrice = pearPrice * pearGram;

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj " + appleGram+ " Toplam Tutar: " + totalApplePrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj " + orangeGram + " Toplam Tutar: " + totalOrangePrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Armut - Birim Fiyat: " + pearPrice + " - Gramaj " + pearGram + " Toplam Tutar: " + totalPearPrice + " ₺");
            //Console.WriteLine();
            //double totalShoppingPrice = totalApplePrice + totalOrangePrice + totalPearPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + totalShoppingPrice + " ₺");
            #endregion

            #region CharDegiskenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişi String Değişkenler
            //Console.WriteLine("**** Yolcu Bilgileri ****");
            //Console.WriteLine();

            //string passengerName, passangerSurname, passangerDistrict, passangerCity , passengerAge, passengerIdentityNumber ;

            //Console.Write("Yolcu Adı:");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe:");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir:");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "- Yolcu Ad Soyad:" + passengerName + " " + passangerSurname+ " " + passangerDistrict + "/" + passangerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Veri Girişi İnt Değişkenler
            //int laptopPrice = 25000;
            //int desktopPcPrice = 35000;
            //int monitorPrice = 10000;

            //int laptopCount, desktopCount , monitorCount ;

            //Console.Write("Alınan Laptop Sayısı:");
            //laptopCount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Masaüstü Bilgisayar Sayısı:");
            //desktopCount = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Monitör Sayısı:");
            //monitorCount = int.Parse(Console.ReadLine());

            //int totalPrice= laptopCount*laptopPrice + desktopCount*desktopPcPrice + monitorCount* monitorPrice ;

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Veri Girişi Double Değişkenler

            //double exam1, exam2, exam3, average;

            //Console.Write("Birinci Sınav Notunuzu Giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci Sınav Notunuzu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü Sınav Notunuzu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3 ) / 3;

            //Console.WriteLine("Ortalamanız: " + average);

            #endregion

            #region Klavyeden Veri Girişi Char Değişkenler
            //char gender;
            //Console.Write("Cinsiyetinizi Seçiniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Cinsiyetiniz: " + gender);

            #endregion

            Console.Read();
        }
    }
}
