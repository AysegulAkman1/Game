using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class SatisManager : ISatisManager
    {
        public void Satis(Oyuncu oyuncu, Satis satis)
        {
            Console.WriteLine(oyuncu.Name + " isimli üye " + satis.OyunName + " oyununu aldı");
        }
    }
}
