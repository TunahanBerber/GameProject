using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("You Added"  + campaign.CampaignName + "that is avaible between " + campaign.StartOfCampaignDate + "and" + campaign.EndOfCampaignDate +" dates");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("You Changed Campaing İnformation");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("You Deleted" + campaign.CampaignName);
        }

        public void AddProduct(Campaign campaign, Game game)
        {
            double newPrice = game.Price * campaign.Discount;
            Console.WriteLine("You Added " + campaign.CampaignName + " that is avaible for " + game.GameName);
        }
    }
}
