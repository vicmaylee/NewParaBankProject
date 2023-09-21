namespace NewParaBankProject.Extensions
{
    public static class RansomDigitExtensionClass1
    {/// <summary>
    /// Method for random digits creation
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
        public static string AddRandomDigits(this string text) => string.Concat(text, new Random().Next(1, 999));
        public static string AddRandomDigits(this string text, string? subfix = null) => string.Concat(text, new Random().Next(1, 999), subfix);
        public static string AddRandomDigits2(this string text, string text2) => text + new Random().Next(1, 999) + text2;
    }
}
