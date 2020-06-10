namespace Promotion_Enginee.Model
{
    public interface IProduct
    {
        int ItemId { get; set; }
        string ItemName { get; set; }
        decimal Price { get; set; }
       // IPromotion Promotion { get; set; }
    }
}