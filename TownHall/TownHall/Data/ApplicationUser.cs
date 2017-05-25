using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TownHall.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
