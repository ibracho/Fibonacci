using System;

public class Fibonacci
{
    public static void Main()
    {
        int n = 10;

        Console.WriteLine("Fibonacci Sequence using loops:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciLoop(i) + " ");
        }

        Console.WriteLine("\nFibonacci Sequence using recursion:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciRecursion(i) + " ");
        }
    }

    public static int FibonacciLoop(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0;
        int b = 1;
        int result = 0;

        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }

    public static int FibonacciRecursion(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }
}