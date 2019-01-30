using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{   public enum BakeType { Bread, Cake, Pastry, Pie}
    public class Product
    {
        public string ProductName  { get; set; }
        public string CustomerName { get; set; }
        public int OrderBatchSize { get; set; }
        public decimal OrderCost { get; set; }
        public BakeType BakeItem { get; set; }

        public Product(string productName, string customerName, int orderBatchSize, decimal orderCost, BakeType bakeItem)
        {
            ProductName = productName;
            CustomerName = customerName;
            OrderBatchSize = orderBatchSize;
            OrderCost = orderCost;
            BakeItem = bakeItem;
        }

        public Product() { }
    }
    
}
