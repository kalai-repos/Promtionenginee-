using Promotion_Enginee.Data;
using Promotion_Enginee.Model;
using PromotionEnginee.Data;
using PromotionEnginee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEnginee.Factory
{

    /// <summary>
    /// simple factory 
    /// </summary>
    public class Factorypattern
    {
        public static IProductRepository GetProductModel()
        {
            return new ProductRepository();
        }
        public static IPromotionRepository GetPromotionRepository()
        {
            return new PromotionRepository();
        }
        public static IProductModel GetProduct()
        {
            return new ProductModel();
        }
    }
}
