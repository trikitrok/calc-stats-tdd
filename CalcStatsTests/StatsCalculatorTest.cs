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
    public void Computes_Stats_For_A_Sequence_Containing_Two_Elements(int value1, int value2, int expectedAvg)
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
}