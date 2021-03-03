using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void Save(Gamer gamer);
        void ToList();
        void GameSale(Gamer gamer);
    }
}
