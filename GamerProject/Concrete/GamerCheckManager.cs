using GamerProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer) => true;
    }
}
