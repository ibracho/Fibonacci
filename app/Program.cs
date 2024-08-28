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
}