using Microsoft.AspNetCore.Identity;

namespace KCT.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

    }
}
