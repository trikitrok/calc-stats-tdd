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
            min: numbers.Min(),
            max: numbers.Max(),
            num: numbers.Count,
            avg: ComputeAverage(numbers)
        );
    }

    private static decimal ComputeAverage(List<int> numbers)
    {
        return numbers.AsQueryable().Sum()/(decimal)numbers.Count;
    }
}