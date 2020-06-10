using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Enginee.Model
{
    public interface IPromotion
    {
        int PromotionId { get; set; }

        int Unit { get; set; }

        string PromotionName { get; set; }

        decimal PromotinoPrise { get; set; }

        List<IProduct> Products { get; set; }

    }
}
