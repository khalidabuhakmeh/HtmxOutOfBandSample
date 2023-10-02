namespace HtmxOutOfBandSample.Models;

public class CounterModel
{
    public bool ShowCart { get; }

    public CounterModel(Count count, bool showCart = false)
    {
        ShowCart = showCart;
        Value = count.Value;
    }

    public int Value { get; }
}