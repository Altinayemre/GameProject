using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerCheckService
    {      
       bool CheckIfRealCustomer(Gamer gamer); 
    }
}
