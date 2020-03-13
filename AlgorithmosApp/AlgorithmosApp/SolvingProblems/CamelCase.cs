using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class CamelCase
    {
        public int Solve(string s)
        {
            int result = 1;
            string source = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for(int i = 0; i < s.Length; i++)
            {
                if (source.Contains(s[i])) result++;
            }
            return result;                    
        }
    }
}
