using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;


namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer { DateOfBirth = new DateTime(1998, 05, 28), FirstName = "Rumeysa", LastName = "Koçak", NationalityId = "564644" });

            Game game1 = new Game() { GameId = 1, GameName = "CS:GO", GamePrice = 600 };
            Game game2 = new Game() { GameId = 2, GameName = "LOL", GamePrice = 580 };
            Game game3 = new Game() { GameId = 3, GameName = "PUBG", GamePrice = 700 };
            Game game4 = new Game() { GameId = 4, GameName = "AMONG US", GamePrice = 850 };


            Campaign campaign1 = new Campaign() { CampaignName = "New Member Campaign", DiscountRate = 25, CampaignId = 3 };
            Campaign campaign2 = new Campaign() { CampaignName = "Valentines Day Campaign", DiscountRate = 40, CampaignId = 4 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);


            Sale sale1 = new Sale() { GameId = 1 , CampaignId=1 };
            Sale sale2 = new Sale() { GameId = 3, CampaignId = 2 };

            SaleManager saleManager = new SaleManager();
            saleManager.Add(sale2);
            saleManager.Add(sale1);
            saleManager.Delete(sale2);
            saleManager.Delete(sale1);
            saleManager.Update(sale1);
            saleManager.Update(sale2);

            Console.ReadLine();
        }
    }
}
