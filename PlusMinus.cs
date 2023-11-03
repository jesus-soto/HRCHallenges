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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        // 1 1 0 -1 -1
        //-4 3 -9 0 4 1
        //1 -2 -7 9 1 -8 -5
        //var groups= arr.GroupBy(i => Math.Abs(i));
        ///var groups = arr.GroupBy(i => i > 0 ? "1" : i < 0 ? "2" : "3").OrderBy(g => g.Key);
        var categories = new List<string> {"1", "2", "3"};
        var result = categories.Select(categorie => new {
            categorie = categorie,
            count = arr.Count(num => 
                (categorie == "1" && num > 0) ||
                (categorie == "2" && num < 0) ||
                (categorie == "3" && num == 0)
                )
        });
        //var result = new List<double>();
        foreach(var item in result){
            //Console.WriteLine( "{0} {1}", item.Key, item.Count() );

            //result.Add((double)item.Count() / arr.Count());
            Console.WriteLine(((double)item.count / arr.Count()).ToString("F6"));
        } 
        
    }

}


