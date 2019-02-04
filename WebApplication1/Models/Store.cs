using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Store
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}