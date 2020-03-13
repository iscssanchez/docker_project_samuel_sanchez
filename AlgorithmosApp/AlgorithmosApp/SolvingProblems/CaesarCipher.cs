using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class CaesarCipher
    {
        public string caesarCipher(string s, int k)
        {
            string result = string.Empty;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> source = new Dictionary<char, int>();
            Dictionary<int, char> sourceIndex = new Dictionary<int, char>();
            Dictionary<char, int> sourceUpper = new Dictionary<char, int>();
            for (int index = 0; index < alphabet.Length; index++)
            {
                source.Add(alphabet[index], index);
                sourceIndex.Add(index, alphabet[index]);
                sourceUpper.Add(char.ToUpper(alphabet[index]), index);
            }

            int i = 0;
            StringBuilder tmp = new StringBuilder();
            while(i < s.Length)
            {
                if (!char.IsLetter(s[i]))
                    tmp.Append(s[i]);
                else
                {
                    int index = char.IsUpper(s[i]) ? sourceUpper[s[i]]: source[s[i]];
                    index = index + k;
                    if(index >= source.Count)
                    {
                        index = index - source.Count;
                        if(index >= source.Count)
                        {
                            index = index % source.Count;  // index - ( (index / source.Count) * source.Count);
                        }
                    }
                    tmp.Append( char.IsUpper(s[i]) ? char.ToUpper(sourceIndex[index]) : sourceIndex[index] );
                }
                i++;
            }

            return tmp.ToString();
        }
    }
}
