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
    public void Computes_Stats_For_A_Sequence_Containing_One_Element()
    {
        List<int> numbers = new() { 0 };

        var stats = StatsCalculator.Calculate(numbers);

        Assert.That(stats, Is.EqualTo(
            new Stats(
                min: 0,
                max: 0,
                num: 1,
                avg: 0
            )));
    }
    
    [Test]
    public void Computes_Stats_For_A_Sequence_Containing_Two_Elements()
    {
        List<int> numbers = new() { 0, 0 };

        var stats = StatsCalculator.Calculate(numbers);

        Assert.That(stats, Is.EqualTo(
            new Stats(
                min: 0,
                max: 0,
                num: 2,
                avg: 0
            )));
    }
}