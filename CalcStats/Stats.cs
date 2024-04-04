namespace CalcStats;

public record Stats
{
    private readonly int _min;
    private readonly int _max;
    private readonly int _num;
    private readonly decimal _avg;

    public Stats(int min, int max, int num, decimal avg)
    {
        _min = min;
        _max = max;
        _num = num;
        _avg = avg;
    }
}