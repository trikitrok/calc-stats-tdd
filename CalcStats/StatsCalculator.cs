namespace CalcStats;

public class StatsCalculator
{
    public static Stats Calculate(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException();
        }
        return new Stats(
            min: 0,
            max: 0,
            num: 1,
            avg: 0
        );
    }
}