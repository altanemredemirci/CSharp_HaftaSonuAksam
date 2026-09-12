using _19_NKatmanliMimari.DAL;
using _19_NKatmanliMimari.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_NKatmanliMimari.BLL
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int VeriKaydet(string Isim,string Soyisim)
        {
            if(!string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim))
            {
                Musteri M = new Musteri();
                M.Isim = Isim;
                M.Soyisim = Soyisim;

                return DAL.VeriKaydet(M);
            }
            else
            {
                return -1;
            }
        }
    }
}
