using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Methods_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            kisiler ks = new kisiler();

            string ads;
            Console.Write("İsim Girin: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);

            Console.Read();
        }
    }
}
