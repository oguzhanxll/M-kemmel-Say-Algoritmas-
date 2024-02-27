using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcdan bir tam sayı girişi yapması istenir.
            //Kullanıcının girdiği sayının mükemmel sayı olup olmadığını ekrana yazdıran C#...
            //Kodunuz yazınız, ilgili kodun algoritma şemasını çiziniz ve sözde kodunu da yazınız.

            //Yardımcı kaynaklar: 
            //-> https://www.w3schools.com/cs/cs_conditions.php if-else.
            //-> https://www.w3schools.com/cs/cs_for_loop.php for döngüsü.

            //Kullanıcdan sayı girmesini istiyoruz.
     
            int sayi , toplam = 0;
            Console.WriteLine("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine()); //Girilen sayı okunuyor. "Conver.ToInt32 = Girilen sayıyı Tam sayıya çevirmeye yarar.
            /* int toplam = 0;*/ //Bölenlerin toplamını saklayacağımız değişken.(!)
            for (int i = 1; i < sayi; i++) // Girilen sayıyının tüm bölenleri kontrol edilir.
            {
               if (sayi % i == 0) //Eğer i sayıyı tam bölerse,
                {
                    toplam += i;
                }
            }

            //Bölümlerin sonucu sayı eşitse, sayı mükemmmmmmmel sayıdır.
            if (sayi == toplam)
            {
                Console.WriteLine("MÜKEMMEL SAYI");
            }
             else //Toplam sayıya eşit değilse mükemmel sayı değildir.
            {
                Console.WriteLine("Mükemmel sayı değil.");
               
            }

                Console.ReadLine();
        }
    }
}
