// Показать числа Фибоначчи меньшие заданного числа N

int Fib(int F)
{
    F
}


void FArray(int number)
{
    int F = 0;
    for (int i = 2; i < number; i++)
    {
        F = i - 2 + i - 1;
    }
}

void PrintArray(int[] array)
{
    for (int i = 2; i < number; i++)
    { Console.WriteLine($"{array[i]} "); }
}

int number = int.Parse(Console.ReadLine());
int[] array = new int[10];
FArray[number];
PrintArray[array];

// int n = 10946;
// int fibon1 = 0;
// int fibon2 = 1;
// Console.Write("0 1" + " ");
// while (fibon2 <= n - fibon1)
// {
// int temp = fibon2;
// fibon2 = fibon2 + fibon1;
// fibon1 = temp;
// Console.Write(fibon2 + " ");
// }

// вариант 2
// int[] fibonacci = new int[1000];
// fibonacci[0] = 1;
// fibonacci[1] = 1;
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.Write($"{fibonacci[0]} {fibonacci[1]} ");
// int index = 1;
// while(fibonacci[index]<n)
// {
//     index++;
//     fibonacci[index]=fibonacci[index-1]+fibonacci[index-2];
//     if(fibonacci[index]<n)
//         Console.Write($"{fibonacci[index]} ");
// }
// 