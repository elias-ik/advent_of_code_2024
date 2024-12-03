namespace advent_of_code_2024.day1;

public class Day1_Part2 : Day1
{
    public override int Solve()
    {
        base.Solve();
        var result = 0;
        Dictionary<int, int> leftMap = new();
        foreach (var i in ScbLeft.Build())
        {
            leftMap[i] = 0;
        }
        foreach (var i in ScbRight.Build())
        {
            if (leftMap.TryGetValue(i, out var value))
            {
                leftMap[i] = ++value;
            }
        }
        foreach (var (key, value) in leftMap)
        {
            if (value != 0)
            {
                result += key * value;
            }
        }
        return result;
    }
}