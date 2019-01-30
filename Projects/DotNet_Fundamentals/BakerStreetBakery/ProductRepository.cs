using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
   public class ProductRepository
    {
        private List<Product> _product = new List<Product>();
        public void AddProductToList(Product newProduct)
        {
            _product.Add(newProduct);
        }
        public List<Product>GetProductList()
        {
            return _product;
        }
        public void RemoveProductList(Product newProduct)
        {
            _product.Remove(newProduct);
        }
        public decimal CalculateCost(BakeType type)
        {
            decimal baseCost = 100m;

            switch (type)
            {
                case BakeType.Bread:
                    baseCost += 500.01m;
                    break;
                case BakeType.Cake:
                    baseCost += 2000m;
                    break;
                case BakeType.Pastry:
                    baseCost += 200.10m;
                    break;
                case BakeType.Pie:
                    baseCost += 851.5m;
                    break;

            }
            return baseCost;

        }    
        
    }
}
