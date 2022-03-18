using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Informations
{
    class Program
    {
        static void Main(string[] args)
        {
            kisibilgisi ks = new kisibilgisi();

            string ads, mslk;
            Console.Write("İsim girin:");
            ads = Console.ReadLine();
            Console.Write("Meslek girin:");
            mslk = Console.ReadLine();
            ks.persons(ads);
            ks.persons(mslk);

            Console.Read();
        }
    }
}
