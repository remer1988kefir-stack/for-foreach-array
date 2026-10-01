string[] cities = { "Варшава", "Москва", "Берлин", "Париж" };
foreach (string city in cities)
{
    if (city.Length > 6)
    {
        Console.WriteLine(city);
    }
}





for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine($"{cities[i]}");
}