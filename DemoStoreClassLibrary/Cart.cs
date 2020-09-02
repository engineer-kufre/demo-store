using System;

namespace DemoStoreClassLibrary
{
    public class Cart
    {
        //cart model
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
    }
}
