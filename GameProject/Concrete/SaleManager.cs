using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager:ISaleService
    {
        public void Sale(Game game)
        {
            Console.WriteLine(game.GameName+" has been sold for "+ game.Price);
        }

        public void ClearenceSale(Game game, Campaign campaign)
        {
            double newPrice = game.Price * campaign.Discount;
            Console.WriteLine(game.GameName + " has been sold for " + newPrice + " with %50 Discount. This Discount is avaible until " + campaign.EndOfCampaignDate);
        }

    

    }
}
