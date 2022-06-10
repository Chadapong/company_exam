using System.ComponentModel.DataAnnotations;

namespace vendor_store_web_api.Dtos.UserDto
{
    public class UserDto
    {
        // personal info
        [Key]
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]

        public string Phone { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
