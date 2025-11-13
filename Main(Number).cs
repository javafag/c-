namespace ConsoleApp1;

public class Main_Number
{
    public static void Main()
    {
        int[] arr1 = { 3, 8, 1, 6, 2, 9 };
        int[] arr2 = { 5, 10, 15, 20, 25 };
        int[] arr3 = { 7, 4, 9, 12, 1, 0 };
        int[] numbers4 = { 7, 4, 9, 12, 1, 0 };

      
        Console.WriteLine("=== Numbers1: IMinMax ===");
        Numbers1 n1 = new Numbers1(arr1);
        n1.ShowMinMax();

        Console.WriteLine("\n=== Numbers2: IOddEven ===");
        Numbers2 n2 = new Numbers2(arr2);
        n2.ShowOddEven();

        Console.WriteLine("\n=== Numbers3: IMinMax + IOddEven ===");
        Numbers3 n3 = new Numbers3(arr3);
        n3.ShowAll();
        
        Numbers4 n4 = new Numbers4(numbers4);

        Console.WriteLine("=== Numbers4: OddEven + IMinMax ===");
        n4.ShowAll();
        
    }
}


// Define an interface named IMinMax that will contain the following methods: void GetMin() to output the minimum value from an array of numbers, and void GetMax() to output the maximum value from an array of numbers.
//
//
//
//     Define a second interface named IOddEven, which will contain the following methods: void GetOdd() to output only odd numbers from an array of numbers, and void GetEven() to output only even numbers from an array of numbers.
//
//
//
// Implement the Numbers1 class, which implements the IMinMax interface, the Numbers2 class, which implements the IOddEven interface, and the Numbers3 class, which implements both interfaces. Each of these classes should have its own array of numbers initialized by a constructor.
//
//
//
//     Create a static method Main() in an additional class Numbers with examples of how to use the classes Numbers1, Numbers2, and Numbers3.