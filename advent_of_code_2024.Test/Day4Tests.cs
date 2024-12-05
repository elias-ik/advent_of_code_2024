using advent_of_code_2024.Day4;

namespace advent_of_code_2024_tests;

public class Day4Tests
{
    [Test]
    public void Test1()
    {
        // Arrange
        char[][] data =
        [
            ['M', 'M', 'M'],
            ['M', 'A', 'S'],
            ['S', 'S', 'S'],
        ];
        var d4 = new Day4_Part2(){InputFile = "test.txt"};

        // Act
        var result = d4.HasString(data, (1, 1));

        // Assert
        Assert.That(result, Is.EqualTo(2));

    }
    [Test]
    public void Test2()
    {
        // Arrange
        char[][] data =
        [
            ['M', 'M', 'M', 'M'],
            ['M', 'A', 'A', 'S'],
            ['S', 'S', 'S', 'S'],
        ];
        var d4 = new Day4_Part2(){InputFile = "test.txt"};

        // Act
        var result = d4.GetMasOccurences(data);

        // Assert
        Assert.That(result, Is.EqualTo(2));

    }
    [Test]
    public void Test3()
    {
        // Arrange
        char[][] data =
        [
            ['M', 'M', 'M', 'M'],
            ['M', 'A', 'A', 'S'],
            ['S', 'S', 'S', 'S'],
        ];
        var d4 = new Day4_Part2(){InputFile = "test.txt"};
        // Act
        var result = d4.GetMasOccurences(data);
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void Test4()
    {
        // Arrange
        string input = """
                       .M.S......
                       ..A..MSMS.
                       .M.S.MAA..
                       ..A.ASMSM.
                       .M.S.M....
                       ..........
                       S.S.S.S.S.
                       .A.A.A.A..
                       M.M.M.M.M.
                       ..........
                       """;
        char[][] data = input.Split(Environment.NewLine).Select(l => l.ToCharArray()).ToArray();
        var d4 = new Day4_Part2(){InputFile = "test.txt"};
        // Act
        var result = d4.GetMasOccurences(data);
        // Assert
        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void Test5() => RunTest("""
                                      MMS
                                      .A.
                                      MSS
                                   """, 1);
    [Test]
    public void Test6() => RunTest("""
                                      MAS
                                      .A.
                                      MSS
                                   """, 1);
    [Test]
    public void Test7() => RunTest("""
                                      MAS
                                      .A.
                                      MSS
                                   """, 1);


    public void RunTest(string input, int expected)
    {
        char[][] data = input
            .Split(Environment.NewLine)
            .Select(l =>
                l.ToCharArray()
                    .Where(c =>
                        !char.IsWhiteSpace(c)).ToArray()
                ).ToArray();
        var d4 = new Day4_Part2(){InputFile = "test.txt"};
        var result = d4.GetMasOccurences(data);
        Assert.That(result, Is.EqualTo(expected));
    }

}