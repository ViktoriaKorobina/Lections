int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] numbers = {98, 76, 45, 780, 23, 67, 48, 56, 37};
// int a1 = 98;
// int b1 = 76;
// int c1 = 45;
// int a2 = 780;
// int b2 = 23;
// int c2 = 67;
// int a3 = 48;
// int b3 = 56;
// int c3 = 37;


int max = Max(Max(numbers[0], numbers[1], numbers[2]), Max(numbers[3], numbers[4], numbers[5]), Max(numbers[6], numbers[7], numbers[8]));
Console.WriteLine(max);
