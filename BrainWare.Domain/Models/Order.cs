namespace BrainWare.Domain.Models
{
    using System.Collections.Generic;

    public class Order
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}