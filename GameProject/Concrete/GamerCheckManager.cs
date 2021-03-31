using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entites;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealCustomer(Gamer gamer)
        {
            return true;
        }
       
    }
}
