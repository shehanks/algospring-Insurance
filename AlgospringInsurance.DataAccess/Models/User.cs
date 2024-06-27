using System.ComponentModel.DataAnnotations.Schema;

namespace AlgospringInsurance.DataAccess.Models
{
    [Table("User")]
    public class User : EntityBase
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool IsAdmin { get; set; } = false;
    }
}
