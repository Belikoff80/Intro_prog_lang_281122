// exists set array where n elements. need to find ellement of set equall to 'find'
//1. set the counter index at o position
//2. if array[index]= find, break
//3.increase index+1
//4.if index<n, go to 2 step. in otherwise break

int[] array = { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8 };
int n = array.Length;
int find = 5;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}