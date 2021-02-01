using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class KampanyaManager : IKampanyaManager
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
             
          Console.WriteLine(kampanya.KampanyaUrunName + " ürün " + kampanya.Urunİndirimi + " TL olarak indirime girdi.");

        }
    }
}
