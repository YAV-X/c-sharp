

int[] array = { 1, 12, 31, 4, 15, 16, 17, 4 };
int n = array.Length;
int find = 4;
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

//----

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;

//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;

//     while (index < length)
//     {
//         Console.Write(collection[index]);
//         index++;
//     }
// }
