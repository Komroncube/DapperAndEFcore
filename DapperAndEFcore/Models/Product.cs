global using System.ComponentModel.DataAnnotations;

namespace DapperAndEFcore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
