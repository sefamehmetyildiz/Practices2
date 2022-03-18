using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    class Araba : ArabaDetay
    {
        public string renk;
        public int hız;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }//MUTLAK DEĞERİNİ ALACAK
        }
        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); } //GİRİLEN HER KARAKTERİ BÜYÜK HARF YAPACAK
        }

    }
}
