using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService )
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealCustomer(gamer)) 
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Kayıt işlemi Başarısız.");
            }
              
        }
    }
}
