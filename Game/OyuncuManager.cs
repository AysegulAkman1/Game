using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OyuncuManager : IOyuncuManager
    {
        public void Add(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.TcNo + " " + oyuncu.Name + " " + oyuncu.Soyadi + " " + oyuncu.DogumYili);
        }

        public void Delete(Oyuncu oyuncu)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Oyuncu oyuncu)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
