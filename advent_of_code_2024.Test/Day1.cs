using advent_of_code_2024.day1;

namespace advent_of_code_2024_tests;

public class Day1Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void SortedChainBuilderTest1()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));
        // Act
        chainBuilder.Add(1);
        chainBuilder.Add(3);
        chainBuilder.Add(2);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[1], Is.EqualTo(2));
            Assert.That(result[2], Is.EqualTo(3));
        });

    }
    [Test]
    public void SortedChainBuilder_EmptyChainTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Empty);
            Assert.That(result, Is.Empty);
        });
    }

    [Test]
    public void SortedChainBuilder_SingleElementTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(5);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(1));
            Assert.That(result[0], Is.EqualTo(5));
        });
    }

    [Test]
    public void SortedChainBuilder_DuplicateElementsTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(2);
        chainBuilder.Add(2);
        chainBuilder.Add(2);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result[1], Is.EqualTo(2));
            Assert.That(result[2], Is.EqualTo(2));
        });
    }
    [Test]
    public void SortedChainBuilder_ReverseOrderInputTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(5);
        chainBuilder.Add(3);
        chainBuilder.Add(1);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[1], Is.EqualTo(3));
            Assert.That(result[2], Is.EqualTo(5));
        });
    }

    [Test]
    public void SortedChainBuilder_NegativeNumbersTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(-1);
        chainBuilder.Add(-3);
        chainBuilder.Add(-2);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(-3));
            Assert.That(result[1], Is.EqualTo(-2));
            Assert.That(result[2], Is.EqualTo(-1));
        });
    }
    [Test]
    public void SortedChainBuilder_MixedNumbersTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(0);
        chainBuilder.Add(-1);
        chainBuilder.Add(1);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(-1));
            Assert.That(result[1], Is.EqualTo(0));
            Assert.That(result[2], Is.EqualTo(1));
        });
    }
    [Test]
    public void SortedChainBuilder_LargeNumbersTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value1.CompareTo(value2)));

        // Act
        chainBuilder.Add(int.MaxValue);
        chainBuilder.Add(int.MinValue);
        chainBuilder.Add(0);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(int.MinValue));
            Assert.That(result[1], Is.EqualTo(0));
            Assert.That(result[2], Is.EqualTo(int.MaxValue));
        });
    }
    [Test]
    public void SortedChainBuilder_CustomComparatorDescendingTest()
    {
        // Arrange
        var chainBuilder = new Day1.SortedChainBuilder<int>(
            ((value1, value2) => value2.CompareTo(value1))); // Descending order

        // Act
        chainBuilder.Add(1);
        chainBuilder.Add(3);
        chainBuilder.Add(2);
        var result = chainBuilder.Build().ToArray();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Length.EqualTo(3));
            Assert.That(result[0], Is.EqualTo(3));
            Assert.That(result[1], Is.EqualTo(2));
            Assert.That(result[2], Is.EqualTo(1));
        });
    }
}
