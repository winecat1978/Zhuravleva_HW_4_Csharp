// сумма цифр в числе

int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse (ValueFromConsole, out int num))
        {
            return num;
        }
        else
        {
            Console.WriteLine("Введите число!");
        }
    }
}

int Counter (int Number)
{
    int sum = 0;
    if (Number > 0)
    {
        while(Number > 0)
        {
            sum = sum + Number%10;
            Number = Number / 10;
        }
        return sum;
    }
    else if (Number < 0)
    {
        while (-Number > 0)
        {
            sum = sum + (-Number%10);
            Number = Number / 10;
        }
        return sum;
    } 
    else 
    {
        return sum;
    }
}

string message = "Введите число: ";
int Number = GetNumber(message);
int result = Counter(Number);

Console.WriteLine($"{Number} -> {result}");
