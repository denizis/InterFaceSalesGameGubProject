using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    //IPersonCheckService Yazmamım Nedeni İlerleyen dönemlerede yeni bir şirketinde kendi uygulaması için
    //Kişi doğrulma isteyebilir olması
    public interface IPersonCheckService
    {
        bool CheckPerson(Player player);
    }
}
