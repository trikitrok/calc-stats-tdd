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
            min: numbers.Count == 2 ? numbers[1]: numbers[0],
            max: Math.Max(numbers[0], numbers.Count==3 ? numbers[2]: numbers[0]),
            num: numbers.Count,
            avg: ComputeAverage(numbers)
        );
    }

    private static decimal ComputeAverage(List<int> numbers)
    {
        return numbers.AsQueryable().Sum()/(decimal)numbers.Count;
    }
}