string[] numbers = { "10", "25", "3", "100", "7" };
foreach (string number in numbers)
{
    Console.WriteLine(number);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

static int Double(int number)
{

    return number * 2;
}

int result = Double(3);
