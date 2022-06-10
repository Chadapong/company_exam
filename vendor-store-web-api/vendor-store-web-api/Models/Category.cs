using System.ComponentModel.DataAnnotations;

namespace vendor_store_web_api.Models
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }
    }
}
