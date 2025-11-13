

using System;

namespace  ConsoleApp1
{
    public class Numbers4 : OddEven
    {
        public Numbers4(int[] numbers) : base(numbers) { }

        public override void GetOdd()
        {
            Console.Write("Odd numbers: ");
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                    Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public override void GetEven()
        {
            Console.Write("Even numbers: ");
            foreach (var n in nums)
            {
                if (n % 2 == 0)
                    Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public override void GetMin(int[] numbers)
        {
            if (numbers.Length == 0) return;
            int min = numbers[0];
            foreach (var n in numbers)
                if (n < min) min = n;
            Console.WriteLine("Minimum value: " + min);
        }

        public override void GetMax(int[] numbers)
        {
            if (numbers.Length == 0) return;
            int max = numbers[0];
            foreach (var n in numbers)
                if (n > max) max = n;
            Console.WriteLine("Maximum value: " + max);
        }

        public void ShowAll()
        {
            GetMin(nums);
            GetMax(nums);
            GetOdd();
            GetEven();
        }
    }
}
