using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavzak.Logic
{
    public class Validation
    {
        public static bool FullNameValidation(string fullName, out string errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                errorMessage = "Name cannot be empty.";
                return false;
            }

            fullName = fullName.Trim();

            if (fullName.Contains("  "))
            {
                errorMessage = "Name cannot contain consecutive spaces.";
                return false;
            }

            foreach (char c in fullName)
            {
                if (!IsEnglishLetter(c) && !IsHebrewLetter(c) && c != ' ')
                {
                    errorMessage = "Name can contain only Hebrew or English letters and spaces.";
                    return false;
                }
            }

            return true; 
        }

        private static bool IsEnglishLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        private static bool IsHebrewLetter(char c)
        {
            return (c >= 'א' && c <= 'ת');
        }
    }
}
