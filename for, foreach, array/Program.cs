string[] products = { "Keyboard", "Mouse", "Monitor", "Headphones", "Webcam" };
int[] prices = { 80, 40, 350, 120, 60 };


static int GetTotal(int[] prices)
{
    int total = 0;
    for (int i = 0; i < prices.Length; i++)
    {
        total += prices[i];
    }

    return total;
}

int total = GetTotal(prices);
Console.WriteLine(total);

