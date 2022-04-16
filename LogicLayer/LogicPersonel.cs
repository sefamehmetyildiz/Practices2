﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.personelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 3500 && p.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int per)
        {
            if(per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelGüncelle(EntityPersonel ent)
        {
            if (ent.Ad.Length>=3 && ent.Ad!=""&& ent.Soyad != "" && ent.Maas>3499)
            {
                return DALPersonel.PersonelGüncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}