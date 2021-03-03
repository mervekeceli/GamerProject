using GamerProject.Abstract;
using GamerProject.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class GamerListManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        List<Gamer> gamers;

        public GamerListManager(IGamerCheckService gamerCheckService)
        {
            gamers = new List<Gamer>();
            _gamerCheckService = gamerCheckService;
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid gamer");
            }
        }

        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
        }

        public void Update(Gamer gamer)
        {
            foreach (var i in gamers)
            {
                if (gamer == i)
                {
                    Console.WriteLine("Gamer Updated:\n Gamer Name: ");
                    i.FirstName = Console.ReadLine();
                    Console.WriteLine("Gamer Lastname: ");
                    i.LastName = Console.ReadLine();
                }
            }
        }

        public void ToList()
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName);
            }
        }

        public void GameSale(Gamer gamer)
        {
            NewCampanyGame newCampanyGame = new NewCampanyGame();
            newCampanyGame.PubgMobile(gamer);
        }
    }
}
