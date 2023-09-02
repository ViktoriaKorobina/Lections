int[] array = {12, 29, 34, 41, 79, 57, 46, 79, 81};
int n = array.Length;
int find = 79;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
