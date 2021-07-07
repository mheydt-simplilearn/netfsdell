using System;

namespace EHealth.Shared.Models
{
    public class Medicine : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Seller { get; set; }
    }
}
