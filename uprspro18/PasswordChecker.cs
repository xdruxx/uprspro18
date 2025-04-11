using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprspro18
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }///первая проверка которая требует наличия *
            if (password.Length < 8 || password.Length > 20)
            {
                return false;
            }
            if (!password.Any(Char.IsLower))
            {
                return false;
            }
            if (!password.Any(Char.IsUpper))
            {
                return false;
            }
            if (!password.Any(Char.IsDigit))
            {
                return false;
            }
            if (password.Intersect("#&%$_*^").Count() == 0)
            {
                return false;
            }
           
            if (password == null)
            {
                return false;
            }
            if (!password.Contains('*')) // требуем
            {
                return false;
            }
            if (password.Contains('*'))// не требуем 
            {
                return false;
            }
                return true;
        }
    }
}
