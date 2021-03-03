using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
