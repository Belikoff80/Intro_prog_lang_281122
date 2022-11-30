//Найти максимум в множесве

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;


}
int[] array = { 11, 12, 13, 14, 155, 12, 43, 21, 34 };


int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
// то есть аргументы уже записаны как функции

//code below we could use in case without fuction method
//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;
//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

Console.WriteLine(max);

