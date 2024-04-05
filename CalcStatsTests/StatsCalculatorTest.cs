using CalcStats;

namespace CalcStatsTests;

public class StatsCalculatorTest
{
    public StatsCalculatorTest()
    {
    }

    [Test]
    public void Throws_An_Exception_For_An_Empty_Sequence()
    {
        Assert.Throws<ArgumentException>(
            () => StatsCalculator.Calculate(Array.Empty<int>().ToList())
        );
    }

    [Test]
    [TestCase(0)]
    public void Computes_Stats_For_A_Sequence_Containing_One_Element(int value)
    {
        List<int> numbers = new() { value };

        var stats = StatsCalculator.Calculate(numbers);

        Assert.That(stats, Is.EqualTo(
            new Stats(
                min: value,
                max: value,
                num: 1,
                avg: value
            )));
    }
    
    [Test]
    [TestCase(0,0, 0)]
    [TestCase(1,0, 0.5)]
    public void Computes_Stats_For_A_Sequence_Containing_Two_Elements(int value1, int value2, decimal expectedAvg)
    {
        List<int> numbers = new() { value1, value2 };

        var stats = StatsCalculator.Calculate(numbers);

        Assert.That(stats, Is.EqualTo(
            new Stats(
                min: value2,
                max: value1,
                num: 2,
                avg: expectedAvg
            )));
    }
    
    [Test]
    public void Computes_Stats_For_A_Sequence_Containing_Three_Elements()
    {
        List<int> numbers = new() { 2, 2, 8 };

        var stats = StatsCalculator.Calculate(numbers);

        Assert.That(stats, Is.EqualTo(
            new Stats(
                min: 2,
                max: 8,
                num: 3,
                avg: 4
            )));
    }
}