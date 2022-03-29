using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp58
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(0).ToLower();

        }

        public static int GetValueIndexes(this string str, char c)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == c)
                    count++;
            }

            return count;
        }
    }
}
