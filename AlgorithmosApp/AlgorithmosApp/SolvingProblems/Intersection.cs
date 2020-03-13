using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmosApp.SolvingProblems
{
    public class Intersection
    {        
        public int[] Solve(int[] arrA, int[] arrB)
        {
            int i = 0;
            int j = 0;
            int length = arrA.Length > arrB.Length ? arrB.Length : arrA.Length;
            int[] arrayResult = new int[length];
            int iResult = 0;
            int counter = 0;
            while (counter < length)
            {
                if(arrA[i] == arrB[j])
                {
                    arrayResult[iResult] = arrA[i];
                    iResult++;
                    i++;
                    j++;
                }
                else
                {
                    if (arrA[i] > arrB[j]) j++; else i++;
                }
                counter = i > j ? i : j;
            }
            return arrayResult;
        }
    }
}
