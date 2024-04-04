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
            max: numbers[0],
            num: numbers.Count,
            avg: numbers.AsQueryable().Sum()/(decimal)numbers.Count
        );
    }
}