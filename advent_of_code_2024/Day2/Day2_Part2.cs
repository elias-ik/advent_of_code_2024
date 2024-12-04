namespace advent_of_code_2024.Day2;

public class Day2_Part2 : Day2
{
    public override int Solve()
    {
        using var fs = new FileStream(InputFile, FileMode.Open);
        using var sr = new StreamReader(fs);
        var safeReports = 0;
        while(sr.ReadLine() is {} report)
        {
            var levels = report
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var save = IsSafe(levels.ToArray(), true);
            if (save)
                safeReports++;
        }
        return safeReports;    }
}