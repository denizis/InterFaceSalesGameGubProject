using GameHub.Abstract;
using GameHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Concrete
{
    public class GamerManager : IGameService
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Oyun Sisteme eklendi");

        }

        public void Remove(Product product)
        {
            Console.WriteLine(product.ProductName+ "Oyun Sistemden Silindi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+ "Oyun Güncellendi");
        }
    }
}
