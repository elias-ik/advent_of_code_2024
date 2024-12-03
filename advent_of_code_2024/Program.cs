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

var d2 = new Day2()
{
    InputFile = "./Day2/input.txt"
};
var d2Solution = d2.Solve();
Console.WriteLine($"Day 2 solution: {d2Solution}");


