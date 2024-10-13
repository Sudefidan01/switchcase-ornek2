using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20233007_SwitchCase_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Kullanıcıdan 2 adet sayı talep edelim
            //Bir menü hazırlayalım(1-Toplama 2-Çıkarma 3-Çarpma 4-Bölme 5-Çıkış)
            //Kullanıcının yapmış olduğu seçime göre 4 işlem veya çıkış işlemi yapalım
            double sayi1, sayi2;
            ConsoleKey secim;

            do
            {
                Console.Clear();
                Console.Write("Birinci Sayıyı Giriniz : ");
                sayi1=double.Parse(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz : ");
                sayi2=double.Parse(Console.ReadLine());

                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Çıkarma");
                Console.WriteLine("3-Çarpma");
                Console.WriteLine("4-Bölme");
                Console.WriteLine("5-Çıkış");
                secim = Console.ReadKey().Key;
                Console.Clear();
                switch (secim)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.WriteLine("İki Sayının Toplamı : " +(sayi1+sayi2));
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.WriteLine("İki Sayının Farkı : "+(sayi1-sayi2));
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.WriteLine("İki Sayının Çarpımı : "+(sayi1*sayi2));
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Console.WriteLine("İki Sayının Bölümü"+(sayi1/sayi2));
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Console.WriteLine("Programı Kullandığınız için Teşekkür Ederiz");
                        break;

                    default:
                        Console.WriteLine("Yanlış Bir Seçim Yaptınız");
                        break;


                    
                }



            } while (secim!=ConsoleKey.D5 && secim!=ConsoleKey.NumPad5);

            Console.ReadKey();
        }
    }
}
