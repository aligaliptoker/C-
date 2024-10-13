
// Author : AGT
// Created on : 13.10.2024


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            double number;
            number = 4.85; // kod tarafında nokta olarak yazsak bile konsol da virgül olarak gözükür

            Console.WriteLine(number);

            #endregion

            #region
            Console.WriteLine("******Fiyat Listesi*********");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.OutputEncoding = Encoding.UTF8; // burada konsol ayarını utf-8 olarak ayarladık 
            string TurkishMoneySymbol = "₺";
            // Console.WriteLine(deneme);


            Console.WriteLine("------ Elma Birim Fiyatı:" + applePrice + TurkishMoneySymbol);
            Console.WriteLine("------ Portakal Birim Fiyatı:" + orangePrice + TurkishMoneySymbol);
            Console.WriteLine("------ Çilek Birim Fiyatı:" + strawberryPrice + TurkishMoneySymbol);
            Console.WriteLine("------ Patates Birim Fiyatı:" + potatoPrice + TurkishMoneySymbol);
            Console.WriteLine("------ Domates Birim Fiyatı:" + tomatoPrice + TurkishMoneySymbol);

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoGram;
            double tomatoTotalPrice = tomatoGram * tomatoGram;

            Console.WriteLine("Alınan Ürün: Elma /" + "Birim Fiyatı:" + applePrice + "/ Gramaj:" + appleGram + " /Toplam Tutar:" + appleTotalPrice);
            // Console.WriteLine("Elmanın Toplam Fiyatı:" + appleTotalPrice + TurkishMoneySymbol);
            Console.WriteLine("Alınan Ürün: Portakal /" + "Birim Fiyatı:" + orangePrice + "/ Gramaj:" + orangeGram + " /Toplam Tutar:" + orangeTotalPrice + TurkishMoneySymbol);
            Console.WriteLine("Alınan Ürün: Çilek /" + "Birim Fiyatı:" + strawberryPrice + "/ Gramaj:" + strawberryGram + " /Toplam Tutar:" + strawberryTotalPrice + TurkishMoneySymbol);
            Console.WriteLine("Alınan Ürün: Patates /" + "Birim Fiyatı:" + potatoPrice + "/ Gramaj:" + potatoGram + " /Toplam Tutar:" + potatoTotalPrice + TurkishMoneySymbol);
            Console.WriteLine("Alınan Ürün: Domates /" + "Birim Fiyatı:" + tomatoPrice + "/ Gramaj:" + tomatoGram + " /Toplam Tutar:" + tomatoTotalPrice + TurkishMoneySymbol);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş toplam tutarı:" + shoppingTotalPrice + TurkishMoneySymbol);


            #endregion

            #region Char degiskenler


            // ABCDEFGH
            // DEF... SEZAR...
            // TOPLANTI SAAT 20.00'DE
            // stringler "" ile tanımlanır charlar '' ile tanımlanır

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden veri girişleri string değişkenler

            Console.WriteLine("***** CSharp hava yolları yolcu bilgisi ********");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.WriteLine("Yolcu Adı: ");
            passengerName = Console.ReadLine(); // passengerName'e kendimiz bir değer atıycaz

            Console.WriteLine("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-------------------------");


            Console.WriteLine("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.WriteLine("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.WriteLine("Yolcu Yaş");
            passengerAge = Console.ReadLine();

            Console.WriteLine("Yolcu kimlik no: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber + "Yolcu Adı Soyadı: " + passengerName + passengerSurname + "Yolcu Bulunduğu Şehir: " + passengerDistrict + "/" + passengerCity + "Yolcu yaşı: " + passengerAge);

            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler

            int shoePrice, computerPrice, chairPrice, televisionPrice;

            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            televisionPrice = 12000;

            int shoeCount, computerCount, chairCount, televisionCount;

            Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz:");
            shoeCount = int.Parse(Console.ReadLine()); // eğer ki console.readline() yaptırırsak olmaz çünkü integer bir değer için bunu yapıyoruz bu sebepten burada bir dönüşüme ihtiyacımız vardır

            Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz:");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz:");
            chairCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen aldığınız televziyon sayısını giriniz:");
            televisionCount = int.Parse(Console.ReadLine());

            int totalPrice = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount + televisionCount * televisionPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);
            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            double exam1, exam2, exam3, result;

            Console.WriteLine("Lütfen 1. sınav notunu giriniz:");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sınav notunu giriniz:");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. sınav notunu giriniz:");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine(result);

            #endregion

            #region klavyeden karakter girişi

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz:");
            
            gender = char.Parse(Console.ReadLine()); // burada 2 farklı karakter girecek olursan hata verir


            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion


            Console.Read();
        }
    }
}
