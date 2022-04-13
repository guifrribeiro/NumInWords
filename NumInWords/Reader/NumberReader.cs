using NumInWords;
using System;

namespace Reader
{
    public static class NumberReader
    {
        public static string NumberIntoWord(double number)
        {
            if (number == 0)
            {
                return "zero";
            }

            double intPart = Math.Truncate(number);
            double decPart = number - Math.Truncate(number);

            string result = string.Empty;
            result += $"{(intPart != 0 ? $"{IntegerIntoWord((int)intPart)} dollar{PluralityHandler.PluralHandler(intPart)} " : string.Empty)}";
            result += $"{(intPart != 0 && decPart != 0 ? "and" : string.Empty)} ";
            result += $"{(decPart != 0 ? $"{IntegerIntoWord((int)Math.Round(Math.Abs((decimal)decPart * 100)))} cents" : string.Empty)}";

            return result;
        }

        public static string IntegerIntoWord(int number)
        {
            string result = string.Empty;

            if (number < 0)
            {
                result += $"minus {IntegerIntoWord(Math.Abs(number))}";
            }
            else if (number / 1000000 > 0)
            {
                result += $"{IntegerIntoWord(number / 1000000)} million ";
                result += IntegerIntoWord(number % 1000000);
            }
            else if (number / 1000 > 0)
            {
                result += $"{IntegerIntoWord(number / 1000)} thousand ";
                result += IntegerIntoWord(number % 1000);
            }
            else if (number / 100 > 0)
            {
                result += $"{IntegerIntoWord(number / 100)} hundred{(number % 100 > 0 ? " and " : string.Empty)}";
                result += IntegerIntoWord(number % 100);
            }

            if (number >= 10 && number < 20)
            {
                result += GlobalVars.tensToNineteen[number - 10];
            }
            else if (number >= 0 && number < 10)
            {
                result += GlobalVars.units[number];
            }

            if (number >= 20 && number < 100)
            {
                result += TenNumbersIntoWord(number);
            }

            return result;
        }

        public static string TenNumbersIntoWord(int number)
        {
            return $"{GlobalVars.tens[(number / 10) - 2]} {(number % 10 > 0 ? IntegerIntoWord(number % 10) : String.Empty)}";
        }
    }
}
