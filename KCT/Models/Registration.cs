using Microsoft.AspNetCore.Identity;

namespace KCT.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptionl { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

    }
}
