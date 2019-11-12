using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacimVeAlanHesaplama
{
    public class Hacim
    {

        private int UzunKenar { get; set; }
        private int KısaKenar { get; set; }
        private int AyrıtUzunluk{ get; set; }
        private int KüpKenari { get; set; }
       
        public Hacim(int u,int k,int a)//Dikdörtgen prizmaların hacmini hesaplamak için oluşturulmuştur ve 3 parametre alır...
        {
            this.UzunKenar = u;
            this.KısaKenar = k;
            this.AyrıtUzunluk = a;
            
        }
        public int HacimHesapla()
        {
            int hacim = UzunKenar * KısaKenar * AyrıtUzunluk;

            return hacim;
        }
        public Hacim(int Kare)//Küpler için oluşturulmuştur ve bir parametre yeterlidir...
        {
            this.KüpKenari = Kare;
        }
        public int HacimHesaplaKüp()
        {
            int hacim = KüpKenari * KüpKenari * KüpKenari;
            return hacim;
        }


    }
}
