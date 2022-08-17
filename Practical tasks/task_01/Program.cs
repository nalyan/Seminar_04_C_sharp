// 1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int InputNumber(string K1, string B1, string K2, string B2)
{
    Console.WriteLine($"Введите число {K1}{B1}{K2}{B2}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Coord(float k1, float b1, float k2, float b2)
{
        if (k1 == k2) Console.WriteLine("Прямые не пересекаются, либо совпадают");
    else
    {
        // k1 * x + b1 = k2 * x + b2
        float x = (b2 - b1) / (k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine($"Координата точки пересечения 2-х прямых: ({x} ; {y})");
    }
}

Console.Clear();
string K1 = "k1";
float k1 = InputNumber(K1: K1, B1: null, K2: null, B2: null);
string B1 = "b1";
float b1 = InputNumber(B1: B1, K1: null, K2: null, B2: null);
string K2 = "k2";
float k2 = InputNumber(K2: K2, B1: null, K1: null, B2: null);
string B2 = "b2";
float b2 = InputNumber(B2: B2, B1: null, K2: null, K1: null);

Coord(k1, b1, k2, b2);
