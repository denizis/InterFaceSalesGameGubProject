using GameHub.Abstract;
using GameHub.Adapters;
using GameHub.Concrete;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Player Add----------");
            Player player = new Player();
            player.Player_Ad = "Deniz";
            player.Player_Soyad = "İskender";
            player.Player_Id = 1;
            player.Player_TcNo = "11111";
            player.Player_DogumYili = new DateTime(2003, 6, 25);

            BasePlayerManager manager = new GamePlayerManager(new ServiceAdapter());

            manager.Save(player);//ServiceReferance tarafından Tc kimlik bilgileri teyit edildi.
          //  manager.Update(player);
          //  manager.Delete(player);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("---------Game Add----------");
            //Oyun Sistme Ekleme
            Product product = new Product();
            product.ProductName = "pes 2025";
            product.Product_Id = 1;
            product.Product_Price = 2500;
            product.Product_Description = "Futol oyunu";
            product.Product_Category = "Futbol";

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(product);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            //Campaign(Kampanya Ekleme silme 


            Console.WriteLine("---------Campaing Eklendi----------");
            Campaign campaign1 = new Campaign();
            campaign1.Campaign_id = 1;
            campaign1.Campaign_name = " Discount Mount";
            campaign1.Campaign_Discount = -50.0;
            campaign1.Campaign_StartDate = new DateTime(2025,4,25);
            campaign1.Campaign_EndDate = new DateTime(2025,5,1);


            
           
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Campaing_Add(campaign1);

            Console.WriteLine("  ");

                 //Satış Kısmı 
            Console.WriteLine("----Satış-----------");
            SalesPageManager salesPageManager = new SalesPageManager(); 
            salesPageManager.Buy(player,product,campaign1);




            Console.Read();
        }
    }
}
