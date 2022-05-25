// задает массив из 8 элементов и выводит его на экран
int [] ArrayCreation (int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for(int i=0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

int[] array = ArrayCreation(8);
Console.Write(string.Join(",", array));