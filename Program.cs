using System.Security.Cryptography.X509Certificates;

class Challenge
{
    public static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        //Result.plusMinus(arr);
        
        //---------
        //Solution.MainSolution();
        //---------
        string s = Console.ReadLine();
        //TimeConversion.timeConversion(s);
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        //Median(arr);
        lonelyinteger(arr);

    }

    private static void Median(List<int> arr)
    {
        int Result = arr.Sum() / arr.Count();
        Console.WriteLine(Result);
        arr.Sort();
        arr.ForEach((x) => Console.Write(x + " "));
    }

    public static int lonelyinteger(List<int> a)
    {
        if(a.Count == 0) return 0;
        var elements = a.GroupBy(x => x).Select(grp => new { key = grp.Key, cnt = grp.Count()});
        var Result = elements.Where(x => x.cnt == 1).First();
        return Result.key;
    }
    
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int tamano = matrix.Count();
        int media = tamano / 2;
        int n = tamano - 1;
        int result = 0;
        for(int i = 0; i < media; i++)
            for(int j = 0; j < media; j++){
                List<int> temp = new List<int>();
                temp.Add(matrix[i][j]);
                temp.Add(matrix[i][n - j]);
                temp.Add(matrix[n - i][j]);
                temp.Add(matrix[n - i][n - j]);
                result += temp.Max();
            }
        return result;
    }

}