using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgospringInsurance.DataAccess.Models
{
    [Table("EmailReceivers")]
    public class EmailReceivers : EntityBase
    {
        public string Email { get; set; } = string.Empty;

        public bool IsMotor { get; set; }

        public bool IsMedical { get; set; }
    }
}
