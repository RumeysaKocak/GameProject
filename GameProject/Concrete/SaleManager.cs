using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Sale added :)" + sale.CampaignId + sale.GameId + sale.Id);
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Sale deleted :(" + sale.CampaignId + sale.GameId + sale.Id);
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Sale updated!" + sale.CampaignId + sale.GameId + sale.Id);
        }
    }
}
