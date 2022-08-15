// Выяснить являются ли три числа сторонами треугольника
Console.Clear();

void PrintArray(int[] A){
    foreach (var el in A)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine(" ");
}
void FillArrayRandom(int[] A, int min, int max){
    var rand = new Random();
    for (int i = 0; i < A.Length; i++ )
    {
        A[i] = rand.Next(min, max+1);
    }
}
void qt(int[] A){
    if ((A[0]+A[1]) > A[2] &&
    (A[0]+A[2]) > A[1] &&
    (A[2]+A[1]) > A[0]) Console.WriteLine("Это треугольник!");
    else Console.WriteLine("Это не треугольник!");
}
var array = new int[3];
FillArrayRandom(array, 1, 10);
PrintArray(array);
qt(array);


// bool Gfdggdg(int a, int b, int c) => a+b>c && a+c>b && b+c>a)