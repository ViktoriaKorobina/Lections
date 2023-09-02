void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] coll)
{
    int len = coll.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(coll[i] + " ");
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 66);
Console.WriteLine(pos);

