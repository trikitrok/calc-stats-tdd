using CalcStats;

namespace CalcStatsTests;

public class StatsCalculatorTest
{
    [Test]
    public void Throws_An_Exception_For_An_Empty_Sequence()
    {
        Assert.Throws<ArgumentException>(
            () => StatsCalculator.Calculate(Array.Empty<int>().ToList())
        );
    }
}