using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : ISaleService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli kullanıcı: ");        
            Console.WriteLine(game.GameName +" Adlı oyunu " + game.GamePrice + " TL fiyatına satın aldı.");
        }

        public void CampaignSell(Gamer gamer, Game game, Campaign campaign)
        {
            game.GamePrice = game.GamePrice-((game.GamePrice*campaign.DiscountAmount)/100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli kullanıcı: ");    
            Console.WriteLine(game.GameName +" Adlı oyunu " + campaign.DiscountName + " kampanyasından yararlanarak " + game.GamePrice + " TL fiyatına satın aldı.");
        }

    }
}
