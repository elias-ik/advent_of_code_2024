using advent_of_code_2024.Day2;

namespace advent_of_code_2024_tests;

public class Day2Tests
{

    [Test]
    public void LevelCheckTest1() => TestLevel([7, 6, 4, 2, 1], true);
    [Test]
    public void LevelCheckTest2() => TestLevel([1, 2, 7, 8, 9], false);
    [Test]
    public void LevelCheckTest3() => TestLevel([9, 7, 6, 2, 1], false);
    [Test]
    public void LevelCheckTest4() => TestLevel([1, 3, 2, 4, 5], false);
    [Test]
    public void LevelCheckTest5() => TestLevel([8, 6, 4, 4, 1], false);
    [Test]
    public void LevelCheckTest6() => TestLevel([1, 3, 6, 7, 9], true);


    [Test]
    public void LevelCheckTest1_WithDamper() => TestLevelWithDamper([7, 6, 4, 2, 1], true);
    [Test]
    public void LevelCheckTest2_WithDamper() => TestLevelWithDamper([1, 2, 7, 8, 9], false);
    [Test]
    public void LevelCheckTest3_WithDamper() => TestLevelWithDamper([9, 7, 6, 2, 1], false);
    [Test]
    public void LevelCheckTest4_WithDamper() => TestLevelWithDamper([1, 3, 2, 4, 5], true);
    [Test]
    public void LevelCheckTest5_WithDamper() => TestLevelWithDamper([8, 6, 4, 4, 1], true);
    [Test]
    public void LevelCheckTest6_WithDamper() => TestLevelWithDamper([1, 3, 6, 7, 9], true);


    private static void TestLevel(int[] levels, bool expected)
    {
        // Arrange
        var d2 = new Day2(){InputFile = "test.txt"};

        // Act
        var isSafe = d2.IsSafe(levels, false);

        // Assert
        Assert.That(isSafe, Is.EqualTo(expected));
    }
    private static void TestLevelWithDamper(List<int> levels, bool expected)
    {
        // Arrange
        var d2 = new Day2(){InputFile = "test.txt"};

        // Act
        var isSafe = d2.IsSafe(levels.ToArray(), true);


        // Assert
        Assert.That(isSafe, Is.EqualTo(expected));
    }



}