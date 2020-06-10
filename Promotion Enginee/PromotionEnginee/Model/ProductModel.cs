using Promotion_Enginee.Data;
using Promotion_Enginee.Model;
using PromotionEnginee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEnginee.Model
{
    public class ProductModel : IProductModel
    {
        
        
        public IProduct Product { get; set; }
        public int Quanity { get; set; }

        public decimal SubTotal { get; set; }        
        public IPromotion Promotion { get; set; }

         //return _promotionRepository.GetAll().FirstOrDefault(p => p.Products.Contains(Product));

    }
}
