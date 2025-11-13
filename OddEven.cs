namespace ConsoleApp1;

public abstract class OddEven : IMinMax
{
    protected int[] nums;

    public OddEven(int[] numbers)
    {
        nums = numbers;
    }

    public abstract void GetOdd();
    public abstract void GetEven();

    public abstract void GetMin(int[] numbers);
    public abstract void GetMax(int[] numbers);
}