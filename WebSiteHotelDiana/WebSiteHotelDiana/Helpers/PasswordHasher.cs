using System.Security.Cryptography;

namespace WSTarjetaJuventud.Helpers {
    public static class PasswordHasher {
        private const int SaltSize = 16; // 128 bits
        private const int KeySize = 32;  // 256 bits
        private const int Iterations = 100_000;

        public static string HashPassword(string password) {
            // Generar salt aleatorio
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            // Generar hash usando PBKDF2
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                KeySize
            );

            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public static bool VerifyPassword(string password, string hashedPassword) {
            // Formato esperado: iteraciones.salt.hash
            var parts = hashedPassword.Split('.', 3);

            if (parts.Length != 3)
                return false;

            int iterations = int.Parse(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] hash = Convert.FromBase64String(parts[2]);

            // Recalcular hash con la contraseña proporcionada
            byte[] hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                hash.Length
            );

            return CryptographicOperations.FixedTimeEquals(hashToCompare, hash);
        }
    }
}
