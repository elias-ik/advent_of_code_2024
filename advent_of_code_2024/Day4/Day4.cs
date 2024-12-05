using System.Text;

namespace advent_of_code_2024.Day4;

public class Day4 : ISolution<int>
{
    public required string InputFile { get; set; }

    public virtual int Solve()
    {
        var matrix = File.ReadAllLines(InputFile).Select(l => l.ToCharArray()).ToArray();
        var result = 0;
        for(var x = 0; x < matrix[0].Length; x++)
        {
            for(var y = 0; y < matrix.Length; y++)
            {
                if(matrix[y][x] == 'X')
                {
                    if(CountString(matrix, (x, y), (1, 0))) result++;
                    if(CountString(matrix, (x, y), (0, 1))) result++;
                    if(CountString(matrix, (x, y), (-1, 0))) result++;
                    if(CountString(matrix, (x, y), (0, -1))) result++;
                    if(CountString(matrix, (x, y), (1, 1))) result++;
                    if(CountString(matrix, (x, y), (-1, -1))) result++;
                    if(CountString(matrix, (x, y), (1, -1))) result++;
                    if(CountString(matrix, (x, y), (-1, 1))) result++;
                }
            }
        }
        return result;
    }

    public bool CountString(char[][] data, (int, int) start, (int, int) direction)
    {
        var stringBuilder = new StringBuilder();
        var targetString = "XMAS";
        for(var i = 0; i < targetString.Length; i++)
        {
            var x = start.Item1 + i * direction.Item1;
            var y = start.Item2 + i * direction.Item2;
            if(x < 0 || x >= data[0].Length || y < 0 || y >= data.Length)
            {
                return false;
            }
            stringBuilder.Append(data[y][x]);
        }
        return stringBuilder.ToString() == targetString;
    }
}