using AlgorithmosApp.Searching;
using AlgorithmosApp.SolvingProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BinarySearch
            //BinarySearch binarySearch = new BinarySearch();
            //int index = binarySearch.Sort(new List<int> { 10, 20, 30, 50, 60, 70, 80, 90, 100 }, 1000);
            //Console.WriteLine(index);
            #endregion

            #region StringMatch
            //StringMatch stringMatch = new StringMatch();
            //var result =  stringMatch.Solve("tzchchachavchava", "chava");
            //result = stringMatch.Solve("tzchchachavchava", "chavaz");
            #endregion

            #region Interjection
            //Intersection intersection = new Intersection();
            //intersection.Solve(new int[] { 1, 2, 2,3, 3, 8, 10, 11 }, new int[] { 3, 4,5,5,6,8,10,10 });
            #endregion

            #region SuperReducedString
            //SuperReducedString superReducedString = new SuperReducedString();
            //string result = superReducedString.Solve("acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj");
            //result = superReducedString.Solve("aa");
            //result = superReducedString.Solve("baab");
            #endregion

            #region CamelCase
            //var result = new CamelCase().Solve("saveChangesInTheEditor");
            #endregion

            #region StrongPassworkd
            //var strongPass = new StrongPassword();
            //var result = strongPass.Solve(3, "Ab1");
            #endregion

            #region TwoCharacters
            //var twoCharacters = new TwoCharacters();
            //twoCharacters.Solve("asvkugfiugsalddlasguifgukvsa");
            #endregion

            #region CaesarCipher
            CaesarCipher caesarCipher = new CaesarCipher();
            caesarCipher.caesarCipher(@"DNFjxo?b5h*5<LWbgs6?V5{3M].1hG)pv1VWq4(!][DZ3G)riSJ.CmUj9]7Gzl?VyeJ2dIPEW4GYW*scT8(vhu9wCr]q!7eyaoy.
", 45);
            #endregion
        }
    }
}
