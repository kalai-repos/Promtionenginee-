using Promotion_Enginee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Enginee.Data
{
    public interface IProductRepository
    {
        IEnumerable<IProduct> GetAll();
        IProduct Get(long id);
        void Insert(IProduct entity);
        void Update(IProduct entity);
        void Delete(IProduct entity);

        IProduct Get(string prodName);
    }
}
