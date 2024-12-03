namespace advent_of_code_2024.Day2;

public class Day2 : ISolution<int>
{
    public required string InputFile { get; set; }
    public int Solve()
    {
        using var fs = new FileStream(InputFile, FileMode.Open);
        using var sr = new StreamReader(fs);
        var safeReports = 0;
        while(sr.ReadLine() is {} report)
        {
            var levels = report
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (IsSafe(levels))
                safeReports++;
        }
        return safeReports;
    }

    public bool IsSafe(int[] levels)
    {
        if (levels.Length == 1)
        {
            return true;
        }
        Direction? direction = null;
        var safe = true;
        for (var i = 1; i < levels.Length; i++)
        {
            var diff = levels[i] - levels[i-1];
            var currentDirection = diff > 0 ? Direction.Up : Direction.Down;
            if(direction is null)
            {
                direction = currentDirection;
            }
            else if(currentDirection != direction)
            {
                safe = false;
                break;
            }
            diff = Math.Abs(diff);
            if(diff > 3 || diff < 1)
            {
                safe = false;
                break;
            }
        }
        return safe;
    }

    private enum Direction
    {
        Up, Down
    }
}