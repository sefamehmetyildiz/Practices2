using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Methods_in_class2
{
    class islem
    {
        public int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Toplam: " + s3);
            return s3;
        }
        public int carpım(int s1, int s2)
        {
            int s3 = s1 * s2;
            Console.WriteLine("Carpım: " + s3);
            return s3;
        }
        public int fark(int s1, int s2)
        {
            int s3 = s1 - s2;
            Console.WriteLine("Fark: " + s3);
            return s3;
        }
        public int bolum(int s1, int s2)
        {
            int s3 = s1 / s2;
            Console.Write("Bolum: " + s3);
            return s3;
        }

    }
}
