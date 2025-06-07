using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebApi.EfCore
{
    [Table("order")]
    public class Order
    {
        [Key, Required]
        public int id { get; set; }

        [Required]
        public int product_id { get; set; }      

        [Required]
        public string customer_name { get; set; } = string.Empty;

        public int quantity { get; set; }

        public DateTime order_date { get; set; } = DateTime.UtcNow;

        
    }
}
