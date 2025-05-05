static int SumOfDigit(int x)
{
    int sum = 0;
    while (x > 0)
    {
        int digit = x % 10;
        sum += digit;
        x /= 10;
    }
    return sum;
}

Console.WriteLine(SumOfDigit(1234));
Console.WriteLine(SumOfDigit(57394857));
Console.WriteLine(SumOfDigit(126454));

