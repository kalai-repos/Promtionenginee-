using Promotion_Enginee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promotion_Enginee.Data
{
    public class ProductRepository : IProductRepository
    {
        public List<IProduct> entities;
        public ProductRepository()
        {
            this.entities = new List<IProduct>()
            {
            new Product {ItemId=1,ItemName="A",Price=50,Promotion=},
            new Product {ItemId=2,ItemName="B",Price=30},
            new Product {ItemId=3,ItemName="C",Price=20},
            new Product {ItemId=4,ItemName="D",Price=15}};

        }

        public IEnumerable<IProduct> GetAll()
        {
            return entities.ToList();
        }
        public IProduct Get(long id)
        {
            return entities.SingleOrDefault(s => s.i == id);
        }

        public IProduct Get(string prodName)
        {
            return entities.FirstOrDefault(s => s.ItemName == prodName);
        }


        public void Insert(IProduct entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);

        }
        public void Update(IProduct entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

        }
        public void Delete(IProduct entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

    }
}
