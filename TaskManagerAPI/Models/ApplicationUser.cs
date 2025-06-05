using Microsoft.AspNetCore.Identity;

namespace TaskManagerAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Aquí puedes añadir más propiedades personalizadas si quieres
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
