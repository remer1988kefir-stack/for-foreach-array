string[] products = { "Keyboard", "Mouse", "Monitor", "Headphones", "Webcam" };
int[] prices = { 80, 40, 350, 120, 60 };


for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine($"{products[i]} - {prices[i]}");
}

static bool IsExpensive(int price)
{
    return price > 100;
}
for (int i = 0; i < products.Length; i++)
{
    if (IsExpensive(prices[i]))
    {
        Console.WriteLine($"{products[i]} - {prices[i]}");
    }
}
static int GetMax(int[] prices)
{
        int max = prices[0];

    foreach (int price in prices)
    {
        if (price > max)
        {
            max = price;
        }
    }
    return max;
}
static int GetAverage(int[] prices)
{
    int average = 0;
    int sum = 0;
    for (int i = 0; i < prices.Length; i++)
    {
        sum += prices[i];
    }
    average = sum / prices.Length;
    return average;
}
static int GetTotal(int[] prices)
{
    int total = 0;
    for (int i = 0;i < prices.Length;i++)
    {
        total += prices[i];
    }
    return total;
}


int max = GetMax(prices);
int average = GetAverage(prices);
int total = GetTotal(prices);

for (int i = 0;i < prices.Length;i++)
{
    if (prices[i] == max)
    {
        Console.WriteLine($"{products[i]} - {max}");
    }
}
Console.WriteLine($"Среднее значение: {average}");
Console.WriteLine($"Сумма: {total}");

