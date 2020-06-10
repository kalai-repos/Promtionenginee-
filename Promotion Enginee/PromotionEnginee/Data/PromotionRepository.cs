using Promotion_Enginee.Model;
using PromotionEnginee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace PromotionEnginee.Data
{
    public class PromotionRepository : IPromotionRepository
    {
        public List<IPromotion> entities;
        public PromotionRepository()
        {
            entities = new List<IPromotion>();
            //{
            //new Promotion {PromotionId=1,PromotionName="A", Products= ,Unit=3,PromotinoPrise=130},
            //new Promotion {PromotionId=2,PromotionName="B",Unit=2,PromotinoPrise=45},
            //new Promotion {PromotionId=3,PromotionName="C & D",Unit=1,PromotinoPrise=20}
            //};
        }
        public IEnumerable<IPromotion> GetAll()
        {
            return entities.ToList();
        }
        public IPromotion Get(long id)
        {
            return entities.SingleOrDefault(s => s.PromotionId == id);
        }
        public void Insert(IPromotion entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);

        }
        public void Update(IPromotion entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

        }
        public void Delete(IPromotion entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
    }
}
