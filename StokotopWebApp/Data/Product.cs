using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StokotopWebApp.Data
{
    public class Product
    {
        [Key, Required]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [StringLength(50), Required]
        [Display(Name = "Nom :")]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}