using Microsoft.AspNetCore.Identity;

namespace E_TicktsCinma.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Address { get; set; }
    }
}
