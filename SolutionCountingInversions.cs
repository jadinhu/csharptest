using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// https://www.hackerrank.com/challenges/ctci-merge-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
class SolutionCountingInversions
{

    /*
     * Complete the 'countInversions' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static long countInversions(List<int> arr)
    {
        int swapsPerLoop, totalSwaps = 0;

        do
        {
            // reset swaps per loop counter
            swapsPerLoop = 0;
            // run almost full array (count - 1)
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                // if must be swapped
                if (arr[i] > arr[i + 1])
                {
                    // swap
                    int aux = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = aux;
                    swapsPerLoop++;
                }
            }
            totalSwaps += swapsPerLoop;
        } while (swapsPerLoop > 0);

        return totalSwaps;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        for (int tItr = 0; tItr < 2; tItr++)
        {
            // read like 2 1 3 1 2
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            long result = SolutionCountingInversions.countInversions(arr);

            Console.WriteLine(result);
        }
    }
}
