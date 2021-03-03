using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public abstract class BaseGameSale : IGameSaleService
    {
        public virtual void Metin2(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ "oyunu satın aldı.");
        }

        public virtual void PubgMobile(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyunu satın aldı.");
        }
    }
}
