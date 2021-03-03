using GamerProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class NewCampanyGame: BaseGameSale
    {
        public override void PubgMobile(Gamer gamer)
        {
            Console.WriteLine("Pubg mobile bilgisayarda oyun konsolu hediyeli :)");
            base.PubgMobile(gamer);
        }
    }
}
