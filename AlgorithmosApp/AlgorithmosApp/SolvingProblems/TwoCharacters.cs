using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class TwoCharacters
    {
        public int Solve(string s)
        {
            List<Tuple<char, char>> source = new List<Tuple<char, char>>();
            int charactersResult = 0;
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i + 1; j < s.Length; j++)
                {
                    if(s[i] != s[j])
                    {
                        var tuple = new Tuple<char, char>(s[i], s[j]);
                        if (!source.Contains(tuple))
                        {
                            source.Add(tuple);
                        }
                    }
                }
            }
            char expected;
            StringBuilder result = new StringBuilder();
            List<string> source2 = new List<string>();
            foreach(var item in source)
            {
                expected = item.Item1;
                for(int i =0; i < s.Length; i++)
                {
                    if(s[i] == expected)
                    {
                        if (i < s.Length - 1 && s[i] == s[i + 1]) break;
                        result.Append(s[i]);
                        expected = expected == item.Item1 ? item.Item2: item.Item1;
                    }
                }
                source2.Add(result.ToString());
               
                charactersResult = result.ToString().Length > charactersResult ? result.ToString().Length : charactersResult;
                result.Clear();
            }
            return charactersResult;
        }
    }
}
