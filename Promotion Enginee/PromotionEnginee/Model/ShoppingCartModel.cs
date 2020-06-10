using Promotion_Enginee.Data;
using PromotionEnginee.Data;
using PromotionEnginee.Factory;
using PromotionEnginee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promotion_Enginee.Model
{
    public class ShoppingCartModel :IShoppingcartModel
    {

        List<IProductModel> cart = new List<IProductModel>();

        readonly IPromotionRepository _promotionRepository;
        readonly IProductRepository _productRepository;

        public ShoppingCartModel(IPromotionRepository promotionRepository,IProductRepository productRepository)
        {
            _promotionRepository = promotionRepository;
            _productRepository = productRepository;
        }
        public decimal Gettotal()
        {
            return cart.Sum(p => p.SubTotal);            
        }


        public  void AddProdut( string prodName,int quanity)
        {
            IProductModel productmodel = Factorypattern.GetProduct();
            productmodel.Product = _productRepository.Get(prodName);
            productmodel.Quanity = quanity;
            productmodel.Promotion = _promotionRepository.GetAll().FirstOrDefault(p => p.Products.Contains(productmodel.Product));
           
            cart.Add(productmodel);
        }

        private decimal RunninTotal()
        {
            var tsList = from ts in cart
                         group new { ts.Promotion, ts.Product } by ts.Product into grp
                         select new { Subject = grp.Key, Subtotal =  };
        }

    }
}
