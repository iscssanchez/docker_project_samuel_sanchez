using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class SuperReducedString
    {
        public string Solve(string s)
        {
            int i = 0;
            int j = 1;
            int counter = 0;
            StringBuilder result = new StringBuilder();
            if (string.IsNullOrEmpty(s)) return "Empty String";
            if (s.Length == 1) return s;
            while (counter < s.Length)
            {
                if( (s.Length - i == 1) || s[i] != s[j])
                {
                    result.Append(s[i]);
                    i = j;
                    j++;
                }
                else
                {
                    j += 2;
                    i += 2;
                }
                counter = i;                
            }
            string tmp = result.ToString();
            if (tmp.Length == 2 && tmp[0] == tmp[1]) return "Empty String";
            return string.IsNullOrEmpty(result.ToString()) ? "Empty String": result.ToString();
        }
    }
}
