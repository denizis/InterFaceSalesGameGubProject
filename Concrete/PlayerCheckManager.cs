using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Concrete
{
    public class PlayerCheckManager: IPersonCheckService
    {

        public bool CheckPerson(Player player)
        {
            //Bu şekilde Service Bağımlı oluyorsun Service çalışmadığında sistem çalışmaz.
          // ServiceReference1.KPSPublicSoapClient client
          //Test ortamında bunu kullanabiliriz.
          return true;
        }
    }
}
