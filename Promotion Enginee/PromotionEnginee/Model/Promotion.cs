using Promotion_Enginee.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEnginee.Model
{
    public class Promotion : IPromotion
    {      
        public int PromotionId { get; set; }
        public int Unit { get; set; }
        public decimal PromotinoPrise { get; set; }
        public string PromotionName { get; set; }
        public List<IProduct> Products { get; set; }
    }
}
