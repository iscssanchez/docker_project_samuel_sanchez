using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class StrongPassword
    {
        public int Solve(int n, string password)
        {
            int changesResult = 0;
            int result = 0;
            int requiredLength = 6;
            string numbers = "0123456789",
            lower_case = "abcdefghijklmnopqrstuvwxyz",
            upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            special_characters = "!@#$%^&*()-+";

            //if (password.Length < requiredLength) result = requiredLength - password.Length;
            bool number = false;
            bool lowerCase = false;
            bool upperCase = false;
            bool specialChar = false;
            int i = 0;

            while(i < password.Length)
            {
                if (!number && char.IsNumber(password[i]))
                {
                    result++;
                    number = true;
                }
                if (!lowerCase && char.IsLower(password[i]))
                {
                    result++;
                    lowerCase = true;
                }
                if (!upperCase && char.IsUpper(password[i]))
                {
                    result++;
                    upperCase = true;
                }
                if(!specialChar && special_characters.Contains(password[i]))
                {
                    specialChar = true;
                    result++;
                }
                i++;
                if (result >= 4) break;
            }
            if(result < 4)
            {
                changesResult = 4 - result;
            }
            return Math.Max(changesResult, requiredLength - password.Length);
        }
    }
}
