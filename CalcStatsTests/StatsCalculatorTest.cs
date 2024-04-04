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