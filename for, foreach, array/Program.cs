int[] numbers = { 10, 20, 30, 40, 50 };
static int GetMax(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }

    }
    return max;
}
Console.WriteLine(GetMax(numbers));