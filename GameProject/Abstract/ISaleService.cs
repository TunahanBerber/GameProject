using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale(Game game);
        void ClearenceSale(Game game, Campaign campaign);
    }
}
