static string GetHint(int distance)
{
    if (distance <= 3)
        return "Очень горячо";
    else if (distance <= 7)
        return "Горячо";
    else if (distance <= 15)
        return "Тепло";
    else
        return "Холодно";
}


