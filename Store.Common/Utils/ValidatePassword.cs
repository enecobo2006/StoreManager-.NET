using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Utils
{
    public static partial class ValidatePassword
    {
        public static string GetValidPassword(string value)
        {
            if (value.Length < 8)
                throw new ArgumentOutOfRangeException("Password duhet te kete te pakten 8 karaktere!");
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZW";
            bool contains = false;
            foreach (var ch in value)
            {
                if (alphabet.Contains(ch))
                {
                    contains = true;
                    break;
                }
            }
            if (!contains)
                throw new ArgumentOutOfRangeException("Password duhet te kete te pakten 1 germe te madhe!");
            return value;
        }
    }
}
