using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Enginee.Model
{
    public class Product : IProduct
    {
        public string ItemName { get; set; }

        public decimal Price { get; set; }

        public int ItemId { get; set; }
       // public IPromotion Promotion { get; set; }
    }
}
