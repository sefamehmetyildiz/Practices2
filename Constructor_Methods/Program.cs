using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, meslek;
            Console.Write("Adınızı Girin: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Girin: ");
            soyad = Console.ReadLine();
            Console.Write("Mesleğinizi Girin: ");
            meslek = Console.ReadLine();
            Console.Write("\n\n\n");

            Ogrenci ogr = new Ogrenci("Adınız: "+ad);
            Ogrenci ogr2 = new Ogrenci("Soyadınız:"+soyad);
            Ogrenci ogr3 = new Ogrenci("Mesleğiniz:"+meslek);

            Console.Read();
        }
    }
}
