Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;

    while (index < length)
    {
        if (collection[index] == find)
        {
            position = index;
            return position;
        }
        index++;
    }

    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine(IndexOf(array, 4));