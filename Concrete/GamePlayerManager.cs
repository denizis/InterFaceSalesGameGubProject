using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Concrete
{
    //BasePlayerManager dan veri tabanı işlemlerimizi yaptık verileri Ordan Abstract ile aldık
    public class GamePlayerManager : BasePlayerManager
    {
     
         IPersonCheckService _personCheckService;

        public GamePlayerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        //Burada kontrol için methodumuzu çağırdık
        public override void Save(Player player)
        {
            if (_personCheckService.CheckPerson(player))
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            

        }
       



   
    }
}
