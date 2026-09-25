using System;
using System.Security.Cryptography;

namespace Uno
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;
        private const string Prefix = "PBKDF2";

        public static string HashPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = deriveBytes.GetBytes(HashSize);
                return string.Join("$",
                    Prefix,
                    Iterations.ToString(),
                    Convert.ToBase64String(salt),
                    Convert.ToBase64String(hash));
            }
        }

        public static bool VerifyPassword(string password, string storedValue)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (string.IsNullOrEmpty(storedValue))
            {
                return false;
            }

            if (!IsHashedPassword(storedValue))
            {
                return storedValue == password;
            }

            string[] parts = storedValue.Split('$');
            if (parts.Length != 4)
            {
                return false;
            }

            if (!int.TryParse(parts[1], out int iterations) || iterations <= 0)
            {
                return false;
            }

            byte[] salt;
            byte[] expectedHash;
            try
            {
                salt = Convert.FromBase64String(parts[2]);
                expectedHash = Convert.FromBase64String(parts[3]);
            }
            catch (FormatException)
            {
                return false;
            }

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] actualHash = deriveBytes.GetBytes(expectedHash.Length);
                return FixedTimeEquals(expectedHash, actualHash);
            }
        }

        public static bool IsHashedPassword(string storedValue)
        {
            if (string.IsNullOrWhiteSpace(storedValue))
            {
                return false;
            }

            string[] parts = storedValue.Split('$');
            return parts.Length == 4 && parts[0] == Prefix;
        }

        private static bool FixedTimeEquals(byte[] left, byte[] right)
        {
            if (left == null || right == null || left.Length != right.Length)
            {
                return false;
            }

            int diff = 0;
            for (int i = 0; i < left.Length; i++)
            {
                diff |= left[i] ^ right[i];
            }

            return diff == 0;
        }
    }
}