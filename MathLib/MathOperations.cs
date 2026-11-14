namespace MathLib;

public static class MathOperations
{
    public static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Факторіал від'ємного числа не існує");
        if (n > 20)
            throw new ArgumentOutOfRangeException(nameof(n), "Для n > 20 результат не вміщується в long");

        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }
}