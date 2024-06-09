using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Functions
{
    public class HashPass
    {
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[20];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        public static int GeneraterRandomCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999);

        }
        public static string HashPasswordWithSalt(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt); // добавление соли к паролю
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
