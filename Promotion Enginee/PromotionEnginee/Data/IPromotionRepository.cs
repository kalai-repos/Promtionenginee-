using Promotion_Enginee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEnginee.Data
{
   public interface IPromotionRepository
    {
        IEnumerable<IPromotion> GetAll();
        IPromotion Get(long id);
        void Insert(IPromotion entity);
        void Update(IPromotion entity);
        void Delete(IPromotion entity);
    }
}
