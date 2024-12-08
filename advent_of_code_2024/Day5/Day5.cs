namespace advent_of_code_2024.Day5;

public class Day5 : ASolution<int>
{
    public override int Solve()
    {
        Dictionary<int,List<int>> rules = new();
        List<int[]> pages = new();
        using var fs = new FileStream(InputFile, FileMode.Open, FileAccess.Read);
        using var sr = new StreamReader(fs);
        var isUpdates = false;
        var result = 0;
        while (sr.ReadLine() is { } line)
        {
            if (!isUpdates)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    isUpdates = true;
                } else
                {
                    var parts = line
                        .Split('|')
                        .Select(int.Parse)
                        .ToArray();
                    var key = parts[0];
                    var value = parts[1];
                    if (!rules.ContainsKey(key))
                    {
                        rules[key] = new List<int>();
                    }
                    rules[key].Add(value);
                }
            }
            else
            {
                pages.Add(line.Split(',').Select(int.Parse).ToArray());
            }
        }

        foreach(var page in pages)
        {
            var valid = true;
            for(var i = 0; i < page.Length - 1; i++)
            {
                for(var j = i + 1; j < page.Length; j++)
                {
                    if (rules.TryGetValue(page[j], out var values) && values.Contains(page[i]))
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
            {
                result += page[page.Length / 2];
            }
        }
        return result;
    }


}