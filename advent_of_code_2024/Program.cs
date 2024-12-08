// See https://aka.ms/new-console-template for more information

using advent_of_code_2024;using advent_of_code_2024.day1;
using advent_of_code_2024.Day2;
using advent_of_code_2024.Day3;
using advent_of_code_2024.Day4;
using advent_of_code_2024.Day5;

Console.WriteLine("Merry Christmas! HOHOHOHO!");

Solver.Solve(typeof(Day1), "./Day1/input.txt", "Day 1");
Solver.Solve(typeof(Day1_Part2), "./Day1/input.txt", "Day 1 Part2");

Solver.Solve(typeof(Day2), "./Day2/input.txt", "Day 2");
Solver.Solve(typeof(Day2_Part2), "./Day2/input.txt", "Day 2 Part2");

Solver.Solve(typeof(Day3), "./Day3/input.txt", "Day 3");
Solver.Solve(typeof(Day3_Part2), "./Day3/input.txt", "Day 3 Part2");

Solver.Solve(typeof(Day4), "./Day4/input.txt", "Day 4");
Solver.Solve(typeof(Day4_Part2), "./Day4/input.txt", "Day 4 Part2");

Solver.Solve(typeof(Day5), "./Day5/input.txt", "Day 5");
Solver.Solve(typeof(Day5_Part2), "./Day5/input.txt", "Day 5 Part2");
