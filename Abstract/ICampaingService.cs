using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    public interface ICampaingService
    {
        void Campaing_Add(Campaign campaign);
        void Campaing_Remove(Campaign campaign);
        void Campaing_Update(Campaign campaign);
    }
}
