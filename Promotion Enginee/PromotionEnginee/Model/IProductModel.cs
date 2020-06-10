using Promotion_Enginee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEnginee.Model
{
    public interface IProductModel
    {
         IProduct Product { get; set; }        
         int Quanity { get; set; }
        decimal SubTotal { get; set; }
        IPromotion Promotion { get; set; }
    }
}
