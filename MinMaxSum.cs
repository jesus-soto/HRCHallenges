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

class Results
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        //int max = arr.Max();
        //int min = arr.Min();
        long result1 = arr.Sum() - arr.Max();
        long result2 = arr.Sum() - arr.Min();
        Console.WriteLine("{0} {1}", result1, result2);
    }

}

class MiniMaxSum
{
    public static void MainSolution()
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Results.miniMaxSum(arr);
    }
}
