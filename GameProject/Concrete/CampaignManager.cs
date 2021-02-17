using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added :) " + campaign.CampaignName + "Discount rate : " + campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "deleted :((");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated!" + campaign.CampaignName + "Discount rate : " + campaign.DiscountRate);
        }
    }
}
