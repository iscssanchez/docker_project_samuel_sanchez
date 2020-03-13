using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class StringMatch
    {
        public bool Solve(string stringBase, string token)
        {
            int i = 0;
            int j = 0;
            while(i < stringBase.Length)
            {
                if(stringBase[i] == token[j])
                {
                    j++;
                    i++;
                }
                else
                {
                    if (j == 0) i++;
                    j = 0;
                }               
            }
            if (j == token.Length) return true;

            return false;
        }
    }
}
