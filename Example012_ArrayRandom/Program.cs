//Create array. Fill in array. Use find method


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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;

    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0; в этом случае, при поиске не существующего числа будет выводится 0 позиция. Это не правильно. 
    //Поэтому мы введем значение posotion = -1
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
int pos = IndexOf(array, 44);
Console.WriteLine(pos);