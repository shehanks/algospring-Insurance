using System.Security.Cryptography;
using System.Text;

namespace AlgospringInsurance.Infrastructure
{
    public sealed class SecurityProvider
    {
        public static string Encrypt(string password)
        {
            if (password is not null or "")
            {
                using (var sha256 = SHA256.Create())
                {
                    try
                    {
                        var pwdBytes = new UTF8Encoding().GetBytes(password);
                        var keyBytes = sha256.ComputeHash(pwdBytes);
                        return Convert.ToBase64String(keyBytes);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }
            }

            return string.Empty;
        }
    }
}
