using System.ComponentModel.DataAnnotations.Schema;

namespace AlgospringInsurance.DataAccess.Models
{
    [Table("EmailReceivers")]
    public class EmailReceiver : EntityBase
    {
        public string Email { get; set; } = string.Empty;

        public bool IsMotor { get; set; }

        public bool IsMedical { get; set; }
    }
}
