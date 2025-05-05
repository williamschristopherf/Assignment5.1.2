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

Console.WriteLine($"The sum of the digits of the number 1234 is {SumOfDigit(1234)}");
Console.WriteLine($"The sum of the digits of the number 57394857 is {SumOfDigit(57394857)}");
Console.WriteLine($"The sum of the digits of the number 126454 is {SumOfDigit(126454)}");

