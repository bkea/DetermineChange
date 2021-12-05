// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public static class Solution
{
    private static int _m = 0;
    private static bool columnFound = false;

    public static int findLargest()
    {
        int result = 0;
        foreach (string line in System.IO.File.ReadLines(@"c:\temp\test.csv"))
        {
            result = solution(line, "area");

        }
        return result;
    }
    private static int solution(string S, string C)
    {
        int n = 0;
        int i = 0;

        string[] rowcolumns = S.Split(',');
        if (columnFound)
        {
            if (int.TryParse(rowcolumns[_m], out int j))
            {
                n = j > n ? j : n;
            }
        }
        else
        {
            foreach (var col in rowcolumns)
            {
                if (col == C)
                {
                    _m = i;
                    columnFound = true;
                    continue;
                }
                else
                {
                    i++;
                }
            }
        }
       
        return n;
    }
}
