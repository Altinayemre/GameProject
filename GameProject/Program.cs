using GameProject.Concrete;
using System;
using MernisServiceReference;
using GameProject.Adapters;
using GameProject.Abstract;
using GameProject.Entites;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Altınay",
                DateOfBirth = new DateTime(1998,7,13),
                TcNumber ="01234567890"
            };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                FirstName = "Halil",
                LastName = "Sönmez",
                DateOfBirth = new DateTime(1999, 8, 15),
                TcNumber = "12345678910"
            };           

            Game game1 = new Game
            {
                GameName = "Mount Blade II BannerLord",
                GamePrice = 149
            };

            Game game2 = new Game
            {
                GameName = "The Witcher 3 Wild Hunt ",
                GamePrice=59
            };

            Campaign campaign1 = new Campaign
            {
                DiscountName = "70 TL ve üzeri harcamaya özel %20 indirim",
                DiscountAmount = 20
            };

            Campaign campaign2 = new Campaign
            {
                DiscountName = "yılbaşı özel %50 indirim",
                DiscountAmount = 50
            };

            BaseGamerManager gamerManager = new GamerManager(new GamerCheckManager());

            gamerManager.Save(gamer1);
            Console.WriteLine();
            gamerManager.Save(gamer2);


            GameSaleManager sales = new GameSaleManager();

            Console.WriteLine();
            sales.Sell(game1,gamer1);
                  
            Console.WriteLine();
            sales.CampaignSell(gamer2, game1, campaign1);
          
            Console.WriteLine();
            sales.Sell(game2,gamer2);
           
            Console.WriteLine();
            sales.CampaignSell(gamer1, game2, campaign2);

            Console.ReadLine();
        }
    }
}
