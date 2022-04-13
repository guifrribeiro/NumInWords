namespace Reader
{
    public static class PluralityHandler
    {
        public static string PluralHandler(double number)
        {
            return number > 1 || number < -1 ? "s" : string.Empty;
        }
    }
}
