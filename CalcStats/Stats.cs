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

    public override string ToString()
    {
        return $"{nameof(_min)}: {_min}, {nameof(_max)}: {_max}, {nameof(_num)}: {_num}, {nameof(_avg)}: {_avg}";
    }
}