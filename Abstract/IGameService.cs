using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Abstract
{
    public interface IGameService
    {
        void Add(Product product);
        void Remove(Product product);
        void Update(Product product);

    }
}
