namespace advent_of_code_2024.Day3;

public class Day3 : ISolution<int>
{
    public required string InputFile { get; set; }
    public virtual int Solve()
    {
        var fileContent = File.ReadAllText(InputFile);
        var mult = fileContent.Split("mul(");
        var result = 0;
        foreach (var mul in mult)
        {
            var args = mul.Split(")")[0];
            var nums = args.Split(",");
            if(nums.Length > 2) continue;
            if(int.TryParse(nums[0], out var first) && int.TryParse(nums[1], out var second))
            {
                result += first * second;
            }
        }

        return result;
    }
}