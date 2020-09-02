using System;

namespace DemoStoreClassLibrary
{
    public class Product
    {
        //product model
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
