using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Concrete
{
    public class CampaingManager :ICampaingService
    {
        public void Campaing_Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi"+ campaign.Campaign_name);
        }

        public void Campaing_Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi" + campaign.Campaign_name);
        }

        public void Campaing_Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi" + campaign.Campaign_name);
        }
    }
}
