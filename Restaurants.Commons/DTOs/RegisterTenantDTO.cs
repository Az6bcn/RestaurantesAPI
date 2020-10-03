using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Commons.DTOs
{
    public class RegisterTenantDTO
    {
        [Required]
        public string TenantName { get; set; }
        public DateTime CreatedAt => DateTime.UtcNow;

        // tenant default admin user
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConmfirmPassword { get; set; }
    }
}
