using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sell(Game game, Gamer gamer);
        void CampaignSell(Gamer gamer, Game game, Campaign campaign);
    }
}
