int [] FillArray()
{
    int [] Array = new int [8];
    Random number = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(0,100);
    }
    return Array;
}

int [] arr = FillArray();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

PrintArray(arr);