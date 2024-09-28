using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    public interface IEntity : IPersonCheckService
    {
        bool CheckPerson(Player player);
    }
}
