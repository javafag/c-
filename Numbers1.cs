// See https://aka.ms/new-console-template for more information


// Define an interface named IMinMax that will contain the following methods: void GetMin() to output the minimum value from an array of numbers, and void GetMax() to output the maximum value from an array of numbers.
//
//
//
//     Define a second interface named IOddEven, which will contain the following methods: void GetOdd() to output only odd numbers from an array of numbers, and void GetEven() to output only even numbers from an array of numbers.
//
//
//
//     Implement the Numbers1 class, which implements the IMinMax interface, the Numbers2 class, which implements the IOddEven interface, and the Numbers3 class, which implements both interfaces. Each of these classes should have its own array of numbers initialized by a constructor.
//
//
//
//     Create a static method Main() in an additional class Numbers with examples of how to use the classes Numbers1, Numbers2, and Numbers3.

using System;
using ConsoleApp1;

public class Numbers1 : IMinMax
{
    private int[] nums;

    public Numbers1(int[] numbers)
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

    
    public void ShowMinMax()
    {
        GetMin(nums);
        GetMax(nums);
    }
}
