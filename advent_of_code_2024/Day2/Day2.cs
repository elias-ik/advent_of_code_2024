namespace advent_of_code_2024.Day2;

public class Day2 : ISolution<int>
{
    public required string InputFile { get; set; }
    public virtual int Solve()
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
            if (IsSafe(levels, false))
                safeReports++;
        }
        return safeReports;
    }

    private bool IsSaveRaw(int[] levels)
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
    public bool IsSafe(int[] levels, bool dampening)
    {
        var result = IsSaveRaw(levels);
        if (!result && dampening)
        {
            for(var i = 0; i <= levels.Length; i++)
            {
                var newLevels = levels
                    .Where((value, index) => index != i)
                    .ToArray();
                if (IsSaveRaw(newLevels))
                {
                    result = true;
                    break;
                }
            }
        }
        return result;
    }

    private enum Direction
    {
        Up, Down
    }
}