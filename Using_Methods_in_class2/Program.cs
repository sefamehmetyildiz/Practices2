using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Methods_in_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            islem sonuc = new islem();
            int a, b;
            Console.Write("1.Sayiyi Girin: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayiyi Girin: ");
            b = Convert.ToInt16(Console.ReadLine());

            sonuc.toplam(a, b);
            sonuc.fark(a, b);
            sonuc.carpım(a, b);
            sonuc.bolum(a, b);

            Console.Read();
        }
    }
}
