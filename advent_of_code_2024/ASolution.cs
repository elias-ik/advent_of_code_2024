namespace advent_of_code_2024;

public abstract class ASolution<T>
{
    public required string InputFile { get; set; }

    public abstract T Solve();

}