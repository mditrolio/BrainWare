﻿namespace BrainWare.Domain.Models
{
    public class OrderProduct
    {
        public Order Order { get; set; }

        public int OrderId { get; set; }

        public decimal Price { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}