using System.ComponentModel.DataAnnotations;

namespace vendor_store_web_api.Models
{
    public class Item
    {
        [Key]
        [Required]
        public Guid ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string Category { get; set; }
        
    }
}
