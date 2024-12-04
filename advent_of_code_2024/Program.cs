// See https://aka.ms/new-console-template for more information

using advent_of_code_2024.day1;
using advent_of_code_2024.Day2;

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


