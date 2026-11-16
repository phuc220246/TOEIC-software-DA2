using System.Security.Cryptography;

namespace TOEIC_Practice.BLL.Security
{
    public static class PasswordHelper
    {
        private const int Iterations = 100000;
        private const int SaltSize = 32;
        private const int HashSize = 64;

        public static byte[] CreateSalt()
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static byte[] HashPassword(string passwordPlain, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordPlain, salt, Iterations))
            {
                return pbkdf2.GetBytes(HashSize);
            }
        }

        public static bool VerifyPassword(string passwordPlain, byte[] salt, byte[] expectedHash)
        {
            byte[] actualHash = HashPassword(passwordPlain, salt);
            return FixedTimeEquals(actualHash, expectedHash);
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }
    }
}