using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgospringInsurance.App.Dtos
{
    public static class LoginFormDataParser
    {
        public static string? LoginName { get; set; }

        public static string? Email { get; set; }

        public static bool IsAdmin { get; set; }
    }
}
