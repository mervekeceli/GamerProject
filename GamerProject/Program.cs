using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id = 1, FirstName = "Merve", LastName = "Keçeli", DateOfBirth = new DateTime(2000, 12, 12), NationalityId = "12318254356" };
            IGamerService gamer1 = new GamerListManager(new MernisServiceAdapters());
            gamer1.Save(gamer);

            gamer1.GameSale(gamer);
                
        }
    }
}
