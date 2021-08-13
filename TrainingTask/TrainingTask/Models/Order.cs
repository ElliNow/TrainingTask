using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingTask.Models
{
    public class Order
    {
        public double DeliveryCost { get; set; }
        public double? Sale { get; set; }
        public DateTime Date { get; set; }
        public PurchaseKind PurchaseKind { get; set; }
        //public List<Product> Products { get; set; }
        
        public Product Product { get; set; }
        public int Count { get; set; }

        public double GetOrderCost(PurchaseKind purchaseKind)
        {
            double orderCost = 0;
            if (purchaseKind == PurchaseKind.First)
            {
                orderCost = ((Product.Price * Count) * (Sale.Value / 100));
                return orderCost;
            }
            else if (purchaseKind == PurchaseKind.Second)
            {
                orderCost = (Product.Price * Count) - DeliveryCost;
                return orderCost;
            }
            else if (purchaseKind == PurchaseKind.Third)
            {
                orderCost = (Product.Price * Count) - Product.Price;
                return orderCost;
            }
            return orderCost;
        }
    }

    public enum PurchaseKind
    {
        First,
        Second,
        Third
    }
}