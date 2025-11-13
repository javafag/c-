namespace ConsoleApp1;


public class Numbers3 : IMinMax
{
    private int[] nums;

    public Numbers3(int[] numbers)
    {
        nums = numbers;
    }

    public void GetMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (int n in numbers)
        {
            if (n < min)
                min = n;
        }
        Console.WriteLine("Minimum value: " + min);
    }

    public void GetMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
                max = n;
        }
        Console.WriteLine("Maximum value: " + max);
    }

    public void GetOdd(int[] numbers)
    {
        Console.Write("Odd numbers: ");
        foreach (int n in numbers)
        {
            if (n % 2 != 0)
                Console.Write(n + " ");
        }
        Console.WriteLine();
    }

    public void GetEven(int[] numbers)
    {
        Console.Write("Even numbers: ");
        foreach (int n in numbers)
        {
            if (n % 2 == 0)
                Console.Write(n + " ");
        }
        Console.WriteLine();
    }

    // Helper to show everything
    public void ShowAll()
    {
        GetMin(nums);
        GetMax(nums);
        GetOdd(nums);
        GetEven(nums);
    }
}
