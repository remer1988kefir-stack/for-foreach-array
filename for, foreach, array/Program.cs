int[] scores = { 45, 78, 92, 61, 35, 88, 100, 54 };
static int GetMax(int[] scores)
{
    int max = scores[0];
    foreach (int score in scores)
        if (score > max)
        {  max = score; }
    return max;
}

static int GetAverage(int[] scores)
{
    int average = 0;
    int sum = 0;
    for (int i = 0; i < scores.Length; i++)
    {
        sum += scores[i];
    }
    average = sum / scores.Length;
    return average;
}
static void PrintExcellentScores(int[] scores)
{
    foreach (int score in scores)
    {
        if (score >= 90)
        {
            Console.WriteLine(score);
        }
    }
}


int max = GetMax(scores);
int average = GetAverage(scores);

Console.WriteLine($"Максимальная оценка {max}");
Console.WriteLine($"Средняя оценка {average}");
Console.WriteLine("Отличные оценки: ");
PrintExcellentScores(scores);