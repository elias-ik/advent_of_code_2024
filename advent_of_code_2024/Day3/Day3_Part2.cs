namespace advent_of_code_2024.Day3;

public class Day3_Part2 : Day3
{
    public override int Solve()
    {
        var fileContent = File.ReadAllText(InputFile);
        var enable = true;
        var result = 0;
        for (var i = 0; i < fileContent.Length; i++)
        {
            if(fileContent.Length > i + 4 && fileContent.Substring(i, 4) == "do()")
            {
                enable = true;
            } else if (fileContent.Length > i + 7 && fileContent.Substring(i, 7) == "don't()")
            {
                enable = false;
            } else if(enable && fileContent.Substring(i).StartsWith("mul(")) {
                var args = fileContent.Substring(i + 4).Split(")")[0];
                var nums = args.Split(",");
                if(nums.Length > 2) continue;
                if (int.TryParse(nums[0], out var first) && int.TryParse(nums[1], out var second))
                {
                    result += first * second;
                }
            }

        }
        return result;
    }
}
