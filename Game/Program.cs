using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu = new Oyuncu { TcNo = "132456", Name = "Ayşegül", Soyadi = "Akman", DogumYili = 1996 };
            IOyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Add(oyuncu);


            Satis satis = new Satis { OyunName = "GTA", OyunFiyati = 400 };
            ISatisManager satisManager = new SatisManager();
            satisManager.Satis(oyuncu, satis);


            Kampanya kampanya = new Kampanya { KampanyaUrunName = "PUBG Mobile", Urunİndirimi = 12.5 };
            IKampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaEkle(kampanya);
        }
    }
}
