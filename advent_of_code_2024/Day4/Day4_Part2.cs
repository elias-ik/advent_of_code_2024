using System.Text;

namespace advent_of_code_2024.Day4;

public class Day4_Part2 : Day4
{
    public override int Solve()
    {
        var matrix = File.ReadAllLines(InputFile).Select(l => l.ToCharArray()).ToArray();
        return GetMasOccurences(matrix);
    }

    public int GetMasOccurences(char[][] matrix)
    {
        var result = 0;
        for(var x = 0; x < matrix.Length; x++)
        {
            for(var y = 0; y < matrix[x].Length; y++)
            {
                if(matrix[x][y] != 'A') continue;
                result += HasString(matrix, (x, y));
            }
        }
        return result;
    }
    public int HasString(char[][] data, (int, int) start)
    {
        const string targetString = "MAS";
        var x = start.Item1;
        var y = start.Item2;
        var result = 0;
        try
        {
            var s3 = new string([data[x-1][y-1],data[x][y],data[x+1][y+1]]);
            var s4 = new string([data[x-1][y+1],data[x][y],data[x+1][y-1]]);
            if ((s3.Equals(targetString) || Reverse(s3).Equals(targetString))
                && (s4.Equals(targetString) || Reverse(s4).Equals(targetString)))
            {
                result ++;
            }
        }catch{}
        return result;

    }
    public static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}