using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacimVeAlanHesaplama
{
    public class Alan
    {
        private int UzunKenar{ get; set; }
        private int KisaKenar { get; set; }
        private int KareKenari { get; set; }


        public Alan(int Kare)
        {
           KareKenari = Kare;

        }
        public int KareAlanHesapla()
        {
            int Alan = KareKenari * KareKenari;
            return Alan;
        }
        public Alan(int UzunKenar,int Kisakenar)
        {
            this.UzunKenar = UzunKenar;//This koyulması zorunludur çünkü gelen parametre nin değişken ismi ile class taki  parametreyi atayacağımız değişken in isimleri aynıdır ...
            this.KisaKenar = Kisakenar;

        }
        public int DikdörtgenAlanHesapla()
        {
            int Alan = KisaKenar * UzunKenar;
            return Alan;
        }




    }



}
