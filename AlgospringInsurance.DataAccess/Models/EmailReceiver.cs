using System.ComponentModel.DataAnnotations.Schema;

namespace AlgospringInsurance.DataAccess.Models
{
    [Table("email_receiver")]
    public class EmailReceiverRegistration : EntityBase
    {
        public string Email { get; set; } = string.Empty;

        public bool IsMotor { get; set; }

        public bool IsMedical { get; set; }
    }
}
