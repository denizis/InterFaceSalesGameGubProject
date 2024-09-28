using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Adapters
{
    public class ServiceAdapter : IPersonCheckService
    {
        public bool CheckPerson(Player player)
        {
            ServiceReference1.KPSPublicSoapClient client=new ServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.Player_TcNo),player.Player_Ad.ToUpper(),player.Player_Soyad.ToUpper(),player.Player_DogumYili.Year);
        }
    }
}
