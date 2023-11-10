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

class ResultTimeConversion
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        
        try
        {
            var result = DateTime.ParseExact(s,"hh:mm:sstt",CultureInfo.InvariantCulture).ToString("HH:mm:ss");
            DateTime hour = new DateTime();
            DateTime.TryParseExact(s, "hh:mm:sstt",CultureInfo.InvariantCulture, DateTimeStyles.None, out hour);//result = DateTime.
            //var result = hour.ParseExact(s,"HH:mm:ss",CultureInfo.InvariantCulture);
            return hour.ToString("HH:mm:ss");
        }
        catch (System.Exception e)
        {            
            return e.Message;// DateTime.ParseExact(DateTime.Now.ToString(),"HH:mm:ss",CultureInfo.InvariantCulture).ToString();
        }
        
    }

}

class TimeConversion
{
    public static void timeConversion(string s)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();

        string result = ResultTimeConversion.timeConversion(s);
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
