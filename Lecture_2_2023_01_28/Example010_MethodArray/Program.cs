int[] array = { 5, 8, 11, 66, 54, 332, 11, 0, -8, 7};

int n = array.Length;
int find = 11;

int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}