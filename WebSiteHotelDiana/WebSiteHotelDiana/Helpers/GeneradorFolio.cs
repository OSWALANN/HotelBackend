namespace WSTarjtaJuventud.Helpers {
    public static class GeneradorFolio {
        public static string GenerarFolio(string codigo) {

            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return $"{codigo}-PC{code}-{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year - 2000}";
        }
    }
}
