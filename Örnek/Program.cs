using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{

    internal class Program
    {

        static void Main(string[] args)
        {

           

            


         

                Console.WriteLine("*****************");
                Console.WriteLine("Armstrong Sayılar ");

                Console.WriteLine("Lütfen bir sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());
                int giris = sayi;
                int toplam25 = 0;

                while (sayi != 0)
                {
                    int rakam = sayi % 10;
                    toplam25 = toplam25 + (rakam * rakam * rakam);
                    sayi = sayi / 10;
                }

                if (giris == toplam25)
                {
                    Console.WriteLine("Girdiğiniz sayı bir Armstrong sayısıdır.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı bir Armstrong sayısı değildir.");
                }
                Console.ReadLine();


                Console.WriteLine("*****************");
                Console.WriteLine("Yazılan Sayının Harf Karşılığı ");

            string[] birler1 = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
                string[] onlar1 = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

                Console.WriteLine("Lütfen 2 basamaklı bir sayı girin: ");
                int sayi9 = int.Parse(Console.ReadLine());

                if (sayi9 >= 10 && sayi9 <= 99)
                {
                    Console.WriteLine(onlar1[sayi9 / 10] + " " + birler1[sayi9 % 10]);
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı 2 basamaklı değil.");
                }
                Console.ReadLine();

                Console.WriteLine("*****************");
               Console.WriteLine("Yazılan Sayının Harf Karşılığı ");

            int x;
                Console.WriteLine("0-99 arasinda bir sayi girin...");

                x = Convert.ToInt32(Console.ReadLine());
                switch ((x % 100) / 10)
                {
                    case 1:
                        Console.Write("on ");
                        break;

                    case 2:
                        Console.Write("yirmi ");
                        break;

                    case 3:
                        Console.Write("otuz ");
                        break;

                    case 4:
                        Console.Write("kirk ");
                        break;

                    case 5:
                        Console.Write("elli ");
                        break;

                    case 6:
                        Console.Write("altmis ");
                        break;

                    case 7:
                        Console.Write("yetmis ");
                        break;

                    case 8:
                        Console.Write("seksen ");
                        break;

                    case 9:
                        Console.Write("doksan ");
                        break;

                    default:
                        break;
                }
                switch (x % 10)
                {

                    case 1:
                        Console.WriteLine("bir ");
                        break;

                    case 2:
                        Console.WriteLine("iki ");
                        break;

                    case 3:
                        Console.WriteLine("uc ");
                        break;

                    case 4:
                        Console.WriteLine("dort ");
                        break;

                    case 5:
                        Console.WriteLine("bes ");
                        break;

                    case 6:
                        Console.WriteLine("alti ");
                        break;

                    case 7:
                        Console.WriteLine("yedi ");
                        break;

                    case 8:
                        Console.WriteLine("sekiz ");
                        break;

                    case 9:
                        Console.WriteLine("dokuz ");
                        break;

                    default:
                        break;

                }
                if (x == 0)
                    Console.WriteLine("sifir ");

                Console.ReadLine();
                Console.WriteLine("*****************");
            /********************************/
            // çarpım tablosu
            Console.WriteLine("Çarpım Tablosu ");
            for (int j = 1; j <= 10; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                Console.WriteLine("*****************");
            /*****************************************/
            Console.WriteLine("3'e Tam Bölünen Sayılar ");
            int sayac = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                        sayac++;
                    }
                }
                Console.WriteLine("3'e tam bölünen sayı adeti={0}", sayac);
                Console.ReadLine();
                Console.WriteLine("*****************");
            /***************************************/
            Console.WriteLine("0 - 100 Arası Çift Sayılar ");
            Console.WriteLine("Çift Sayılar");
                Console.WriteLine("------------");
                for (int i = 2; i <= 100; i += 2)
                {
                    Console.WriteLine("Çift sayı={0}", i);
                }
                Console.ReadLine();

                Console.WriteLine("*****************");
            /**********************************/
            Console.WriteLine("Mükemmel Sayılar ");
            Console.WriteLine("Sayı giriniz");
                int sayi7 = Convert.ToInt32(Console.ReadLine());
                int toplam = 0;
                for (int i = 1; i < sayi7; i++)
                {
                    if (sayi7 % i == 0)
                    {
                        toplam = toplam + i;
                    }
                }
                if (toplam == sayi7)
                {
                    Console.WriteLine(sayi7 + "sayı Mükemmel Sayıdır");
                }
                else
                {
                    Console.WriteLine(sayi7 + "sayı Mükemmel Sayı Değildir");
                }
                Console.ReadLine();
                Console.WriteLine("*****************");
            /************************/

            Console.WriteLine("EBOB Hesaplama ");
            Console.Write("1. Sayiyi giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayiyi giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int ebob = 0;




                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;


                    }
                }
                Console.WriteLine("Ebob = " + ebob);


                Console.ReadLine();

                Console.WriteLine("*****************");
            /************************/
            //Console.WriteLine("Armstrong Sayılar ");
            //Console.Write("Sayı Giriniz: ");
            //    int sayi5 = Convert.ToInt32(Console.ReadLine());
            //    int uzunluk = sayi5.ToString().Length;
            //    int baslangic = sayi5;
            //    int toplam5 = 0;
            //    while (sayi5 != 0)
            //    {
            //        int basamak = sayi5 % 10;
            //        toplam5 += Convert.ToInt32(Math.Pow(basamak, uzunluk));
            //        sayi5 /= 10;
            //    }
            //    if (toplam5 == baslangic)
            //        Console.WriteLine("Sayı Armstrong Sayıdır");
            //    else
            //        Console.WriteLine("Sayı Armstrong Sayısı Değildir");

            /**********************************************/
            Console.WriteLine("EKOK Sayılar ");
            Console.Write("1. Sayiyi giriniz: ");

                int sayi3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayiyi giriniz: ");
                int sayi4 = Convert.ToInt32(Console.ReadLine());
                int max = sayi3 * sayi4;
                int ekok = 0;


                for (int i = max; i > 0; i--)
                {
                    if (i % sayi3 == 0 && i % sayi4 == 0)
                    {
                        ekok = i;
                    }
                }
                Console.WriteLine("Ekok = " + ekok);

                Console.ReadLine();
                Console.WriteLine("*****************");
            /************************/
            Console.WriteLine("0 - 100 Arası Pisagor Üçgeni Sayıları ");

            for (int xx = 1; x < 100; xx++)
                {
                    for (int y = 1; y < 100; y++)
                    {
                        for (int z = 1; z < 100; z++)
                        {
                            if ((Math.Pow(z, 2) == Math.Pow(xx, 2) + Math.Pow(y, 2)) && (xx < y))
                            {
                                Console.WriteLine("Pisagor Üçgeni = \t " + xx.ToString() + "-" + y.ToString() + "-" + z.ToString());
                            }
                        }
                    }
                }
                Console.WriteLine("*****************");

                /********************************/

            }


        }
    }





       
