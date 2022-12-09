
//have a array 6 8 3 2 1 4 5 6 7
//we ae going to use method of max/min for sorting

int[] arr = { 1, 2, 7, 4, 4, 4, 3, 9, 8, 6 };

void PrintArray(int[] array)  // method for outputting of array
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)  //method for sorting of Array
{
    for (int i = 0; i < array.Length - 1; i++) // so as we count cycle j=i+1, therefore cycle will be less than length
    {
        int minPosition = i;
        //futher we are looking for min elements:
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        //ad we replace found elements
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
