using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    internal interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
