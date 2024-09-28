using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Concrete
{
    public class SalesPageManager : ISalesPage
    {
        public void Buy(Player player, Product product, Campaign campaign)
        {
            Console.WriteLine("Oyuncu "+player.Player_Ad+" "+product.ProductName+"Adlı oyunu "+campaign.Campaign_name+" Kampanya türünden  almıştır." );
            Console.WriteLine("Oyunun fiyatı:"+product.Product_Price);
            Console.WriteLine("Satış gerçekleşmiştir.");
        }
    }
}
