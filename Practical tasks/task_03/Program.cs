// Написать программу копирования массива

void FillArray(int[] array, int min, int max)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = random.Next(min, max);
}
int NewArray(int[] array)
{
    int[] newArray = new int[array.Length];
    int result = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        newArray[i] = array[i]*2;
        result = result + newArray[i];
    }
    return result;
}
void PrintArray(int[] array)
{
        foreach (var element in array) Console.Write($"{element} "); 
        Console.WriteLine();
}

Console.Clear();
int[] array = new int[10];
FillArray(array, -100, 100);
PrintArray(array);

//int[] newArray = 

//NewArray(array);
//PrintArray(array);


