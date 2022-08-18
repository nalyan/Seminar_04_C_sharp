// Написать программу масштабирования фигуры


double InputNumber(string text)
{
    Console.Write(text);
    double number = Double.Parse(Console.ReadLine());
    return number;
}
void InputCoord(double[] array, string text)
{
    int count = 1;
    Console.WriteLine(text);
    for (int i = 0; i < array.Length - 1; i += 2)
    {
        array[i] = InputNumber($"x{count}: ");
        array[i + 1] = InputNumber($"y{count}: ");
        count++;
        //if(i==6) break;
    }
}
void PrintCoord(double[] array)
{
    for (int i = 0; i < array.Length; i += 2) Console.Write($"({array[i]}, {array[i + 1]}) ");
    Console.WriteLine();
}

Console.Clear();
int quantity = (int)InputNumber("Введите количество точек в фигуре: ");
double[] array = new double[quantity * 2];
InputCoord(array, "Введите координаты точек: ");
PrintCoord(array);

double k = 0;
double[] arr = { 2, 4, 0.5 };
int i =0;
bool stop = false;
while (true)
{
    k = InputNumber("Введите коэффициент масштабирования (2; 4; 0,5): ");
    for(i=0; i<arr.Length;i++)
    {
        if (arr[i] == k) stop = true;
    }
    if (stop == true) break;
}

double[] newArray = new double[array.Length];
for (int j = 0; j < array.Length; j++) newArray[j] = array[j] * k;
PrintCoord(newArray);
