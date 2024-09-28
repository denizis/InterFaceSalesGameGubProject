using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    //BasePlayerManager Koymamızın Nedeni İki Ayrı sistemde Yani Starbucks ve NeroCoffe Aynı veri Tabanı kullanması
    //tabi bu proje kahveci değil ama bunu bende uygulmak istedim
    //Projenin İlerleyen bölümlerinde İşime Yarayabilir.
    public abstract class BasePlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Db den silindi"+player.Player_Ad);
        }

        //Buraya virtual Koymamızın Nedeni 
        //GamePlayerda Save kontrolü sağlamamız.Eziyoruz.
        public virtual void Save(Player player)
        {
            Console.WriteLine("Db ye kaydedildi "+player.Player_Ad);
            Console.WriteLine("Oyuncu Id: "+player.Player_Id);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Db Güncellendi " + player.Player_Ad);
        }
    }
}
