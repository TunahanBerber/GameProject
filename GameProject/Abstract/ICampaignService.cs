using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        public void AddCampaign(Campaign campaign);
        public void UpdateCampaign(Campaign campaign);
        public void DeleteCampaign(Campaign campaign);
        public void AddProduct(Campaign campaignId, Game gameId);
    }
}
