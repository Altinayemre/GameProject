using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName+": Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName+": Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName+": Kampanya güncellendi");
        }
    }
}
