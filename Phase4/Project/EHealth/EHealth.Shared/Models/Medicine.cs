using System;

namespace EHealth.Shared.Models
{
    public class Medicine : BaseEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Seller { get; set; }
    }
}
