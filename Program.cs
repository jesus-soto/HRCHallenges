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
        // string s = Console.ReadLine();
        // //TimeConversion.timeConversion(s);
        // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        // //Median(arr);
        // lonelyinteger(arr);
        MaincountingSort();

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

    public static void MainFlippingMatrix(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
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

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftDiagonal = 0;
        int rightDiagonal = 0;
        int tamano = arr.Count;
        int mitad = tamano / 2;
        int renglon = 0;
        int sumRight = 0, sumLeft = 0, iRight = 0;
        int iLeft = tamano - 1;
        arr.ForEach( m => {
            sumRight += m[iRight];
            sumLeft += m[iLeft];
            iRight++;
            iLeft--;
            renglon++;
        } );
        return Math.Abs(sumRight-sumLeft);
    }

    public static void MaincountingSort()
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter(@"Temp.txt", true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }

    public static List<int> countingSort(List<int> arr)
    {
        List<int> result = new List<int>();
        var values = new List<int>();
        for(int i=0; i<100;i++)
            values.Add(i);
        var elements = arr.GroupBy(x => x).Select(grp => new { key = grp.Key, cnt = grp.Count()});
        //elements.Sort(x => x.key);
        var results = values.Select( x => new {
            value = x,
            cnt = elements.Where(num => num.key == x).Select(w => w.key == x ? w.cnt : 0).FirstOrDefault()
        });
        foreach(var element in results){
           Console.Write(element.cnt); 
           result.Add(element.cnt);
        };
        return result;
    }

}