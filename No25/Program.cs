// прога принимает два числа и возводит одно в степень другого (А и В)

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

double PowerMulti (double A, double B)
{
    double result = Math.Pow(A, B);
    return result;
}


string messA = "Введите число А: ";
string messB = "Введите число В: ";
double A = GetNumber(messA);
double B = GetNumber(messB);
double RESULT = PowerMulti(A, B);

Console.WriteLine($"{A},{B} -> {RESULT}");
