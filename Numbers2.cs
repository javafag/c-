using System.Collections;

namespace ConsoleApp1;

public class Numbers2 : IOddEven
{
    

    private int[] nums;

    public Numbers2(int[] nums)
    {
        this.nums = nums;
    }
    
    List<int> odds = [];
    List<int> evens = [];

    public void GetOdd(int[] numbers)
    {
        Console.Write("Odd numbers: ");
        foreach (var n in numbers)
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

    public void ShowOddEven()
    {
        GetOdd(nums);
        GetEven(nums);
    }
}

// Define a second interface named IOddEven, which will contain the following methods: void GetOdd()
// to output only odd numbers from an array of numbers, and void GetEven() to output only even numbers from an array of numbers.