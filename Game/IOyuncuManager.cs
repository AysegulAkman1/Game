using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IOyuncuManager
    {
        void Add(Oyuncu oyuncu);
        void Update(Oyuncu oyuncu);
        void Delete(Oyuncu oyuncu);
    }
}
