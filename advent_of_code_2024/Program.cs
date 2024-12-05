// See https://aka.ms/new-console-template for more information

using advent_of_code_2024.day1;
using advent_of_code_2024.Day2;
using advent_of_code_2024.Day3;
using advent_of_code_2024.Day4;

Console.WriteLine("Merry Christmas! HOHOHOHO!");

var d1 = new Day1()
{
    InputFile = "./Day1/input.txt"
};
var d1Solution = d1.Solve();
Console.WriteLine($"Day 1 solution: {d1Solution}");

var d1Part2 = new Day1_Part2()
{
    InputFile = "./Day1/input.txt"
};
var d1Part2Solution = d1Part2.Solve();
Console.WriteLine($"Day 1 Part 2 solution: {d1Part2Solution}");

var d2 = new Day2()
{
    InputFile = "./Day2/input.txt"
};
var d2Solution = d2.Solve();
Console.WriteLine($"Day 2 solution: {d2Solution}");

var d2Part2 = new Day2_Part2()
{
    InputFile = "./Day2/input.txt"
};
var d2Part2Solution = d2Part2.Solve();
Console.WriteLine($"Day 2 Part 2 solution: {d2Part2Solution}");

var d3 = new Day3()
{
    InputFile = "./Day3/input.txt"
};
var d3Solution = d3.Solve();
Console.WriteLine($"Day 3 solution: {d3Solution}");

var d3Part2 = new Day3_Part2()
{
    InputFile = "./Day3/input.txt"
};
var d3Part2Solution = d3Part2.Solve();
Console.WriteLine($"Day 3 Part 2 solution: {d3Part2Solution}");

var d4 = new Day4()
{
    InputFile = "./Day4/input.txt"
};
var d4Solution = d4.Solve();
Console.WriteLine($"Day 4 solution: {d4Solution}");

var d4Part2 = new Day4_Part2()
{
    InputFile = "./Day4/input.txt"
};
var d4Part2Solution = d4Part2.Solve();
Console.WriteLine($"Day 4 Part 2 solution: {d4Part2Solution}");
