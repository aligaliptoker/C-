using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharp_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region yazdırma komutları
            //Console.WriteLine("hello world"); // print screen
            //Console.Write("hello");

            //Console.WriteLine("************ Yemek Kategorileri ********************************");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("1-soğuk başlangıçlar");
            //Console.WriteLine("1-salatalar");
            //Console.WriteLine("1-tatlılar");
            //Console.WriteLine("1-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("************ Yemek Kategorileri ********************************");

            #endregion

            // Değişkenler

            #region Değişkenler

            // variable = değişkenler

            // string
            // değişkenin_türü değişken adı;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = " Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = " deneme@gmail.com";
            //district = " Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim:" + customerPhone);
            //Console.WriteLine("email adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = " sapanca";
            //city = "sakarya";
            //Console.WriteLine(customerName);

            //Console.WriteLine("**** Rezervasyon Kartı ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim:" + customerPhone);
            //Console.WriteLine("email adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------");


            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı**********");
            Console.WriteLine();
            Console.WriteLine("----- hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- kola: " + cokePrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı**********");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");


            #endregion




            Console.Read(); // wait screen
        }
    }
}
